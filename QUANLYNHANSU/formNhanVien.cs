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
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them = false, sua = false;
        static string Database = "QUANLYNHANSU", Password = "20030930";
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
        public FormNhanVien()
        {
            InitializeComponent();
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
            cbGioiTinh.Text=" ";
            tbPhongBan.Clear();

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

            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
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
        }

        //Thêm dữ liệu vào database
        private void Them()
        {
            string idNV = tbMaNV.Text.ToString();
            string hoDem = tbHoDem.Text.ToString();
            string Ten = tbTen.Text.ToString();
            string gioiTinh = cbGioiTinh.Text.ToString();
            string ngaySinh = dtngaySinh.Text.ToString();
            string CMND = tbCCCD.Text.ToString();
            string SDT = tbSDT.Text.ToString();
            string diaChi = tbDiaChi.Text.ToString();
            string idPB = tbPhongBan.Text.ToString();
            string idCV = tbChucVu.Text.ToString();
            string luong =  tbLuongTT.Text.ToString();
            string ngayGiaNhap = dtngayVaoLam.Text.ToString();
            string tonGiao = tbTonGiao.Text.ToString();
            string danToc = tbDanToc.Text.ToString();
            string trinhDo = tbDanToc.Text.ToString();
            /*
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
            */



            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO public.\"tb.NHANVIENBAOHIEMYTE\"(\"IDNV\",\"HODEM\",\"TEN\",\"GIOITINH\",\"NGAYSINH\",\"CMND\",\"SDT\",\"DIACHI\"" +
                ",\"IDPB\",\"IDCV\",\"LUONG\",\"NGAYGIANHAP\",\"DANTOC\",\"TONGIAO\",\"TRINHDO\",\"TRANGTHAI\")" +
            "VALUES(\'" + idNV + "\', \'" + hoDem + "\', \'" + Ten + "\' , \'" + gioiTinh + "\', \'" + ngaySinh + "\', \'" + CMND + "\', \'" + SDT + "\'" +
            ", \'" + diaChi + "\', \'" + idPB + "\', \'" + idCV + "\', \'" + luong + "\', \'" + ngayGiaNhap + "\', \'" + tonGiao + "\', \'" + danToc + "\', \'" + trinhDo + "\', \'1\');";
            command.ExecuteNonQuery();
            connection.Dispose();
            connection.Close();
            loadData();

        }

       
        //Nút sửa dữ liệu vào database
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            sua = true;
        }
        //Sửa dữ liệu trong database
        private void Sua()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string idNV = tbMaNV.Text.ToString();
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
                string _idNV = selectedRow.Cells[0].Value.ToString();
                string _hoDem = selectedRow.Cells[1].Value.ToString();
                string _Ten = selectedRow.Cells[2].Value.ToString();
                string _gioiTinh = selectedRow.Cells[3].Value.ToString();
                string _ngaySinh = selectedRow.Cells[4].Value.ToString();
                string _CMND = selectedRow.Cells[5].Value.ToString();
                string _SDT = selectedRow.Cells[6].Value.ToString();
                string _diaChi = selectedRow.Cells[7].Value.ToString();
                string _idPB = selectedRow.Cells[8].Value.ToString();
                string _idCV = selectedRow.Cells[9].Value.ToString();
                string _luong = selectedRow.Cells[10].Value.ToString();
                string _ngayGiaNhap = selectedRow.Cells[11].Value.ToString();
                string _tonGiao = selectedRow.Cells[12].Value.ToString();
                string _danToc = selectedRow.Cells[13].Value.ToString();
                string _trinhDo = selectedRow.Cells[14].Value.ToString();
                /*
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
                */
     
                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.NHANVIEN\" " +
                                        "SET \"IDNV\" = \'" + idNV + "\',"+
                                        "\"HODEM\" = \'" + hoDem + "\', " +
                                        "\"TEN\" = \'" + Ten + "\', " +
                                        "\"GIOITINH\" = \'" + gioiTinh + "\', " +
                                        "\"NGAYSINH\" = \'" + ngaySinh + "\' " +
                                        "\"CMND\" = \'" + CMND + "\' " +
                                        "\"SDT\" = \'" + SDT + "\' " +
                                        "\"DIACHI\" = \'" + diaChi + "\' " +
                                        "\"IDPB\" = \'" + idPB + "\' " +
                                        "\"IDCV\" = \'" + idCV + "\' " +
                                        "\"LUONG\" = \'" + luong + "\' " +
                                        "\"NGAYGIANHAP\" = \'" + ngayGiaNhap + "\' " +
                                        "\"DANTOC\" = \'" + danToc + "\' " +
                                        "\"TONGIAO\" = \'" + tonGiao + "\' " +
                                        "\"TRINHDO\" = \'" + trinhDo + "\' " +
                                        "WHERE \"IDNV\" = \'" + _idNV + "\';";

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
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
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
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
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
        /*
        IDNV
        HODEM
        TEN
        GIOITINH
        NGAYSINH
        CMND
        SDT
        DIACHI
        IDPB
        IDCV
        LUONG
        NGAYGIANHAP
        DANTOC
        TONGIAO
        TRINHDO
        */
    }
}