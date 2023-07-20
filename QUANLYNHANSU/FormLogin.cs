﻿using DevExpress.XtraEditors;
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
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }
        //Các điều chỉnh trong form
        private void FormLogin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            //Ẩn mật khẩu
            passwordLogin.UseSystemPasswordChar = true;
            //Khóa copy paste
            usernameLogin.ShortcutsEnabled = false;
            passwordLogin.ShortcutsEnabled = false;
        }
        //Nút đăng nhập
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Condition(usernameLogin.Text, passwordLogin.Text))
            {
                //Kiểm tra tài khoản thuộc phân quyền
                if (usernameLogin.Text == "NhanSu123")
                {
                    this.Hide();
                    usernameLogin.Clear();
                    passwordLogin.Clear();
                    FormNhanSu formNhanSu = new FormNhanSu();
                    formNhanSu.ShowDialog();
                }
                else if (usernameLogin.Text == "GiamDoc123")
                {
                    this.Hide();
                    usernameLogin.Clear();
                    passwordLogin.Clear();
                    FormGiamDoc formGiamDoc = new FormGiamDoc();
                    formGiamDoc.ShowDialog();
                }
                else if (usernameLogin.Text == "KeToan123")
                {
                    this.Hide();
                    usernameLogin.Clear();
                    passwordLogin.Clear();
                    FormGiamDoc formGiamDoc = new FormGiamDoc();
                }
                else
                {
                    passwordLogin.Clear();
                    DialogResult dialogResult = MessageBox.Show("Không tồn tại tài khoản ", "Lỗi", MessageBoxButtons.OKCancel);
                }
                this.Show();
            }
        }

        //Tạo form quên mật khẩu
        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
            this.Show();
        }

        //Thoát 
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Điều kiện đăng nhập
        private bool Condition(string username,string password)
        {
            //Kiểm tra tài khoản
            if (username.Length <8 && username.Length > 25)
            {
                DialogResult dialogResult = MessageBox.Show("Tên tài khoản phải chứa 8 đến 25 ký tự", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            //Kiểm tra password
            if (password.Length == 8 )
            {
                DialogResult dialogResult = MessageBox.Show("Mật khẩu chỉ chứa 8 ký tự", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            //Kiểm tra database
            return true;
        }

        //Nút hiển thị mật khẩu
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passwordLogin.UseSystemPasswordChar = false;
            }
            else
            {
                passwordLogin.UseSystemPasswordChar = true;
            }
        }

        //Không cho phép nhập khoảng trắng
        private void usernameLogin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void passwordLogin_KeyPress(object sender, KeyPressEventArgs e)
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