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
    public partial class FormGiamDoc : DevExpress.XtraEditors.XtraForm
    {
        bool exit = true;
        public FormGiamDoc()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit = false;
            this.Close();
        }

        private void FormGiamDoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }
    }
}