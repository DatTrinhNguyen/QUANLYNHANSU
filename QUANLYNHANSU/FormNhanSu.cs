using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNHANSU
{
    public partial class FormNhanSu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool exit = true;
        public FormNhanSu()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ribbonPage1.Visible=false;
        }

        private void btnThoatChuongTrinnh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            exit = false;
            this.Close();
        }

        private void FormNhanSu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

    }
}
