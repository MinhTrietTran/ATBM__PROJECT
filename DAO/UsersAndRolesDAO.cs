using System.Data;

namespace DAO
{
    public class UsersAndRolesDAO
    {
        Modify modify = new Modify();
        public DataTable LoadAllUsers()
        {
            return modify.LoadTableSys("SELECT USERNAME AS Username, CREATED AS TIME_CREATED FROM all_users ");
        }
        public DataTable LoadAllRoles()
        {
            return modify.LoadTableSys("SELECT ROLE, PASSWORD_REQUIRED FROM DBA_ROLES");
        }
        public DataTable LoadUsersByName(string userName)
        {
            return modify.LoadTableSys("SELECT USERNAME AS Username, CREATED AS TIME_CREATED FROM all_users WHERE USERNAME LIKE '%" + userName + "%'");
        }

        public DataTable LoadRolesByName(string roleName)
        {
            return modify.LoadTableSys("SELECT ROLE, PASSWORD_REQUIRED FROM DBA_ROLES WHERE ROLE LIKE '%" + roleName + "%'");
        }

        public void AddUser(string userName, string passWord)
        {
            string query = "";
            if (passWord == "")
            {
                query = $"CREATE USER {userName} NO AUTHENTICATION";
            }
            else
            {
                query = $"CREATE USER {userName} IDENTIFIED BY {passWord}";
            }
            modify.ExecuteQuery(query);
            // Cho create session để lát đăng nhập vào
            query = $"GRANT CREATE SESSION TO {userName}";
            modify.ExecuteQuery(query);
        }

        public void DropUser(string userName)
        {
            modify.ExecuteQuery($"DROP USER {userName}");
        }

        public void AlterUser(string userName, string passWordChange)
        {
            string query = "";
            if (passWordChange == "")
            {
                query = $"ALTER USER {userName} NO AUTHENTICATION";
            }
            else
            {
                query = $"ALTER USER {userName} IDENTIFIED BY {passWordChange} ";
            }
            modify.ExecuteQuery(query);
        }

        public void AddRole(string roleName, string passWord)
        {
            string query = "";
            if (passWord == "")
            {
                query = $"CREATE ROLE {roleName} NOT IDENTIFIED";
            }
            else
            {
                query = $"CREATE ROLE {roleName} IDENTIFIED by {passWord}";
            }
            modify.ExecuteQuery(query);
        }

        public void DropRole(string roleName)
        {
            modify.ExecuteQuery($"DROP ROLE {roleName}");
        }

        public void AlterRole(string roleName, string passWordChange)
        {
            string query = "";
            if (passWordChange == "")
            {
                query = $"ALTER ROLE {roleName} NOT IDENTIFIED ";
            }
            else
            {
                query = $"ALTER ROLE {roleName} IDENTIFIED BY {passWordChange} ";
            }
            modify.ExecuteQuery(query);
        }
    }
}
