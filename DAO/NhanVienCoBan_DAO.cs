using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class NhanVienCoBan_DAO
    {
        Modify modify = new Modify();

        public DataTable getUSER(string username, string password)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT * FROM CAMPUSADMIN.UV_INFOR";
            datatable = modify.LoadTableByUser(query, username, password);
            return datatable;
        }
        public DataTable getSINHVIEN(string username, string password)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT* FROM CAMPUSADMIN.SINHVIEN";
            datatable = modify.LoadTableByUser(query, username, password);
            return datatable;
        }

        public DataTable getDONVI(string username, string password)
        { 
                DataTable datatable = new DataTable();
                string query = "SELECT* FROM CAMPUSADMIN.DONVI";
                datatable = modify.LoadTableByUser(query, username, password);
                return datatable;
        }

        public DataTable getHOCPHAN(string username, string password)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT* FROM CAMPUSADMIN.HOCPHAN";
            datatable = modify.LoadTableByUser(query, username, password);
            return datatable;
        }

        public DataTable getKHMO(string username, string password)
        {
            DataTable datatable = new DataTable();
            string query = "SELECT* FROM CAMPUSADMIN.KHMO";
            datatable = modify.LoadTableByUser(query, username, password);
            return datatable;
        }
        public List<string> getTHONGBAO(string username, string password)
        {
            string query = "SELECT * FROM ADMIN_OLS.THONGBAO";
            List<string> list = modify.LoadTableNofi(query, username, password);
            return list;
        }

        public void ChangePhoneNumber(string username, string password, string newPhoneNumber)
        {
            string query = $"UPDATE CAMPUSADMIN.NHANSU SET DT = '{newPhoneNumber}' WHERE MANV = '{username}'";
            modify.ExecuteQueryByUser(query, "CAMPUSADMIN", "1");
            //MessageBox.Show("Thay đổi số điện thoại thành công");
        }
    }
}
