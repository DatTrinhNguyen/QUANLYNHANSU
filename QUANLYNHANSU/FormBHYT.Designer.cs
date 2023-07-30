
namespace QUANLYNHANSU
{
    partial class FormBHYT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBHYT));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.dtNgayDong = new DevExpress.XtraEditors.DateEdit();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbSoTien = new System.Windows.Forms.MaskedTextBox();
            this.tbMaBHYT = new System.Windows.Forms.MaskedTextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbNgayĐong = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.lbMaBHYT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDong.Properties.CalendarTimeProperties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnThoat,
            this.btnIn,
            this.btnTimKiem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(33, 171);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTimKiem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTimKiem.Caption = "Tim Kiếm";
            this.btnTimKiem.Id = 7;
            this.btnTimKiem.ImageOptions.SvgImage = global::QUANLYNHANSU.Properties.Resources.zoom;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimKiem_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            // 
            // btnThoat
            // 
            this.btnThoat.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 594);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 568);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 568);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhongLuu);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dtNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtNgayDong);
            this.groupBox1.Controls.Add(this.tbMaNV);
            this.groupBox1.Controls.Add(this.tbSoTien);
            this.groupBox1.Controls.Add(this.tbMaBHYT);
            this.groupBox1.Controls.Add(this.lbSoTien);
            this.groupBox1.Controls.Add(this.lbNgayĐong);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbNgayKetThuc);
            this.groupBox1.Controls.Add(this.lbMaBHYT);
            this.groupBox1.Location = new System.Drawing.Point(8, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1147, 225);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Location = new System.Drawing.Point(764, 171);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(129, 32);
            this.btnKhongLuu.TabIndex = 37;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(612, 171);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 32);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(916, 171);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 32);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.EditValue = null;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(673, 102);
            this.dtNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayKetThuc.MenuManager = this.barManager1;
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtNgayKetThuc.Properties.Appearance.Options.UseFont = true;
            this.dtNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKetThuc.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayKetThuc.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayKetThuc.Properties.CalendarTimeProperties.EditFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayKetThuc.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayKetThuc.Properties.DisplayFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayKetThuc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayKetThuc.Properties.EditFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayKetThuc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayKetThuc.Properties.UseMaskAsDisplayFormat = true;
            this.dtNgayKetThuc.Size = new System.Drawing.Size(244, 26);
            this.dtNgayKetThuc.TabIndex = 34;
            // 
            // dtNgayDong
            // 
            this.dtNgayDong.EditValue = null;
            this.dtNgayDong.Location = new System.Drawing.Point(249, 106);
            this.dtNgayDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayDong.MenuManager = this.barManager1;
            this.dtNgayDong.Name = "dtNgayDong";
            this.dtNgayDong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtNgayDong.Properties.Appearance.Options.UseFont = true;
            this.dtNgayDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayDong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayDong.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayDong.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayDong.Properties.CalendarTimeProperties.EditFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayDong.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayDong.Properties.DisplayFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayDong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayDong.Properties.EditFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayDong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayDong.Properties.UseMaskAsDisplayFormat = true;
            this.dtNgayDong.Size = new System.Drawing.Size(243, 26);
            this.dtNgayDong.TabIndex = 33;
            // 
            // tbMaNV
            // 
            this.tbMaNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMaNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMaNV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMaNV.Location = new System.Drawing.Point(673, 31);
            this.tbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(245, 27);
            this.tbMaNV.TabIndex = 32;
            this.tbMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaNV_KeyPress);
            // 
            // tbSoTien
            // 
            this.tbSoTien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbSoTien.Location = new System.Drawing.Point(248, 177);
            this.tbSoTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.Size = new System.Drawing.Size(245, 27);
            this.tbSoTien.TabIndex = 28;
            this.tbSoTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSoTien_KeyDown_1);
            this.tbSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoTien_KeyPress_1);
            // 
            // tbMaBHYT
            // 
            this.tbMaBHYT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMaBHYT.Location = new System.Drawing.Point(248, 27);
            this.tbMaBHYT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaBHYT.Name = "tbMaBHYT";
            this.tbMaBHYT.Size = new System.Drawing.Size(245, 27);
            this.tbMaBHYT.TabIndex = 26;
            this.tbMaBHYT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaBHYT_KeyPress);
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbSoTien.Location = new System.Drawing.Point(181, 184);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(58, 19);
            this.lbSoTien.TabIndex = 25;
            this.lbSoTien.Text = "Số tiền";
            // 
            // lbNgayĐong
            // 
            this.lbNgayĐong.AutoSize = true;
            this.lbNgayĐong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNgayĐong.Location = new System.Drawing.Point(150, 107);
            this.lbNgayĐong.Name = "lbNgayĐong";
            this.lbNgayĐong.Size = new System.Drawing.Size(88, 19);
            this.lbNgayĐong.TabIndex = 24;
            this.lbNgayĐong.Text = "Ngày Đóng";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbMaNV.Location = new System.Drawing.Point(610, 33);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(55, 19);
            this.lbMaNV.TabIndex = 23;
            this.lbMaNV.Text = "Mã NV";
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNgayKetThuc.Location = new System.Drawing.Point(554, 107);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(106, 19);
            this.lbNgayKetThuc.TabIndex = 22;
            this.lbNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // lbMaBHYT
            // 
            this.lbMaBHYT.AutoSize = true;
            this.lbMaBHYT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbMaBHYT.Location = new System.Drawing.Point(164, 33);
            this.lbMaBHYT.Name = "lbMaBHYT";
            this.lbMaBHYT.Size = new System.Drawing.Size(74, 19);
            this.lbMaBHYT.TabIndex = 21;
            this.lbMaBHYT.Text = "Mã BHYT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(10, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1147, 434);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin BHYT";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(20, -58);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1137, 411);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.FloatLocation = new System.Drawing.Point(137, 209);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // FormBHYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBHYT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBHYT";
            this.Load += new System.EventHandler(this.FormBHYT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDong.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MaskedTextBox tbSoTien;
        private System.Windows.Forms.MaskedTextBox tbMaBHYT;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbNgayĐong;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.Label lbMaBHYT;
        private System.Windows.Forms.TextBox tbMaNV;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.DateEdit dtNgayDong;
        private DevExpress.XtraEditors.DateEdit dtNgayKetThuc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
    }
}