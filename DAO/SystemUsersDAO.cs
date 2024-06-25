using System.Data;

namespace DAO
{
    public class SystemUsersDAO
    {
        Modify modify = new Modify();
        public DataTable GetAllSystemUsers()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT U.USERNAME, " +
                                                            "COALESCE(DRP.GRANTED_ROLE, 'N/A') AS GRANTED_ROLE, " +
                                                            "COALESCE(DRP.ADMIN_OPTION, 'N/A') AS ADMIN_OPTION, " +
                                                            "COALESCE(DRP.DEFAULT_ROLE, 'N/A') AS DEFAULT_ROLE, " +
                                                            "COALESCE(DRP.INHERITED, 'N/A') AS INHERITED " +
                                                    "FROM  DBA_USERS U " +
                                                    "LEFT JOIN DBA_ROLE_PRIVS DRP ON  U.USERNAME = DRP.GRANTEE";
            dataTable = modify.LoadTableSys(query);
            return dataTable;
        }

        public DataTable FilterSystemUsers(string userName)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT U.USERNAME, " +
                                                            "COALESCE(DRP.GRANTED_ROLE, 'N/A') AS GRANTED_ROLE, " +
                                                            "COALESCE(DRP.ADMIN_OPTION, 'N/A') AS ADMIN_OPTION, " +
                                                            "COALESCE(DRP.DEFAULT_ROLE, 'N/A') AS DEFAULT_ROLE, " +
                                                            "COALESCE(DRP.INHERITED, 'N/A') AS INHERITED " +
                                                    "FROM  DBA_USERS U " +
                                                    "LEFT JOIN DBA_ROLE_PRIVS DRP ON  U.USERNAME = DRP.GRANTEE " +
                                                    "WHERE UPPER(U.USERNAME) LIKE '%" + userName + "%' ";
            dataTable = modify.LoadTableSys(query);
            return dataTable;
        }


        public void RevokeRole(string userName, string role)
        {
            string query = $"REVOKE {role} FROM {userName}";
            modify.ExecuteQuery(query);
        }

        public DataTable GetRoleOfSelectedUser(string userNameSelected)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT DRP.GRANTED_ROLE " +
                            "FROM DBA_USERS U LEFT JOIN DBA_ROLE_PRIVS DRP ON U.USERNAME = DRP.GRANTEE " +
                            "WHERE U.USERNAME = '" + userNameSelected + "' AND DRP.GRANTED_ROLE IS NOT NULL";
            dataTable = modify.LoadTableSys(query);
            return dataTable;
        }

        public DataTable GetAllRoles()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ROLE FROM DBA_ROLES";
            dataTable = modify.LoadTableSys(query);
            return dataTable;
        }

        public void GrantRole(string userName, string role) 
        {
            string query = $"GRANT {role} TO {userName}";
            modify.ExecuteQuery(query);
        }
    }
}




