using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace QUANLYNHANSU
{
    public partial class FormQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        Random random = new Random();
        int otp;
        string gmail;
        public FormQuenMatKhau()
        {
            InitializeComponent();
            
        }
        
        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            inputGmail.ShortcutsEnabled = false;
            inputUsername.ShortcutsEnabled = false;
        }
        private void sentOTPButton_Click(object sender, EventArgs e)
        {
            //Tạo otp
            otp = random.Next(100000, 1000000);
            gmail = inputGmail.Text.TrimEnd();
            //Gửi mã otp
            if (Condition(inputUsername.Text, inputGmail.Text))
            {
                FormQuenMatKhau.sentMail("windowformqlnshe@gmail.com", gmail, "Gửi mã OTP", "Mã OTP của bạn là :" + otp);
                DialogResult dialogResult = MessageBox.Show("Mã OTP đã được gửi", "Thông báo", MessageBoxButtons.OK);
                //Tạo form xác thực
                this.Hide();
                FormXacThuc formXacThuc = new FormXacThuc(otp, gmail);
                formXacThuc.ShowDialog();
            }
           
        }

        //Điều kiện gửi mã
        private bool Condition(string username, string gmail)
        {
            //Kiểm tra tài khoản
            if (username.Length < 8 && username.Length > 25)
            {
                DialogResult dialogResult = MessageBox.Show("Tên tài khoản phải chứa 8 đến 25 ký tự", "Lỗi", MessageBoxButtons.OK);
                return false;
            }

            //Kiểm tra gmail
            if(gmail.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Tên tài khoản Gmail không được bỏ trống ", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            if (!gmail.Contains("@gmail.com"))
            {
                DialogResult dialogResult = MessageBox.Show("Tên tài khoản Gmail không hợp lệ", "Lỗi", MessageBoxButtons.OK);
                return false;
            }

            //Kiểm tra database
            return true;
        }

        //Gửi mail
        public static void sentMail(string from, string to, string subject, string message)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(from, "roqklipzepjnopjc");

            client.Send(mess);

        }

        private void inputUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Không cho phép nhập khoảng trắng");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void inputGmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
                MessageBox.Show("Không cho phép nhập khoảng trắng");
            }
            else
            {
                e.Handled = false;
            }
        }

        
    }
}