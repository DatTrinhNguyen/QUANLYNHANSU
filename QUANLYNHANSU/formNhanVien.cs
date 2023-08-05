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
            tbChucVu.Enabled = !kt;
            cbGioiTinh.Enabled = !kt;
            tbPhongBan.Enabled = !kt;

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
            tbChucVu.Clear();
            cbGioiTinh.Text = " ";
            tbPhongBan.Clear();

            btnTim.Enabled = false;
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
                ",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\" FROM public.\"tb.NHANVIEN\"WHERE \"TRANGTHAI\" = \'1\';";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgv.DataSource = dataTable;

            }
            connection.Dispose();
            connection.Close();

        }



        //Hàm dùng cho text box tự gợi ý
        private void FormBHYT_Load(object sender, EventArgs e)
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
            tbPhongBan.AutoCompleteCustomSource = auto;
            tbPhongBan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPhongBan.AutoCompleteMode = AutoCompleteMode.Suggest;
            command.CommandText = "SELECT \"IDCV\" FROM public.\"tb.NHANVIEN\"";
            while (dataReader.Read())
            {
                auto.Add(dataReader.GetString(0));
            }
            tbChucVu.AutoCompleteCustomSource = auto;
            tbChucVu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbChucVu.AutoCompleteMode = AutoCompleteMode.Suggest;
            connection.Close();
        }

        //Nút thêm dữ liệu vào database
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            them = true;
            TangidNV();
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
            string ngaySinh = dtngaySinh.Text.ToString();
            string CMND = tbCCCD.Text.ToString();
            string SDT = tbSDT.Text.ToString();
            string diaChi = tbDiaChi.Text.ToString();
            string idPB = tbPhongBan.Text.ToString();
            string idCV = tbChucVu.Text.ToString();
            string luong = tbLuongTT.Text.ToString();
            string ngayGiaNhap = dtngayVaoLam.Text.ToString();
            string tonGiao = tbTonGiao.Text.ToString();
            string danToc = tbDanToc.Text.ToString();
            string trinhDo = tbDanToc.Text.ToString();

           
            if (!HoDem_Condition(hoDem))
            {
                return;
            }
            if (!Ten_Condition(Ten))
            {
                return;
            }
            if (!GioiTInh_Condition(gioiTinh))
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
            if (!NgayVaoLam_Condition(ngayGiaNhap))
            {
                return;
            }




            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO public.\"tb.NHANVIEN\"(\"IDNV\",\"HODEM\",\"TEN\",\"GIOITINH\",\"NGAYSINH\",\"CMND\",\"SDT\",\"DIACHI\"" +
                ",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\",\"TRANGTHAI\")" +
            "VALUES(\'" + maNV + "\', \'" + hoDem + "\', \'" + Ten + "\' , \'" + gioiTinh + "\', \'" + ngaySinh + "\', \'" + CMND + "\', \'" + SDT + "\'" +
            ", \'" + diaChi + "\', \'" + idPB + "\', \'" + idCV + "\', \'" + luong + "\', \'" + ngayGiaNhap + "\', \'" + tonGiao + "\', \'" + danToc + "\', \'" + trinhDo + "\', \'1\');";
            command.ExecuteNonQuery();
            connection.Dispose();
            connection.Close();
            loadData();
            TangidNV();

        }


        //Nút sửa dữ liệu vào database
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            tbHoDem.Enabled = false;
            tbMaNV.Enabled = false;
            tbTen.Enabled = false;
            dtngaySinh.Enabled =false;
            dtngayVaoLam.Enabled = false;
            tbCCCD.Enabled = false;
            tbTonGiao.Enabled = false;
            tbTrinhDo.Enabled = false;
            tbDanToc.Enabled =false;
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
                string ngaySinh = dtngaySinh.Text.ToString();
                string CMND = tbCCCD.Text.ToString();
                string SDT = tbSDT.Text.ToString();
                string diaChi = tbDiaChi.Text.ToString();
                string idPB = tbPhongBan.Text.ToString();
                string idCV = tbChucVu.Text.ToString();
                string luong = tbLuongTT.Text.ToString();
                string ngayGiaNhap = dtngayVaoLam.Text.ToString();
                string tonGiao = tbTonGiao.Text.ToString();
                string danToc = tbDanToc.Text.ToString();
                string trinhDo = tbDanToc.Text.ToString();

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

                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.NHANVIEN\" " +
                                        "SET \"SDT\" = \'" + SDT + "\' " +
                                        "\"DIACHI\" = \'" + diaChi + "\' " +
                                        "\"IDPB\" = \'" + idPB + "\' " +
                                        "\"IDCV\" = \'" + idCV + "\' " +
                                        "\"LUONG\" = \'" + luong + "\' " +                                     
                                        "WHERE \"IDNV\" = \'" + idNV + "\';";
                 
                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();
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
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //Nút thoát chức năng 
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
        }

        //Nút Lưu dữ liệu 
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (them == true)
            {
                Them();
            }

            if (sua == true)
            {
                Sua();
            }
        }


        //Nút Không lưu dữ liệu
        private void btnKhongLuu_Click_1(object sender, EventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
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
            tbCCCD.Enabled = false;
            tbTonGiao.Enabled = false;
            tbTrinhDo.Enabled = false;
            tbDanToc.Enabled = false;
            tbChucVu.Enabled = false;
            cbGioiTinh.Enabled = false;
            tbPhongBan.Enabled = false;

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

            command.CommandText = "SELECT  \"IDNV\",\"HODEM\",\"TEN\",\"GIOITINH\",\"NGAYSINH\",\"CMND\",\"SDT\",\"DIACHI\"" +
                ",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\" FROM public.\"tb.NHANVIEN\"" +
            "WHERE \"IDNV\" LIKE \'%" + tbMaNV.Text + "%\' AND  \"TEN\" LIKE \'%" + tbTen.Text + "%\'AND\"TRANGTHAI\"=\'1\';";
            command.ExecuteNonQuery();
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
                cbGioiTinh.Text = row.Cells[3].Value.ToString();
                dtngaySinh.Text = row.Cells[4].Value.ToString();
                tbCCCD.Text = row.Cells[5].Value.ToString();
                tbSDT.Text = row.Cells[6].Value.ToString();
                tbDiaChi.Text = row.Cells[7].Value.ToString();
                tbPhongBan.Text = row.Cells[8].Value.ToString();
                tbChucVu.Text = row.Cells[9].Value.ToString();
                tbLuongTT.Text = row.Cells[10].Value.ToString();
                dtngayVaoLam.Text = row.Cells[11].Value.ToString();
                tbTonGiao.Text = row.Cells[12].Value.ToString();
                tbDanToc.Text = row.Cells[13].Value.ToString();
                tbTrinhDo.Text = row.Cells[14].Value.ToString();
            }
        }
        //*IDNV
        private void tbMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //2 ký tự chữ đầu
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && tbMaNV.Text.Length < 2)
            {
                e.Handled = true;
            }
            //4 ký tự sau là số
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && tbMaNV.Text.Length >= 2)
            {
                e.Handled = true;
            }
            //không cho phép quá 6 ký tự
            if (e.KeyChar != (char)Keys.Back && tbMaNV.Text.Length == 6)
            {
                e.Handled = true;
            }        
        }
        


        private bool MaNV_Condition(string idNV)
        {
            //Không cho phép thiếu
            if (idNV.Length < 3)
            {
                DialogResult dialogResult = MessageBox.Show("Mã NV không đúng định dạng", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }

            //Không cho phép trùng
            if (!MaNV_CheckIfDataExists(idNV))
            {
                DialogResult dialogResult = MessageBox.Show("Mã NV đã được đăng ký ", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;

        }

        private bool MaNV_CheckIfDataExists(string idNV)
        {
            //Kiểm tra dữ liệu đã được đăng ký chưa
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT \"IDNV\" FROM public.\"tb.NHANVIEN\" WHERE \"IDNV\" = \'" + idNV + "\';";
            command.ExecuteNonQuery();
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Dispose();
                connection.Close();
                return false;
            }
            connection.Dispose();
            connection.Close();
            return true;

        }


        // ràng buộc HODEM    
        private void tbHoDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khong cho nhap so
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Khong cho nhap qua 40 ky tu
            if (e.KeyChar != (char)Keys.Back && tbHoDem.Text.Length == 40)
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

        //Gioi Tinh
       /* private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioitinh = cbGioiTinh.SelectedItem.ToString();
        }*/
        private bool GioiTInh_Condition(string GioiTinh)
        {
            //Không cho phép thiếu
            if (GioiTinh.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chưa chọn giới tính", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }

        private void cbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Khong cho nhap so
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Khong cho nhap qua 5 ky tu
            if (e.KeyChar != (char)Keys.Back && cbGioiTinh.Text.Length == 5)
            {
                e.Handled = true;
            }
        }

        // NgaySinh
        private bool NgaySinh_Condition(string NgaySinh)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(NgaySinh))
            {
                sb.AppendLine("Bạn chưa nhập ngày sinh!");
            }
            else if (!DateTime.TryParse(NgaySinh, out DateTime inputTime))
            {
                sb.AppendLine("Ngày sinh bạn nhập không hợp lệ. Vui lòng nhập đúng định dạng thời gian.");
            }
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Thiếu tham số tuổi làm việc. Không định dạng được
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
            return true;
        }

        //DiaChi
        private void tbDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //không cho nhập quá 150 số
            if (e.KeyChar != (char)Keys.Back && tbDiaChi.Text.Length == 150)
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
            if (!char.IsControl(e.KeyChar) && e.KeyChar == '0' &&tbLuongTT.Text.Length == 0)
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
        private bool NgayVaoLam_Condition(string ngayVaoLam)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(ngayVaoLam))
            {
                sb.AppendLine("Bạn chưa nhập thời gian vào làm!");
            }
            else if (!DateTime.TryParse(ngayVaoLam, out DateTime inputTime))
            {
                sb.AppendLine("Thời gian bạn nhập không hợp lệ. Vui lòng nhập đúng định dạng thời gian.");
            }
            else if (inputTime >= DateTime.Now)
            {
                sb.AppendLine("Thời gian vào làm phải nhỏ hơn thời gian hiện tại.");
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return true;
        }


        //Chưa làm phòng ban, Chức vụ


    }
}