using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManagement;

namespace DAO
{
    public class LoginDAO
    {
        Modify modify = new Modify();
        public static OracleConnection GetAppConnection(string username, string password)
        {
            if (username == "SYS")
                return new OracleConnection($@"DATA SOURCE=localhost:1521/XEPDB1;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\Users\Admin\Oracle\network\admin;PASSWORD={password};PERSIST SECURITY INFO=True;USER ID=SYS");
            //string newStringConnection = $@"DATA SOURCE = localhost:1521/XEPDB1; USER ID={username} ;PASSWORD={password}";

            string newStringConnection = $@"DATA SOURCE=localhost:1521/XEPDB1;TNS_ADMIN=C:\Users\Admin\Oracle\network\admin;PASSWORD={password};PERSIST SECURITY INFO=True;USER ID={username}";
            return new OracleConnection(newStringConnection);
        }


        public bool IsCorrectRole(string username,string password, string role)
        {
            OracleConnection conn = Connection.GetOracleConnection();
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(GRANTED_ROLE) FROM SYS.DBA_USERS U LEFT JOIN SYS.DBA_ROLE_PRIVS DRP ON U.USERNAME = DRP.GRANTEE WHERE U.USERNAME = :username AND GRANTED_ROLE = :role ";
            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("role", role);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (count != 0)
            {
                return true;
            }
            MessageBox.Show($"So tra ve {count}");
            return false;
        }
    }

}
