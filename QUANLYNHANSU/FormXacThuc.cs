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

namespace QUANLYNHANSU
{
    public partial class FormXacThuc : DevExpress.XtraEditors.XtraForm
    {
        int otp;
        string gmail;
        //Thời gian hiệu lực
        int minute=3,second=0;
        public FormXacThuc(int otp, string gmail)
        {
            InitializeComponent();
            this.otp = otp;
            this.gmail = gmail;
            
        }

        private void FormXacThuc_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = string.Format("{0}:{1}", minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
            inputOTP.ShortcutsEnabled = false;
        }
        private void OTPButton_Click(object sender, EventArgs e)
        {
            //kiểm tra mã xác thực
            if (Condition(otp.ToString(),inputOTP.Text.TrimEnd()))
            {
                if(inputOTP.Text==otp.ToString())
                {
                    timer1.Stop();
                    //Gửi về mail mật khẩu mới
                    string newpass = "@Admin" + otp;
                    FormQuenMatKhau.sentMail("windowformqlnshe@gmail.com", gmail, "Reset mật khẩu", "Mật khẩu mới của bạn là :" + newpass);
                    DialogResult dialogResult = MessageBox.Show("Mật khẩu của bạn đã được reset", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    timer1.Stop();
                    DialogResult dialogResult = MessageBox.Show("Mã OTP không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                }
                this.Close();
            }
            
        }

        private bool Condition(string otp, string inputOTP)
        {
            //Kiểm tra mã OTP
            if (inputOTP.Length != 6)
            {
                DialogResult dialogResult = MessageBox.Show("Mã OTP phải gồm 6 ký tự ", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            char[] check = inputOTP.ToCharArray(0, 6);
            for (int i = 0; i < 6; i++)
            {
                bool isNumber = false;
                for (int j = 0; j <= 9; j++)
                {
                    if ((int)check[i] == 48 + j)
                    {
                        isNumber = true;
                    }
                }
                if (isNumber == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Mã OTP chỉ chứa ký tự số", "Lỗi", MessageBoxButtons.OK);
                    return false;
                }

            }
            return true;
        }

        private void FormXacThuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void inputOTP_KeyPress(object sender, KeyPressEventArgs e)
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

        

        //Sự kiện khi đang đếm lùi
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Dừng đếm và thông báo khi thời gian về 0
            if (minute==0&&second==0)
            {
                timer1.Stop();
                DialogResult dialogResult = MessageBox.Show("Mã OTP hết thời gian hiệu lực", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            //Đếm lùi thời gian
            if (second == 0)
            {
                minute -= 1;
                second = 60;
            }
            second -= 1;
            label2.Text = string.Format("{0}:{1}",minute.ToString().PadLeft(2,'0'),second.ToString().PadLeft(2,'0'));
            
        }
    }
}