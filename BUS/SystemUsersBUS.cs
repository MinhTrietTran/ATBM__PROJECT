using System;
using System.Data;
using System.Windows.Forms;
using SystemUsersDAO = DAO.SystemUsersDAO;

namespace BUS
{
    public class SystemUsersBUS
    {
        private SystemUsersDAO systemUsers;
        public SystemUsersBUS()
        {
            systemUsers = new SystemUsersDAO();
        }
        public DataTable GetAllSystemUsers()
        {
            try
            { 
                return systemUsers.GetAllSystemUsers(); // Gọi phương thức từ DAO để lấy danh sách người dùng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }
        public DataTable FilterSystemUsers(string userName)
        {
            if (userName == "")
            {
                return systemUsers.GetAllSystemUsers(); // Gọi phương thức từ DAO để lấy danh sách người dùng
            }
            else
            {
                try
                {
                    return systemUsers.FilterSystemUsers(userName); // Gọi phương thức từ DAO để lấy danh sách người dùng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return null;
                }
            }
        }

        public void RevokeRole(string userName, string role) => systemUsers.RevokeRole(userName, role); // Gọi phương thức từ DAO để thu hồi quyền

        public DataTable GetRoleOfSelectedUser(string userNameSelected) => systemUsers.GetRoleOfSelectedUser(userNameSelected); // Gọi phương thức từ DAO để lấy danh sách quyền của người dùng
        public DataTable GetAllRoles() => systemUsers.GetAllRoles();

        public void GrantRole(string userName, string role) => systemUsers.GrantRole(userName, role); // Gọi phương thức từ DAO để cấp quyền
    }
    
}
