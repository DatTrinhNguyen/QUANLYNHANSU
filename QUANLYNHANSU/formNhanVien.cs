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
using Npgsql;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.CodeParser;
using System.Globalization;
using DevExpress.CodeParser.Diagnostics;
using System.Collections;

namespace QUANLYNHANSU
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them = false, sua = false;
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
        public FormNhanVien()
        {
            InitializeComponent();
            // Thêm dữ liệu giới tính vào ComboBox
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            showHide(true);
            //Khóa chức năng paste
            tbMaNV.ShortcutsEnabled = false;
            tbHoDem.ShortcutsEnabled = false;
            tbTen.ShortcutsEnabled = false;
            tbDanToc.ShortcutsEnabled = false;
            tbDanToc.ShortcutsEnabled = false;
            tbTrinhDo.ShortcutsEnabled = false;
            tbCCCD.ShortcutsEnabled = false;
            tbSDT.ShortcutsEnabled = false;
            tbDiaChi.ShortcutsEnabled = false;
            tbLuongTT.ShortcutsEnabled = false;
            loadData();
        }
        //Hiển thị hoặc tắt các chức năng
        void showHide(bool kt)
        {
            //Tắt bật các nút
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnLuu.Enabled = !kt;
            btnKhongLuu.Enabled = !kt;
            btnIn.Enabled = kt;
            btnTimKiem.Enabled = kt;


            //Tắt bật các text box
            tbHoDem.Enabled = !kt;
            tbMaNV.Enabled = false;
            tbTen.Enabled = !kt;
            dtngaySinh.Enabled = !kt;
            dtngayVaoLam.Enabled = !kt;
            tbSDT.Enabled = !kt;
            tbLuongTT.Enabled = !kt;
            tbDiaChi.Enabled = !kt;
            tbCCCD.Enabled = !kt;
            tbTonGiao.Enabled = !kt;
            tbTrinhDo.Enabled = !kt;
            tbDanToc.Enabled = !kt;
            tbPhongBan.Enabled = !kt;
            cbGioiTinh.Enabled = !kt;
            tbChucVu.Enabled = !kt;
            btnTim.Enabled = false;
        }
        void clear()
        {

            //Làm sạch các text box
            tbHoDem.Clear();
            tbMaNV.Clear();
            tbTen.Clear();
            dtngaySinh.Clear();
            dtngayVaoLam.Clear();
            tbSDT.Clear();
            tbLuongTT.Clear();
            tbDiaChi.Clear();
            tbCCCD.Clear();
            tbTonGiao.Clear();
            tbTrinhDo.Clear();
            tbDanToc.Clear();
            tbPhongBan.Clear();
            cbGioiTinh.ResetText();
            tbChucVu.Clear();
        }



        //Load dữ liệu từ database
        void loadData()
        {
            dgv.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"IDNV\",\"HODEM\",\"TEN\",\"GIOITINH\",\"NGAYSINH\",\"CMND\",\"SDT\",\"DIACHI\"" +
                ",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\" FROM public.\"tb.NHANVIEN\"WHERE \"TRANGTHAI\" = '1';";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                // Thêm cột mới để lưu trữ giới tính dưới dạng chuỗi
                DataColumn gioiTinhTextColumn = new DataColumn("GioiTinh", typeof(string));
                dataTable.Columns.Add(gioiTinhTextColumn);

                // Ánh xạ giá trị giới tính từ kiểu bit thành chuỗi
                foreach (DataRow row in dataTable.Rows)
                {
                    bool gioiTinhBit = (bool)row["GIOITINH"];
                    string gioiTinhText = gioiTinhBit ? "Nữ" : "Nam";
                    row["GioiTinh"] = gioiTinhText;
                }
                dataTable.Columns.Remove("GIOITINH");
                dgv.DataSource = dataTable;
            }
            connection.Dispose();
            connection.Close();
        }



        //Hàm dùng cho text box tự gợi ý
        private void FormNhanVien_Load(object sender, EventArgs e)
        {

            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"IDPB\" FROM public.\"tb.NHANVIEN\"";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                auto.Add(dataReader.GetString(0));
            }
            tbChucVu.AutoCompleteCustomSource = auto;
            tbChucVu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbChucVu.AutoCompleteMode = AutoCompleteMode.Suggest;
            command.CommandText = "SELECT \"IDCV\" FROM public.\"tb.NHANVIEN\"";
            while (dataReader.Read())
            {
                auto.Add(dataReader.GetString(0));
            }
            tbPhongBan.AutoCompleteCustomSource = auto;
            tbPhongBan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPhongBan.AutoCompleteMode = AutoCompleteMode.Suggest;
            connection.Close();
        }

        //Nút thêm dữ liệu vào database
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            clear();
            them = true;
            TangidNV();
            tbHoDem.Focus();
            Tabindex();
        }
        //Thứ tự tab trong hàm thêm
        private void Tabindex()
        {
            tbHoDem.TabIndex = 0;
            tbTen.TabIndex = 1;
            cbGioiTinh.TabIndex = 2;
            dtngaySinh.TabIndex = 3;
            tbDanToc.TabIndex = 4;
            tbTonGiao.TabIndex = 5;
            tbTrinhDo.TabIndex = 6;
            tbCCCD.TabIndex = 7;
            tbSDT.TabIndex = 8;
            tbDiaChi.TabIndex = 9;
            tbLuongTT.TabIndex = 10;
            tbPhongBan.TabIndex = 11;
            tbChucVu.TabIndex = 12;
            dtngayVaoLam.TabIndex = 13;
            btnLuu.TabIndex = 14;
            btnKhongLuu.TabIndex = 15;
        }

        // Hàm lấy mã nhân viên cuối cùng trong cơ sở dữ liệu
        private int LayMaNhanVienCuoiCung()
        {
            int idNV = 0;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            // Truy vấn mã nhân viên lớn nhất trong cơ sở dữ liệu
            command.CommandText = "SELECT MAX(\"IDNV\") FROM public.\"tb.NHANVIEN\"";
            object kq = command.ExecuteScalar();

            if (kq != null && kq != DBNull.Value)
            {
                string kq1 = kq.ToString();//chuyển đổi từ object sang string
                string kq2 = kq1.Substring(2);//loại bỏ 2 ký tự đầu.
                                              //Chuyển đổi kiểu sang int 
                int maxMaNV = Convert.ToInt32(kq2);
                idNV = maxMaNV;
            }
            else
            {
                // Nếu chưa có mã nhân viên trong cơ sở dữ liệu, bắt đầu từ mã NV000000
                idNV = 0;
            }

            connection.Dispose();
            connection.Close();
            return idNV;
        }
        private void TangidNV()
        {
            int idNV = LayMaNhanVienCuoiCung(); // Gọi hàm để lấy mã nhân viên cuối cùng
            idNV++;
            tbMaNV.Text = "NV" + idNV.ToString("D6");// Định dạng mã nhân viên với 6 chữ số (NV000001, NV000002, ...)
        }


        //Thêm dữ liệu vào database
        private void Them()
        {
            string maNV = tbMaNV.Text;
            string hoDem = tbHoDem.Text.ToString();
            string Ten = tbTen.Text.ToString();
            string gioiTinh = cbGioiTinh.Text.ToString();     
            string CMND = tbCCCD.Text.ToString();
            string SDT = tbSDT.Text.ToString();
            string diaChi = tbDiaChi.Text.ToString();
            string idPB = tbChucVu.Text.ToString();
            string idCV = tbPhongBan.Text.ToString();
            string luong = tbLuongTT.Text.ToString();
            string tonGiao = tbTonGiao.Text.ToString();
            string danToc = tbDanToc.Text.ToString();
            string trinhDo = tbDanToc.Text.ToString();
            string ngaySinh = dtngaySinh.Text;
            string ngayVaoLam = dtngayVaoLam.Text;

            if (!HoDem_Condition(hoDem))
            {
                return;
            }
            if (!Ten_Condition(Ten))
            {
                return;
            }
            if (!cbGioiTinh_Condition(gioiTinh))
            {
                return;
            }
            if (!NgaySinh_Condition(ngaySinh))
            {
                return;
            }
            if (!DanToc_Condition(danToc))
            {
                return;
            }
            if (!TonGiao_Condition(tonGiao))
            {
                return;
            }
            if (!TrinhDo_Condition(trinhDo))
            {
                return;
            }
            if (!CCCD_Condition(CMND))
            {
                return;
            }
            if (!SDT_Condition(SDT))
            {
                return;
            }
            if (!DiaChi_Condition(diaChi))
            {
                return;
            }
            if (!LuongTT_Condition(luong))
            {
                return;
            }
            if (!NgayVaoLam_Condition(ngayVaoLam))
            {
                return;
            }

            //Điều kiện phòng ban , chức vụ  

            //Ép kiểu
            DateTime ngaySinhDate = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngaySinhFormatted = ngaySinhDate.ToString("MM/dd/yyyy");

            DateTime ngayVaoLamDate = DateTime.ParseExact(ngayVaoLam, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngayVaoLamFormatted = ngayVaoLamDate.ToString("MM/dd/yyyy");

            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            if (cbGioiTinh.SelectedItem.ToString() == "Nam")
            {
                command.CommandText = "INSERT INTO public.\"tb.NHANVIEN\"(\"IDNV\",\"HODEM\",\"TEN\",\"GIOITINH\",\"NGAYSINH\",\"CMND\",\"SDT\",\"DIACHI\"" +
                    ",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\",\"TRANGTHAI\")" +
                "VALUES(\'" + maNV + "\', \'" + hoDem + "\', \'" + Ten + "\' ,'0', \'" + ngaySinhFormatted + "\', \'" + CMND + "\', \'" + SDT + "\'" +
                ", \'" + diaChi + "\', \'" + idPB + "\', \'" + idCV + "\', \'" + luong + "\', \'" + ngayVaoLamFormatted + "\', \'" + danToc + "\', \'" + tonGiao + "\', \'" + trinhDo + "\', \'1\');";
                command.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();               
                loadData();
            }

            else if (cbGioiTinh.SelectedItem.ToString() == "Nữ")
            {
                command.CommandText = "INSERT INTO public.\"tb.NHANVIEN\"(\"IDNV\",\"HODEM\",\"TEN\",\"GIOITINH\",\"NGAYSINH\",\"CMND\",\"SDT\",\"DIACHI\"" +
                    ",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\",\"TRANGTHAI\")" +
                "VALUES(\'" + maNV + "\', \'" + hoDem + "\', \'" + Ten + "\' , '1', \'" + ngaySinhFormatted + "\', \'" + CMND + "\', \'" + SDT + "\'" +
                ", \'" + diaChi + "\', \'" + idPB + "\', \'" + idCV + "\', \'" + luong + "\', \'" + ngayVaoLamFormatted + "\', \'" + danToc + "\', \'" + tonGiao + "\', \'" + trinhDo + "\', \'1\');";
                command.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
                loadData();
            }
            clear();           
        }


        //Nút sửa dữ liệu vào database
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            tbHoDem.Enabled = false;
            tbMaNV.Enabled = false;
            tbTen.Enabled = false;
            dtngaySinh.Enabled = false;
            dtngayVaoLam.Enabled = false;
            tbCCCD.Enabled = false;
            tbTonGiao.Enabled = false;
            tbTrinhDo.Enabled = false;
            tbDanToc.Enabled = false;
            cbGioiTinh.Enabled = false;
            sua = true;
        }
        //Sửa dữ liệu trong database
        private void Sua()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string idNV = tbMaNV.Text;
                string hoDem = tbHoDem.Text.ToString();
                string Ten = tbTen.Text.ToString();
                string gioiTinh = cbGioiTinh.Text.ToString();
                string CMND = tbCCCD.Text.ToString();
                string SDT = tbSDT.Text.ToString();
                string diaChi = tbDiaChi.Text.ToString();
                string idPB = tbChucVu.Text.ToString();
                string idCV = tbPhongBan.Text.ToString();
                string luong = tbLuongTT.Text.ToString();
                string tonGiao = tbTonGiao.Text.ToString();
                string danToc = tbDanToc.Text.ToString();
                string trinhDo = tbDanToc.Text.ToString();
                string ngaySinh = dtngaySinh.Text;
                string ngayVaoLam = dtngayVaoLam.Text;

                //Biến tạm
                string _SDT = selectedRow.Cells[6].Value.ToString();
                string _diaChi = selectedRow.Cells[7].Value.ToString();
                string _idPB = selectedRow.Cells[8].Value.ToString();
                string _idCV = selectedRow.Cells[9].Value.ToString();
                string _luong = selectedRow.Cells[10].Value.ToString();

                if (_SDT != SDT)
                {
                    if (!SDT_Condition(SDT))
                    {
                        return;
                    }
                }
                if (_diaChi != diaChi)
                {
                    if (!DiaChi_Condition(diaChi))
                    {
                        return;
                    }
                }
                /*if (_idPB != idPB)
                {
                    if (!_Condition(SDT))
                    {
                        return;
                    }
                }*/

                if (_luong != luong)
                {
                    if (!LuongTT_Condition(luong))
                    {
                        return;
                    }
                }
                DateTime ngaySinhDate = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string ngaySinhFormatted = ngaySinhDate.ToString("MM/dd/yyyy");

                DateTime ngayVaoLamDate = DateTime.ParseExact(ngayVaoLam, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string ngayVaoLamFormatted = ngayVaoLamDate.ToString("MM/dd/yyyy");

                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.NHANVIEN\" " +
                                      "SET \"SDT\" = @SDT, \"DIACHI\" = @DiaChi, \"IDPB\" = @IDPB, \"IDCV\" = @IDCV, \"LUONG\" = @Luong " +
                                      "WHERE \"IDNV\" = @IDNV;";

                command.Parameters.AddWithValue("@SDT", SDT);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@IDPB", idPB);
                command.Parameters.AddWithValue("@IDCV", idCV);
                command.Parameters.AddWithValue("@Luong", luong);
                command.Parameters.AddWithValue("@IDNV", idNV);

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();
                clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Nút Xoá dữ liệu vào database
        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);       
            Xoa();
        }
        //Xóa dữ liệu (vô hiệu hóa) 
        private void Xoa()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgv.SelectedRows[0];
                    string idNV = selectedRow.Cells[0].Value.ToString();
                    // Kết nối tới cơ sở dữ liệu
                    NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                    command.CommandText = "UPDATE public.\"tb.NHANVIEN\" SET  \"TRANGTHAI\"=\'0\' WHERE \"IDNV\"=\'" + idNV + "\';";

                    // Thực thi truy vấn
                    command.ExecuteNonQuery();
                    // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                    loadData();
                    clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        //Nút thoát chức năng 
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
            clear();
            loadData();
        }

        //Nút Lưu dữ liệu 
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (them == true)
                {
                    Them();
                    TangidNV();
                }

                if (sua == true)
                {
                    Sua();
                }
            }
        }


        //Nút Không lưu dữ liệu
        private void btnKhongLuu_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn xoá những thông tin thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                showHide(true);
                clear();
            }
        }


        //Nút mở chức năng Tìm Kiếm dữ liệu trong database
        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;

            tbHoDem.Enabled = false;
            tbMaNV.Enabled = true;
            tbTen.Enabled = true;
            dtngaySinh.Enabled = false;
            dtngayVaoLam.Enabled = false;
            tbSDT.Enabled = false;
            tbLuongTT.Enabled = false;
            tbDiaChi.Enabled = false;
            tbCCCD.Enabled = true;
            tbTonGiao.Enabled = false;
            tbTrinhDo.Enabled = false;
            tbDanToc.Enabled = false;
            tbPhongBan.Enabled = false;
            cbGioiTinh.Enabled = false;
            tbChucVu.Enabled = false;

            btnTim.Enabled = true;
        }



        //Nút thực hiện tìm kiếm
        private void btnTim_Click_1(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            //Tìm kiếm không phân biệt chữ hoa và chữ thường
            command.CommandText = "SELECT \"IDNV\",\"HODEM\",\"TEN\",\"GIOITINH\",\"NGAYSINH\",\"CMND\",\"SDT\",\"DIACHI\",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\"" +
                                  " FROM public.\"tb.NHANVIEN\"" +
                                  " WHERE \"IDNV\" ILIKE @MaNV" +
                                  " AND \"TEN\" ILIKE @Ten" +
                                  " AND \"CMND\" ILIKE @CCCD" +
                                  " AND \"TRANGTHAI\" = '1';";

            command.Parameters.AddWithValue("@MaNV", "%" + tbMaNV.Text + "%");
            command.Parameters.AddWithValue("@Ten", "%" + tbTen.Text + "%");
            command.Parameters.AddWithValue("@CCCD", "%" + tbCCCD.Text + "%");
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgv.DataSource = dataTable;

            }
        }



        // Chọn dữ liệu để show lên text box
        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sua == true)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbMaNV.Text = row.Cells[0].Value.ToString();
                tbHoDem.Text = row.Cells[1].Value.ToString();
                tbTen.Text = row.Cells[2].Value.ToString();
                tbCCCD.Text = row.Cells[4].Value.ToString();
                tbSDT.Text = row.Cells[5].Value.ToString();
                tbDiaChi.Text = row.Cells[6].Value.ToString();
                tbChucVu.Text = row.Cells[7].Value.ToString();
                tbPhongBan.Text = row.Cells[8].Value.ToString();
                tbLuongTT.Text = row.Cells[9].Value.ToString();
                tbTonGiao.Text = row.Cells[12].Value.ToString();
                tbDanToc.Text = row.Cells[11].Value.ToString();
                tbTrinhDo.Text = row.Cells[13].Value.ToString();
                dtngaySinh.Text = row.Cells[3].Value.ToString();
                dtngayVaoLam.Text = row.Cells[10].Value.ToString();
                //Lấy số cột mới thêm vào
                int newColumnIndex = dgv.Columns.Count - 1;
                cbGioiTinh.Text = row.Cells[newColumnIndex].Value.ToString();
            }
        }



        // ràng buộc HODEM    
        private void tbHoDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khong cho nhap so
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Khong cho nhap qua 35 ky tu
            if (e.KeyChar != (char)Keys.Back && tbHoDem.Text.Length == 35)
            {
                e.Handled = true;
            }
        }
        private bool HoDem_Condition(string hoDem)
        {
            //Không cho phép thiếu
            if (hoDem.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập Họ Đệm", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        // rang buoc ten
        private void tbTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khong cho nhap so
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Khong cho nhap qua 10 ky tu
            if (e.KeyChar != (char)Keys.Back && tbTen.Text.Length == 10)
            {
                e.Handled = true;
            }
        }
        private bool Ten_Condition(string Ten)
        {
            //Không cho phép thiếu
            if (Ten.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập Tên", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        //GioiTinh
        private bool cbGioiTinh_Condition(string GioiTinh)
        {
            if (cbGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // NgaySinh
        private bool NgaySinh_Condition(string inputDate)
        {
            // Kiểm tra trống
            if (string.IsNullOrEmpty(inputDate))
            {
                MessageBox.Show("Ngày sinh không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra định dạng ngày
            if (!DateTime.TryParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập đúng định dạng ngày (dd/MM/yyyy).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Kiểm tra nếu ngày nhập vào lớn hơn hoặc bằng thời gian hiện tại
            if (parsedDate > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //DanToc
        private void tbDanToc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khong cho nhap so
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Khong cho nhap qua 20 ky tu
            if (e.KeyChar != (char)Keys.Back && tbDanToc.Text.Length == 20)
            {
                e.Handled = true;
            }
        }
        private bool DanToc_Condition(string danToc)
        {
            //Không cho phép thiếu
            if (danToc.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập Dân tộc", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        //Ton Giao
        private void tbTonGiao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khong cho nhap so
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Khong cho nhap qua 20 ky tu
            if (e.KeyChar != (char)Keys.Back && tbTonGiao.Text.Length == 20)
            {
                e.Handled = true;
            }
        }
        private bool TonGiao_Condition(string tonGiao)
        {
            //Không cho phép thiếu
            if (tonGiao.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập Tôn Giáo", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        //Trinh Do
        private void tbTrinhDo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khong cho nhap so
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Khong cho nhap qua 10 ky tu
            if (e.KeyChar != (char)Keys.Back && tbTrinhDo.Text.Length == 20)
            {
                e.Handled = true;
            }
        }
        private bool TrinhDo_Condition(string trinhDo)
        {
            //Không cho phép thiếu
            if (trinhDo.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập Trình độ", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        //SDT
        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //chỉ cho nhập số 0 ở đầu tiên
            if (e.KeyChar != '0' && tbSDT.Text.Length == 0)
            {
                e.Handled = true;
            }
            //không cho nhập quá 10 số
            if (e.KeyChar != (char)Keys.Back && tbSDT.Text.Length == 10)
            {
                e.Handled = true;
            }
        }
        private bool SDT_Condition(string SDT)
        {
            //Không cho phép thiếu
            if (SDT.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập SĐT", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            //không cho phép sai định dạng là 10 số
            if (SDT.Length != 10)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn nhập thiếu SĐT", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        //DiaChi
        private void tbDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //không cho nhập quá 50 số
            if (e.KeyChar != (char)Keys.Back && tbDiaChi.Text.Length == 50)
            {
                e.Handled = true;
            }
        }
        private bool DiaChi_Condition(string diaChi)
        {
            //Không cho phép thiếu
            if (diaChi.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập DiaChi", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        //Lương thoả thuận
        private void tbLuongTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập từ 1-9
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Không cho nhập số 0 vô nghĩa
            if (!char.IsControl(e.KeyChar) && e.KeyChar == '0' && tbLuongTT.Text.Length == 0)
            {
                e.Handled = true;
            }

            //Không cho nhập quá 9 chữ số
            if (e.KeyChar != (char)Keys.Back && tbLuongTT.Text.Length == 9)
            {
                e.Handled = true;
            }
        }
        private bool LuongTT_Condition(string luong)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(tbLuongTT.Text.Trim()))
            {
                sb.AppendLine("Bạn chưa nhập Lương Thoả Thuận!");
                tbLuongTT.Focus();
            }
            else if (!decimal.TryParse(tbLuongTT.Text.Trim(), out decimal newLuong) || (newLuong < 100000 || newLuong > 1000000000))
            {
                sb.AppendLine("Số tiền bạn nhập không hợp lệ. Số tiền phải lớn hơn 10^5 và bé hơn 10^9");
                tbLuongTT.Focus();
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void tbLuongTT_TextChanged_1(object sender, EventArgs e)
        {
            // không cho khoảng trông
            TextBox textBox = (TextBox)sender;
            textBox.Text = textBox.Text.Replace(" ", "");
        }

        //Ngày Vào Làm
        private bool NgayVaoLam_Condition(string inputDate)
        {
            // Kiểm tra trống
            if (string.IsNullOrEmpty(inputDate))
            {
                MessageBox.Show("Ngày vào làm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra định dạng ngày
            if (!DateTime.TryParseExact(inputDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập đúng định dạng ngày (dd/MM/yyyy).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra nếu ngày nhập vào lớn hơn hoặc bằng thời gian hiện tại
            if (parsedDate > DateTime.Today)
            {
                MessageBox.Show("Ngày vào làm phải nhỏ hơn thời gian hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //CCCD
        private void tbCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //không cho nhập quá 12 số
            if (e.KeyChar != (char)Keys.Back && tbCCCD.Text.Length == 12)
            {
                e.Handled = true;
            }
        }
        private bool CCCD_Condition(string CMND)
        {
            //Không cho phép thiếu
            if (CMND.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập CCCD", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            //không cho phép sai định dạng là 12 số
            if (CMND.Length != 12)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn nhập thiếu CMND", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        // phòng ban
        private bool PhongBan_Condition(string phongBan)
        {
            //Không cho phép thiếu
            if (phongBan.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập Phòng Ban", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        //Chức vụ
        private bool ChucVu_Condition(string chucVu)
        {
            //Không cho phép thiếu
            if (chucVu.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa nhập Chức Vụ", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }  

        private void dgv_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[3].Name == "NGAYSINH" && e.RowIndex >= 0)
            {
                // Định dạng ngày tháng trong cell
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            if (dgv.Columns[10].Name == "NGAYGIANHAP" && e.RowIndex >= 0)
            {
                // Định dạng ngày tháng trong cell
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }


    }
} 