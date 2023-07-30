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

namespace QUANLYNHANSU
{
    public partial class formNhanVien : DevExpress.XtraEditors.XtraForm
    {
        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them = false, sua = false;
        static string Database = "postgres", Password = "30062003";
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
        public formNhanVien()
        {
            InitializeComponent();
            showHide(true);
            //Khóa chức năng paste
            tbNhanVien.ShortcutsEnabled = false;
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
            tbMaNV.Enabled = !kt;
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
            tbEmail.Enabled = !kt;
            cbChucVu.Enabled = !kt;
            cbGioiTinh.Enabled = !kt;
            cbPhongBan.Enabled = !kt;

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
            tbEmail.Clear();
            cbChucVu.Cl
            cbGioiTinh.Enabled = !kt;
            cbPhongBan.Enabled = !kt;

            btnTim.Enabled = false;
        }


        //Load dữ liệu từ database
        void loadData()
        {
            dgv.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"BHYT\",\"SOTIEN\",\"IDNV\",\"NGAYDONG\",\"NGAYKETTHUC\",\"GHICHU\" FROM public.\"tb.NHANVIENBAOHIEMYTE\"WHERE \"TRANGTHAI\" = \'1\';";
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

            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
            connection.Open();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"IDNV\" FROM public.\"tb.NHANVIEN\"";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                auto.Add(dataReader.GetString(0));
            }
            tbMaNV.AutoCompleteCustomSource = auto;
            tbMaNV.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbMaNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            connection.Close();
        }

        //Thêm dữ liệu vào database
        private void Them()
        {
            string idBHYT = tbMaBHYT.Text.ToString();
            string soTien = tbSoTien.Text.ToString();
            string maNV = tbMaNV.Text.ToString();
            string ngayDong = dtNgayDong.Text.ToString();
            string ngayKetThuc = dtNgayKetThuc.Text.ToString();

            if (!MaBHYT_Condition(idBHYT))
            {
                return;
            }

            if (!MaNV_Condition(maNV))
            {
                return;
            }
            if (!NgayDong_Condition(ngayDong))
            {
                return;
            }
            if (!NgayKetThuc_Condition(ngayKetThuc))
            {
                return;
            }
            if (!SoTien_Condition(ngayKetThuc))
            {
                return;
            }




            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO public.\"tb.NHANVIENBAOHIEMYTE\"(\"BHYT\",\"SOTIEN\",\"IDNV\",\"NGAYDONG\",\"NGAYKETTHUC\",\"TRANGTHAI\")" +
            "VALUES(\'" + idBHYT + "\', \'" + soTien + "\', \'" + maNV + "\' , \'" + ngayDong + "\', \'" + ngayKetThuc + "\', \'1\');";
            command.ExecuteNonQuery();
            connection.Dispose();
            connection.Close();
            loadData();

        }

        //Nút thêm dữ liệu vào database

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            them = true;
        }

        //Nút sửa dữ liệu vào database
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            sua = true;
        }

        //Nút Xoá dữ liệu vào database

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            Xoa();
        }

        //Nút mở chức năng Tìm Kiếm dữ liệu trong database

        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            tbSoTien.Enabled = false;
            dtNgayDong.Enabled = false;
            dtNgayKetThuc.Enabled = false;
            btnTim.Enabled = true;
        }

        //Nút thoát chức năng 

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
        }

        //Nút Lưu dữ liệu 

        private void btnLuu_Click(object sender, EventArgs e)
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

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
        }

        //Nút thực hiện tìm kiếm

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT  \"BHYT\",\"SOTIEN\",\"IDNV\",\"NGAYDONG\",\"NGAYKETTHUC\",\"GHICHU\" FROM public.\"tb.NHANVIENBAOHIEMYTE\" WHERE \"BHYT\" LIKE '%" + tbMaBHYT.Text + "%' AND  \"IDNV\" LIKE '%" + tbMaNV.Text + "%'AND\"TRANGTHAI\"=\'1\';";
            command.ExecuteNonQuery();
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgv.DataSource = dataTable;

            }
        }


        //Sửa dữ liệu trong database
        private void Sua()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string idBHYT = tbMaBHYT.Text.ToString();
                string soTien = tbSoTien.Text.ToString();
                string maNV = tbMaNV.Text.ToString();
                string ngayDong = dtNgayDong.Text.ToString();
                string ngayKetThuc = dtNgayKetThuc.Text.ToString();

                //Biến tạm
                string _idBHYT = selectedRow.Cells[0].Value.ToString();
                string _maNV = selectedRow.Cells[2].Value.ToString();
                string _soTien = selectedRow.Cells[1].Value.ToString();
                string _ngayDong = selectedRow.Cells[3].Value.ToString();
                string _ngayKetThuc = selectedRow.Cells[4].Value.ToString();
                if (_idBHYT != idBHYT)
                {
                    if (!MaBHYT_Condition(idBHYT))
                    {
                        return;
                    }
                }

                if (_maNV != maNV)
                {
                    if (!MaNV_Condition(maNV))
                    {
                        return;
                    }
                }
                if (_ngayDong != ngayDong)
                {
                    if (!NgayDong_Condition(ngayDong))
                    {
                        return;
                    }
                }
                if (_ngayKetThuc != ngayKetThuc)
                {
                    if (!NgayKetThuc_Condition(ngayKetThuc))
                    {
                        return;
                    }
                }
                if (_soTien != soTien)
                {
                    if (!SoTien_Condition(ngayKetThuc))
                    {
                        return;
                    }
                }


                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.NHANVIENBAOHIEMYTE\" " +
                                        "SET \"BHYT\" = \'" + idBHYT + "\',\"SOTIEN\" = \'" + soTien + "\', " +
                                        "\"IDNV\" = \'" + maNV + "\', " +
                                        "\"NGAYDONG\" = \'" + ngayDong + "\', " +
                                        "\"NGAYKETTHUC\" = \'" + ngayKetThuc + "\' " +
                                        "WHERE \"BHYT\" = \'" + _idBHYT + "\';";

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
        //Xóa dữ liệu (vô hiệu hóa) 
        private void Xoa()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string idBHYT = selectedRow.Cells[0].Value.ToString();
                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.NHANVIENBAOHIEMYTE\" SET  \"TRANGTHAI\"=\'0\' WHERE \"BHYT\"=\'" + idBHYT + "\';";

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

        //Nút tìm Kiếm Dữ Liệu Bằng MANV, MABHYT
        
    }