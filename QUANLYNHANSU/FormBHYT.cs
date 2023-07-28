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
    public partial class FormBHYT : DevExpress.XtraEditors.XtraForm
    {
        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them, tim, xoa, sua = false;
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User ID=postgres;Password=30062003;");
        public FormBHYT()
        {
            InitializeComponent();
            showHide(true);
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
            tbMaBHYT.Enabled = !kt;
            tbMaNV.Enabled = !kt;
            tbSoTien.Enabled = !kt;
            dtNgayDong.Enabled = !kt;
            dtNgayKetThuc.Enabled = !kt;

            //Làm sạch các text box
            tbMaBHYT.Clear();
            tbMaNV.Clear();
            tbSoTien.Clear();
            dtNgayKetThuc.Clear();
            dtNgayDong.Clear();
        }


        //Load dữ liệu từ database
        void loadData()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User ID=postgres;Password=30062003;");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"BHYT\",\"SOTIEN\",\"IDNV\",\"NGAYDONG\",\"NGAYKETTHUC\",\"GHICHU\" FROM public.\"tb.NHANVIENBAOHIEMYTE\"" + "WHERE \"TRANGTHAI\" = \'1\';";
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
            
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User ID=postgres;Password=30062003;");
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
        
        //Nút xóa dữ liệu (vô hiệu hóa) - Làm hộ tao phần này nhé
        private void Xoa()
        {
            if(dgv.SelectedRows.Count > 0)
               {
                   DataGridViewRow selectedRow = dgv.SelectedRows[0];
                   string idBHYT = selectedRow.Cells[0].Value.ToString();
                    // Kết nối tới cơ sở dữ liệu
                   NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User ID=postgres;Password=30062003;");
                   connection.Open();
                   NpgsqlCommand command = new NpgsqlCommand();
                   command.Connection = connection;
                   command.CommandType = CommandType.Text;

                   // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                   command.CommandText = "UPDATE public.\"tb.NHANVIENBAOHIEMYTE\" SET  \"TRANGTHAI\"=\'0\' WHERE \"BHYT\"=\'"+idBHYT+"\';";

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
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            xoa = true;
        }


            //Nút lưu dữ liệu vào database
            private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (them==true)
            {
                Them();
            }

            if (sua==true)
            {
                Sua();
            }
            them = false;
            sua = false;
            showHide(true);
        }

        
        
        //Nút hủy lưu dữ liệu
        private void btnKhongLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
        }

        


        // Chọn dữ liệu để show lên text box
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&&sua==true)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbMaBHYT.Text = row.Cells[0].Value.ToString();
                tbSoTien.Text = row.Cells[1].Value.ToString();
                tbMaNV.Text = row.Cells[2].Value.ToString();
                dtNgayDong.Text = row.Cells[3].Value.ToString();
                dtNgayKetThuc.Text = row.Cells[4].Value.ToString();
            }

        }


        //Thêm dữ liệu vào database
        private void Them()
        {
            string idBHYT = tbMaBHYT.Text.ToString();
            string soTien = tbSoTien.Text.ToString();
            string maNV = tbMaNV.Text.ToString();
            string ngayDong = dtNgayDong.Text.ToString();
            string ngayKetThuc = dtNgayKetThuc.Text.ToString();

            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User ID=postgres;Password=30062003;");
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
        //Tìm Kiếm Dữ Liệu Bằng MANV, MABHYT
        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User ID=postgres;Password=30062003;");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT \"BHYT\" FROM public.\"tb.NHANVIENBAOHIEMYTE\" WHERE \"BHYT\" LIKE '%" + tbMaBHYT.Text + "%' or  \"IDNV\" LIKE '%" + tbMaNV.Text+ "%'";
            command.ExecuteNonQuery();
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgv.DataSource = dataTable;

            }

        }   

        //Showhide tìm kiếm
    
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
            tim = true;
        }


        //Sửa dữ liệu trong database
        private void Sua()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string idBHYT = selectedRow.Cells[0].Value.ToString();
                string soTien = tbSoTien.Text.ToString();
                string maNV = tbMaNV.Text.ToString();
                string ngayDong = dtNgayDong.Text.ToString();
                string ngayKetThuc = dtNgayKetThuc.Text.ToString();
                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User ID=postgres;Password=30062003;");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.NHANVIENBAOHIEMYTE\" " +
                                        "SET \"SOTIEN\" = \'" + soTien + "\', " +
                                        "\"IDNV\" = \'" + maNV + "\', " +
                                        "\"NGAYDONG\" = \'" + ngayDong + "\', " +
                                        "\"NGAYKETTHUC\" = \'" + ngayKetThuc + "\' " +
                                        "WHERE \"BHYT\" = \'" + idBHYT + "\';";

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
    }
}