using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DAO
{
    public class AuditDAO
    {
        Modify modify = new Modify();
        public DataTable LoadObjects(string username, string password)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT OBJECT_NAME " +
                "FROM ALL_OBJECTS " +
                "WHERE OWNER = 'CAMPUSADMIN' " +
                "ORDER BY OBJECT_TYPE, OBJECT_NAME";
            // Cai ngay nay de t loc may tables he thong thoi chu khong co gi :Đ
            dataTable = modify.LoadTable(query, "CAMPUSADMIN", "1");
            return dataTable;
        }

        public DataTable StandardAudit(string username, string password, string objectName)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT USERNAME, EXTENDED_TIMESTAMP, OBJ_NAME, ACTION_NAME, SQL_TEXT " +
                "FROM DBA_AUDIT_TRAIL " +
                $"WHERE OBJ_NAME = '{objectName}'";
            dataTable = modify.LoadTable(query, username, password);
            return dataTable;
        }
        public DataTable FineGrainedAudit(string username, string password, string cmd)
        {
            DataTable dataTable = new DataTable();
            string query = "";
            if (cmd == "DANGKY(DIEMTH,DIEMQT,DIEMCK,DIEMTK)")
            {
                query = "SELECT DBUID,LSQLTEXT, OBJ$NAME, NTIMESTAMP# FROM SYS.FGA_LOG$ WHERE OBJ$NAME = 'DANGKY'";
            }
            else
            {
                query = "SELECT DBUID,LSQLTEXT, OBJ$NAME, NTIMESTAMP# FROM SYS.FGA_LOG$ WHERE OBJ$NAME = 'NHANSU'";
            }
            dataTable = modify.LoadTable(query, username, password);
            return dataTable;
        }
    }
}
