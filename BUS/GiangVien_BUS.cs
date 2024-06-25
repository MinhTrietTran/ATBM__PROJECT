using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiangVien_DAO = DAO.GiangVien_DAO;

namespace BUS
{
    public class GiangVien_BUS
    {
        GiangVien_DAO GiangVien = new GiangVien_DAO();
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
        public DataTable getUSER(string username, string password) => GiangVien.getUSER(username, password);
        public DataTable getSINHVIEN(string username, string password) => GiangVien.getSINHVIEN(username, password);

        public DataTable getPHANCONG(string username, string password) => GiangVien.getPHANCONG(username, password);

        public DataTable getDONVI(string username, string password) => GiangVien.getDONVI(username, password);
        public DataTable getDANGKY(string username, string password) => GiangVien.getDANGKY(username, password);
        public void SuaDiem(string maSV, string maGV, string maHP, string hk, string nam, string maCT, string loaiDiem, string diem, string username, string password) => GiangVien.SuaDiem(maSV,maGV,maHP, hk, nam, maCT, loaiDiem, diem, username, password);
        public DataTable getHOCPHAN(string username, string password) => GiangVien.getHOCPHAN(username, password);

        public DataTable getKHMO(string username, string password) => GiangVien.getKHMO(username, password);

        public void getTHONGBAO(string username, string password)
        {
            try
            {
                List<string> nofi = GiangVien.getTHONGBAO(username, password);

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

        public void ChangePhoneNumber(string username, string password, string newPhoneNumber) => GiangVien.ChangePhoneNumber(username, password, newPhoneNumber);



    }
}
