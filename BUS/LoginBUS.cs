using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginDAO = DAO.LoginDAO;

namespace BUS
{
    public class LoginBUS
    {
        LoginDAO login = new LoginDAO();
        public bool Authenticate(string username, string password, string role)
        {
            // Used to test the connection
            MessageBox.Show($"{username}, {password}, {role}");

            using (var conn = LoginDAO.GetAppConnection(username, password, role))
            {
                try
                {
                    conn.Open();
                    // Thực hiện các thao tác với cơ sở dữ liệu
                    //Console.WriteLine("Kết nối thành công!");
                    return true && login.IsCorrectRole(username, password, role);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"Lỗi khi kết nối: {ex.Message}");
                    MessageBox.Show($"Lỗi khi kết nối: {ex.Message}");
                }
            }
            return false;


          
            //using (var conn = newLogin.GetAppConnection(username, password, role))
            //{
            //    try
            //    {
            //        conn.Open();
            //        // Thực hiện các thao tác với cơ sở dữ liệu
            //        Console.WriteLine("Kết nối thành công!");
            //        return true;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Lỗi khi kết nối: {ex.Message}");
            //        MessageBox.Show($"Lỗi khi kết nối: {ex.Message}");
            //    }
            //}
            //return false;
        }
    }
}
