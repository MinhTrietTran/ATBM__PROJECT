using System.Data;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using PrivilegesDAO = DAO.PrivilegesDAO;

namespace BUS
{
    public class PrivilegesBUS
    {
        PrivilegesDAO privileges = new PrivilegesDAO();
        public DataTable LoadAllusersInTabLevel(string username, string password) => privileges.LoadAllUsersInTabLevel(username,password);

        public DataTable LoadAllusersInColLevel(string username, string password) => privileges.LoadAllUsersInColLevel(username, password);


        public DataTable LoadAllRolesInTabLevel(string username, string password) => privileges.LoadAllRolesInTabLevel(username, password);


        public DataTable LoadAllRolesInColLevel(string username, string password) => privileges.LoadAllRolesInColLevel(username, password);


        public DataTable FilterUsersInTabLevel(string usernameSearch, string username, string password) => privileges.FilterUsersInTabLevel(usernameSearch, username, password);

        public DataTable FilterUsersInColLevel(string usernameSearch, string username, string password) => privileges.FilterUsersInColLevel(usernameSearch, username, password);

        public DataTable FilterRolesInTabLevel(string roleSearch, string username, string password) => privileges.FilterRolesInTabLevel(roleSearch, username, password);

        public DataTable FilterRolesInColLevel(string roleSearch, string username, string password) => privileges.FilterRolesInColLevel(roleSearch, username, password);

        public DataTable LoadTables(string username, string password, string role) => privileges.LoadTables(username, password, role);

        public DataTable LoadColumnsOfTable(string table, string username, string password, string role) => privileges.LoadColumnsOfTable(table, username, password, role);

        public void GrantUser(string privilege, string table, string user, string username, string password, string role) => privileges.GrantUser(privilege, table, user, username, password, role);

        public void GrantUserWithGrantOption(string privilege, string tablem, string user, string username, string password, string role) => privileges.GrantUserWithGrantOption((string)privilege, tablem, user, username, password, role);

        public void GrantUserToColLevel(string privilege, string column, string table, string user, string username, string password, string role) => privileges.GrantUserToColLevel(privilege, column, table, user, username, password, role);
        public void GrantUserToColLevelWithGrantOption(string privilege, string column, string table, string user, string username, string password, string role) => privileges.GrantUserToColLevelWithGrantOption(privilege, column, table, user, username, password, role);

        public void GrantUserSelectToColLevel(string column, string table, string user, string username, string password, string role) => privileges.GrantUserSelectToColLevel((string)column, table, user, username, password, role);
        public void GrantUserSelectToColLevelWithGrantOption(string column, string table, string user, string username, string password, string role) => privileges.GrantUserSelectToColLevelWithGrantOption((string)column, table, user, username, password, role);

        public void RevokeUser(string privilege, string table, string user, string username, string password, string role) => privileges.RevokeUser(privilege, table, user, username, password, role);
    }
}
