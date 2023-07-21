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
        string permission;
        public FormNhanSu(string permission )
        {
            InitializeComponent();
            this.permission = permission;
            Decentralization(permission);
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

        //Phân quyền từng chức vụ
        private void Decentralization(string permission)
        {
            //Phân quyền giám đốc
            if (permission.Contains("GiamDoc"))
            {
                ribbonPage4.Visible = false;
                btnLoaiCong.Enabled = false;
                btnLoaiCa.Enabled= false;
                ribbonPage5.Visible = false;
                ribbonPage7.Visible = false;
                return;
            }

            //Phân quyền nhân sự
            if (permission.Contains("NhanSu"))
            {
                ribbonPage2.Visible = false;
                ribbonPage4.Visible = false;
                return;
            }

            //Phân quyền kế toán
            if (permission.Contains("KeToan"))
            {
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage7.Visible = false;
                return;
            }
        }
    }
}
