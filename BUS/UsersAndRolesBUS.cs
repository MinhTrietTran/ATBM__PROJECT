using System.Data;
using UsersAndRolesDAO = DAO.UsersAndRolesDAO;

namespace BUS
{
    public class UsersAndRolesBUS
    {
        UsersAndRolesDAO usersAndRoles = new UsersAndRolesDAO();
        public DataTable LoadAllUsers() => usersAndRoles.LoadAllUsers();
        public DataTable LoadAllRoles() => usersAndRoles.LoadAllRoles();

        public DataTable LoadUsersByName(string userName) => usersAndRoles.LoadUsersByName(userName);
        public DataTable LoadRolesByName(string roleName) => usersAndRoles.LoadRolesByName(roleName);

        public void AddUser(string userName, string passWord) => usersAndRoles.AddUser(userName, passWord);

        public void DropUser(string userName) => usersAndRoles.DropUser(userName);
        public void AlterUser(string userName, string passWordChange) => usersAndRoles.AlterUser(userName, passWordChange);

        public void AddRole(string userName, string roleName) => usersAndRoles.AddRole(userName, roleName);
        public void DropRole(string roleName) => usersAndRoles.DropRole(roleName);
        public void AlterRole(string roleName, string passWordChange) => usersAndRoles.AlterRole(roleName, passWordChange);
    }
}
