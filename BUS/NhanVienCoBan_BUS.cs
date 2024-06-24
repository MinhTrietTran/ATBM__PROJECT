using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanVienCoBan_DAO = DAO.NhanVienCoBan_DAO;

namespace BUS
{
    public class NhanVienCoBan_BUS
    {
        NhanVienCoBan_DAO nhanVienCoBan = new NhanVienCoBan_DAO();
        public bool IsWithinFirstFourteenDays(DateTime currentDate)
        {
            int currentMonth = currentDate.Month;
            int currentDay = currentDate.Day;

            if ((currentMonth == 1 || currentMonth == 3 || currentMonth == 9) && currentDay <= 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getUSER(string username, string password) => nhanVienCoBan.getUSER(username, password);
        public DataTable getSINHVIEN(string username, string password) => nhanVienCoBan.getSINHVIEN(username, password);

        public DataTable getDONVI(string username, string password) => nhanVienCoBan.getDONVI(username, password);

        public DataTable getHOCPHAN(string username, string password) => nhanVienCoBan.getHOCPHAN(username, password);

        public DataTable getKHMO(string username, string password) => nhanVienCoBan.getKHMO(username, password);

        public void getTHONGBAO(string username, string password)
        {
            try
            {
                List<string> nofi = nhanVienCoBan.getTHONGBAO(username, password);

                if (nofi.Count > 0)
                {
                    string message = string.Join(Environment.NewLine, nofi);
                    MessageBox.Show(message, "Notification");
                }
                else
                {
                    MessageBox.Show("Don't have any notifiaction", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        public void ChangePhoneNumber(string username, string password, string newPhoneNumber) => nhanVienCoBan.ChangePhoneNumber(username, password, newPhoneNumber);


    }
}
