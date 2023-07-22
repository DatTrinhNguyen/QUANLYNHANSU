
namespace QUANLYNHANSU
{
    partial class FormThemNhanVien
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
            this.gbThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLuongCoBan = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.MaskedTextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.tbHoTen = new System.Windows.Forms.MaskedTextBox();
            this.btnThemNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbLuongCoBan = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.dtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.gbThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinNhanVien
            // 
            this.gbThongTinNhanVien.Controls.Add(this.dgv);
            this.gbThongTinNhanVien.Location = new System.Drawing.Point(12, 2);
            this.gbThongTinNhanVien.Name = "gbThongTinNhanVien";
            this.gbThongTinNhanVien.Size = new System.Drawing.Size(1030, 319);
            this.gbThongTinNhanVien.TabIndex = 0;
            this.gbThongTinNhanVien.TabStop = false;
            this.gbThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 22);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1018, 291);
            this.dgv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.tbLuongCoBan);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.cbGioiTinh);
            this.groupBox2.Controls.Add(this.tbHoTen);
            this.groupBox2.Controls.Add(this.btnThemNhanVien);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.lbGioiTinh);
            this.groupBox2.Controls.Add(this.lbNgaySinh);
            this.groupBox2.Controls.Add(this.lbLuongCoBan);
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbLuongCoBan
            // 
            this.tbLuongCoBan.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbLuongCoBan.Location = new System.Drawing.Point(672, 119);
            this.tbLuongCoBan.Name = "tbLuongCoBan";
            this.tbLuongCoBan.Size = new System.Drawing.Size(285, 32);
            this.tbLuongCoBan.TabIndex = 19;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbEmail.Location = new System.Drawing.Point(146, 213);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(285, 32);
            this.tbEmail.TabIndex = 17;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(146, 119);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(285, 32);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbHoTen.Location = new System.Drawing.Point(146, 28);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(285, 32);
            this.tbHoTen.TabIndex = 15;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.Appearance.Options.UseFont = true;
            this.btnThemNhanVien.Location = new System.Drawing.Point(421, 288);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(186, 58);
            this.btnThemNhanVien.TabIndex = 13;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbEmail.Location = new System.Drawing.Point(65, 221);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 24);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbGioiTinh.Location = new System.Drawing.Point(65, 127);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(84, 24);
            this.lbGioiTinh.TabIndex = 3;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNgaySinh.Location = new System.Drawing.Point(536, 36);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(97, 24);
            this.lbNgaySinh.TabIndex = 2;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbLuongCoBan
            // 
            this.lbLuongCoBan.AutoSize = true;
            this.lbLuongCoBan.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbLuongCoBan.Location = new System.Drawing.Point(536, 127);
            this.lbLuongCoBan.Name = "lbLuongCoBan";
            this.lbLuongCoBan.Size = new System.Drawing.Size(130, 24);
            this.lbLuongCoBan.TabIndex = 1;
            this.lbLuongCoBan.Text = "Lương cơ bản";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbHoTen.Location = new System.Drawing.Point(65, 36);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(70, 24);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên";
            this.lbHoTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.EditValue = null;
            this.dtNgaySinh.Location = new System.Drawing.Point(672, 34);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Size = new System.Drawing.Size(285, 30);
            this.dtNgaySinh.TabIndex = 20;
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbThongTinNhanVien);
            this.Name = "FormThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormThemNhanVien";
            this.gbThongTinNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbLuongCoBan;
        private DevExpress.XtraEditors.SimpleButton btnThemNhanVien;
        private System.Windows.Forms.MaskedTextBox tbHoTen;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.MaskedTextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox tbLuongCoBan;
        private DevExpress.XtraEditors.DateEdit dtNgaySinh;
    }
}