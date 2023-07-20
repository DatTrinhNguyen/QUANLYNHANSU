
namespace QUANLYNHANSU
{
    partial class FormGiamDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngSốKỹThuậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươnggiờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luậtLaoĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngSốKỹThuậtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngSốKỹThuậtToolStripMenuItem
            // 
            this.thôngSốKỹThuậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuếToolStripMenuItem,
            this.lươnggiờToolStripMenuItem,
            this.luậtLaoĐộngToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngSốKỹThuậtToolStripMenuItem.Name = "thôngSốKỹThuậtToolStripMenuItem";
            this.thôngSốKỹThuậtToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.thôngSốKỹThuậtToolStripMenuItem.Text = "Thông số kỹ thuật";
            // 
            // thuếToolStripMenuItem
            // 
            this.thuếToolStripMenuItem.Name = "thuếToolStripMenuItem";
            this.thuếToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.thuếToolStripMenuItem.Text = "Thuế";
            // 
            // lươnggiờToolStripMenuItem
            // 
            this.lươnggiờToolStripMenuItem.Name = "lươnggiờToolStripMenuItem";
            this.lươnggiờToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.lươnggiờToolStripMenuItem.Text = "Lương/giờ";
            // 
            // luậtLaoĐộngToolStripMenuItem
            // 
            this.luậtLaoĐộngToolStripMenuItem.Name = "luậtLaoĐộngToolStripMenuItem";
            this.luậtLaoĐộngToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.luậtLaoĐộngToolStripMenuItem.Text = "Luật lao động";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // FormGiamDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 386);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGiamDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiamDoc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGiamDoc_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngSốKỹThuậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươnggiờToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luậtLaoĐộngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}