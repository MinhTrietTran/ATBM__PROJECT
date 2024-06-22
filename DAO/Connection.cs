using Oracle.ManagedDataAccess.Client;

namespace UsersManagement
{
    public class Connection
    {
        private static string stringConnection = @"DATA SOURCE=localhost:1521/XEPDB1;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\Users\Admin\Oracle\network\admin;PASSWORD=heongusi22;PERSIST SECURITY INFO=True;USER ID=SYS";
        public static OracleConnection GetOracleConnection()
        {
            return new OracleConnection(stringConnection);
        }
    }
}
