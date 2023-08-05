
namespace QUANLYNHANSU
{
    partial class FormKhenThuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhenThuong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbSoTien = new System.Windows.Forms.MaskedTextBox();
            this.tbMaKT = new System.Windows.Forms.MaskedTextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.lbMaKT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.IDKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.btnKhongLuu);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.tbMaNV);
            this.groupBox1.Controls.Add(this.tbSoTien);
            this.groupBox1.Controls.Add(this.tbMaKT);
            this.groupBox1.Controls.Add(this.lbSoTien);
            this.groupBox1.Controls.Add(this.lbNgayLap);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbNgayKetThuc);
            this.groupBox1.Controls.Add(this.lbMaKT);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1338, 277);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // tbHoTen
            // 
            this.tbHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbHoTen.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbHoTen.Location = new System.Drawing.Point(793, 128);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(285, 32);
            this.tbHoTen.TabIndex = 38;
            this.tbHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoTen_KeyPress);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Location = new System.Drawing.Point(891, 210);
            this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(150, 39);
            this.btnKhongLuu.TabIndex = 37;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(714, 210);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 39);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1069, 210);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(150, 39);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.EditValue = null;
            this.dtNgayLap.Location = new System.Drawing.Point(290, 130);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtNgayLap.Properties.Appearance.Options.UseFont = true;
            this.dtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayLap.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayLap.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayLap.Properties.CalendarTimeProperties.EditFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayLap.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayLap.Properties.DisplayFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayLap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayLap.Properties.EditFormat.FormatString = "MM/dd/YYYY";
            this.dtNgayLap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayLap.Properties.UseMaskAsDisplayFormat = true;
            this.dtNgayLap.Size = new System.Drawing.Size(283, 30);
            this.dtNgayLap.TabIndex = 33;
            // 
            // tbMaNV
            // 
            this.tbMaNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMaNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMaNV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMaNV.Location = new System.Drawing.Point(793, 38);
            this.tbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(285, 32);
            this.tbMaNV.TabIndex = 32;
            this.tbMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaNV_KeyPress);
            // 
            // tbSoTien
            // 
            this.tbSoTien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbSoTien.Location = new System.Drawing.Point(289, 218);
            this.tbSoTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.Size = new System.Drawing.Size(285, 32);
            this.tbSoTien.TabIndex = 28;
            this.tbSoTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSoTien_KeyDown_1);
            this.tbSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoTien_KeyPress_1);
            // 
            // tbMaKT
            // 
            this.tbMaKT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMaKT.Location = new System.Drawing.Point(290, 33);
            this.tbMaKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaKT.Name = "tbMaKT";
            this.tbMaKT.Size = new System.Drawing.Size(285, 32);
            this.tbMaKT.TabIndex = 26;
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbSoTien.Location = new System.Drawing.Point(211, 226);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(72, 24);
            this.lbSoTien.TabIndex = 25;
            this.lbSoTien.Text = "Số tiền";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNgayLap.Location = new System.Drawing.Point(190, 132);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(93, 24);
            this.lbNgayLap.TabIndex = 24;
            this.lbNgayLap.Text = "Ngày Lập";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbMaNV.Location = new System.Drawing.Point(720, 41);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(67, 24);
            this.lbMaNV.TabIndex = 23;
            this.lbMaNV.Text = "Mã NV";
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNgayKetThuc.Location = new System.Drawing.Point(712, 132);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(75, 24);
            this.lbNgayKetThuc.TabIndex = 22;
            this.lbNgayKetThuc.Text = "Họ Tên";
            // 
            // lbMaKT
            // 
            this.lbMaKT.AutoSize = true;
            this.lbMaKT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbMaKT.Location = new System.Drawing.Point(122, 38);
            this.lbMaKT.Name = "lbMaKT";
            this.lbMaKT.Size = new System.Drawing.Size(161, 24);
            this.lbMaKT.TabIndex = 21;
            this.lbMaKT.Text = "Mã Khen Thưởng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1338, 534);
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
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKT,
            this.IDNV,
            this.HoTen,
            this.NgayLap,
            this.SoTien});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(6, 22);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1326, 506);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // IDKT
            // 
            this.IDKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDKT.DataPropertyName = "MAKT";
            this.IDKT.HeaderText = "IDKT";
            this.IDKT.MinimumWidth = 6;
            this.IDKT.Name = "IDKT";
            // 
            // IDNV
            // 
            this.IDNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDNV.DataPropertyName = "IDNV";
            this.IDNV.HeaderText = "IDNV";
            this.IDNV.MinimumWidth = 6;
            this.IDNV.Name = "IDNV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            // 
            // SoTien
            // 
            this.SoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "SoTien";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.FloatLocation = new System.Drawing.Point(137, 209);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(26, 160);
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(26, 160);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5,
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControl1);
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
            this.barManager1.MainMenu = this.bar5;
            this.barManager1.MaxItemId = 14;
            this.barManager1.StatusBar = this.bar6;
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.FloatLocation = new System.Drawing.Point(75, 164);
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTimKiem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
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
            this.btnTimKiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTimKiem.ImageOptions.SvgImage")));
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
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1361, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 847);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1361, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 815);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1361, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 815);
            // 
            // FormKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 867);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKhenThuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBHYT";
            this.Load += new System.EventHandler(this.FormKhenThuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MaskedTextBox tbSoTien;
        private System.Windows.Forms.MaskedTextBox tbMaKT;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.Label lbMaKT;
        private System.Windows.Forms.TextBox tbMaNV;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraEditors.DateEdit dtNgayLap;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
        private DevExpress.XtraBars.Bar bar4;
        private System.Windows.Forms.TextBox tbHoTen;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnTimKiem;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
    }
}