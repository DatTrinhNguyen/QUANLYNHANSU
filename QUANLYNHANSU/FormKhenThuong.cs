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
    public partial class FormKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them = false, sua = false;
        //static string Database = "QUANLYNHANSU", Password= "20030930";
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
        public FormKhenThuong()
        {
            InitializeComponent();
            showHide(true);
            //Khóa chức năng paste
            tbMaKT.ShortcutsEnabled = false;
            tbMaNV.ShortcutsEnabled = false;
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
            tbMaKT.Enabled = false;
            tbMaNV.Enabled = !kt;
            tbSoTien.Enabled = !kt;
            dtNgayLap.Enabled = !kt;
            tbHoTen.Enabled = !kt;

            //Làm sạch các text box
            tbMaKT.Clear();
            tbMaNV.Clear();
            tbSoTien.Clear();
            tbHoTen.Clear();
            dtNgayLap.Clear();

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
            command.CommandText = "SELECT \"MAKT\",\"HOTEN\",\"IDNV\",\"NGAYLAP\",\"SOTIEN\" FROM public.\"tb.KHENTHUONG\"WHERE \"TRANGTHAI\" = \'1\';";
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

        //Hàm dùng cho text box tự gợi ý (ID nhân viên)
        private void FormKhenThuong_Load(object sender, EventArgs e)
        {

            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
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

        // Hàm lấy mã nhân viên cuối cùng trong cơ sở dữ liệu
        private int LayMaNhanVienCuoiCung()
        {
            int idKT = 0;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            // Truy vấn mã nhân viên lớn nhất trong cơ sở dữ liệu
            command.CommandText = "SELECT MAX(\"MAKT\") FROM public.\"tb.KHENTHUONG\"";
            object kq = command.ExecuteScalar();

            if (kq != null && kq != DBNull.Value)
            {
                string kq1 = kq.ToString();//chuyển đổi từ object sang string
                string kq2 = kq1.Substring(2);//loại bỏ 2 ký tự đầu.
                // Nếu đã có mã nhân viên trong cơ sở dữ liệu, tăng giá trị lên một đơn vị
                int maxMaNV = Convert.ToInt32(kq2);
                idKT = maxMaNV;
            }
            else
            {
                // Nếu chưa có mã nhân viên trong cơ sở dữ liệu, bắt đầu từ mã NV000000
                idKT = 0;
            }

            connection.Dispose();
            connection.Close();
            return idKT;
        }
        private void TangidNV()
        {
            // Gọi hàm để lấy mã nhân viên cuối cùng
            int idKT = LayMaNhanVienCuoiCung();
            idKT++;
            tbMaKT.Text = "KT" + idKT.ToString("D6");// Định dạng mã nhân viên với 6 chữ số (NV000001, NV000002, ...)
        }
        

        //Nút thêm dữ liệu vào database
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            them = true;
            TangidNV();
        }


        //Thêm dữ liệu vào database
        private void Them()
        {
            string idKT=tbMaKT.Text.ToString() ;
            string soTien = tbSoTien.Text.ToString();
            string maNV = tbMaNV.Text.ToString();
            string ngayLap = dtNgayLap.Text.ToString();
            string hoTen = tbHoTen.Text.ToString();
            

            if (!MaNV_Condition(maNV))
            {
                return;
            }
            if (!NgayLap_Condition(ngayLap))
            {
                return;
            }
            if (!HoTen_Condition(hoTen))
            {
                return;
            }
            if (!SoTien_Condition(soTien))
            {
                return;
            }


            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO public.\"tb.KHENTHUONG\"(\"MAKT\",\"SOTIEN\",\"IDNV\",\"NGAYLAP\",\"HOTEN\",\"TRANGTHAI\")" +
            "VALUES(\'" + idKT + "\', \'" + soTien + "\', \'" + maNV + "\' , \'" + ngayLap + "\', \'" + hoTen + "\', \'1\');";
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
                string idKT = tbMaKT.Text.ToString();
                string soTien = tbSoTien.Text.ToString();
                string maNV = tbMaNV.Text.ToString();
                string ngayLap = dtNgayLap.Text.ToString();
                string hoTen = tbHoTen.Text.ToString();

                //Biến tạm
                string _idKT = selectedRow.Cells[0].Value.ToString();
                string _HoTen = selectedRow.Cells[1].Value.ToString();
                string _maNV = selectedRow.Cells[2].Value.ToString(); 
                string _ngayLap = selectedRow.Cells[3].Value.ToString();
                string _soTien = selectedRow.Cells[4].Value.ToString();
                

                if (_maNV != maNV)
                {
                    if (!MaNV_Condition(maNV))
                    {
                        return;
                    }
                }
                if (_ngayLap != ngayLap)
                {
                    if(!NgayLap_Condition(ngayLap))
            {
                        return;
                    }
                }
                if (_HoTen != hoTen)
                {
                    if (!HoTen_Condition(hoTen))
                    {
                        return;
                    }
                }
                if (_soTien != soTien)
                {
                    if (!SoTien_Condition(soTien))
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
                command.CommandText = "UPDATE public.\"tb.KHENTHUONG\" " +
                                        "SET \"MAKT\" = \'" + idKT + "\',\"SOTIEN\" = \'" + soTien + "\', " +
                                        "\"IDNV\" = \'" + maNV + "\', " +
                                        "\"NGAYLAP\" = \'" + ngayLap + "\', " +
                                        "\"HOTEN\" = \'" + hoTen + "\' " +
                                        "WHERE \"MAKT\" = \'" + _idKT + "\';";

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một quyết định để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        //Nút xóa dữ liệu (database) trong database
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                string idKT = selectedRow.Cells[0].Value.ToString();
                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.KHENTHUONG\" SET  \"TRANGTHAI\"=\'0\' WHERE \"MAKT\"=\'" + idKT + "\';";

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một quyết định để xóa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Nút tìm Kiếm Dữ Liệu Bằng MANV, MABHYT
        private void btnTim_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT  \"MAKT\",\"HOTEN\",\"IDNV\",\"NGAYLAP\",\"SOTIEN\" FROM public.\"tb.KHENTHUONG\" WHERE \"MAKT\" LIKE '%" + tbMaKT.Text + "%' AND  \"IDNV\" LIKE '%" + tbMaNV.Text + "%'AND\"TRANGTHAI\"=\'1\';";
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
            tbMaKT.Enabled = true;
            tbSoTien.Enabled = false;
            dtNgayLap.Enabled = false;
            tbHoTen.Enabled = false;
            btnTim.Enabled = true;
        }


        //Nút lưu dữ liệu vào database
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
            showHide(true);
            them = false;
            sua = false;
        }

        //Nút hủy lưu dữ liệu
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
        }

        //Thoát các chức năng
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(true);
            them = false;
            sua = false;
            loadData();
        }


        // Chọn dữ liệu để show lên text box
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sua == true)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbMaKT.Text = row.Cells[0].Value.ToString();
                tbMaNV.Text = row.Cells[1].Value.ToString();
                tbHoTen.Text = row.Cells[2].Value.ToString();
                dtNgayLap.Text = row.Cells[3].Value.ToString();
                tbSoTien.Text = row.Cells[4].Value.ToString();
            }

        }

        //Ràng buộc điều kiện 

        //IDNV 2 KÝ TỰ ĐẦU CHỮ, 4 KÝ TỰ SAU SỐ , KHÔNG TRÙNG IDNV  , KHÔNG CHO PASTE ,KHÔNG CHO VIẾT DẤU CÁCH , KHÔNG CHO BỎ TRỐNG, KHÔNG VƯỢT QUÁ 6 KÝ TỰ
        //,KHÔNG CHO THIẾU

        private void tbMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //2 ký tự chữ đầu
            if (e.KeyChar != (char)Keys.Back &&  !char.IsLetter(e.KeyChar) && tbMaNV.Text.Length < 2)
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


            //Mã NV không tồn tại
            if (!MaNV_CheckIfDataNotExists(idNV))
            {
                DialogResult dialogResult = MessageBox.Show("Mã NV chưa tồn tại", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;

    }

        private bool MaNV_CheckIfDataNotExists(string idNV)
        {
            //Kiểm tra dữ liệu đã tồn tại chưa
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
                return true;
            }
            connection.Dispose();
            connection.Close();
            return false;

        }


        //NGÀY LẬP <= NGÀY HIỆN TẠI
        //Ràng buộc ngày lập
        private bool NgayLap_Condition(string ngaylap)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(ngaylap))
            {
                sb.AppendLine("Bạn chưa nhập thời gian đóng!");
            }
            else if (!DateTime.TryParse(ngaylap, out DateTime inputTime))
            {
                sb.AppendLine("Thời gian bạn nhập không hợp lệ. Vui lòng nhập đúng định dạng thời gian.");
            }
            else if (inputTime >= DateTime.Now)
            {
                sb.AppendLine("Thời gian lập phải nhỏ hơn thời gian hiện tại.");
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        //Ràng buộc họ tên

        private void tbHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Không cho cách phía đầu của họ tên
            if (e.KeyChar != (char)Keys.Back &&  !char.IsLetter(e.KeyChar) && tbHoTen.Text.Length ==0)
            {
                e.Handled = true;
            }

            //không cho phép quá 40 ký tự
            if (e.KeyChar != (char)Keys.Back && tbMaNV.Text.Length == 40)
            {
                e.Handled = true;
            }
        }
        private bool HoTen_Condition(string hoTen)
        {
            if (hoTen.Length<=5)
            {
                MessageBox.Show("Tên quá ngắn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        //CHỈ CHO NHẬP SỐ , KHÔNG CHO PASTE ,KHÔNG CHO VIẾT DẤU CÁCH , KHÔNG CHO BỎ TRỐNG , KHÔNG CHO NHẬP SỐ 0 VÔ NGHĨA, 10^9>SỐ TIỀN>10^5

        //Ràng buộc Số tiền


        private void tbSoTien_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập từ 1-9
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //Không cho nhập số 0 vô nghĩa
            if (!char.IsControl(e.KeyChar) && e.KeyChar == '0' && tbSoTien.Text.Length == 0)
            {
                e.Handled = true;
            }

            //Không cho nhập quá 9 chữ số
            if (e.KeyChar != (char)Keys.Back && tbSoTien.Text.Length == 12)
            {
                e.Handled = true;
            }
        }

        private void tbSoTien_KeyDown_1(object sender, KeyEventArgs e)
        {
            //Không cho dán số = ctrl + V
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

       

        //Ràng buộc giá trị số tiền
        private bool SoTien_Condition(string SoTien)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(tbSoTien.Text.Trim()))
            {
                sb.AppendLine("Bạn chưa nhập số tiền đóng!");
                tbSoTien.Focus();
            }
            else if (!decimal.TryParse(tbSoTien.Text.Trim(), out decimal newSoTien) || (newSoTien < 100000 || newSoTien > 10000000))
            {
                sb.AppendLine("Số tiền bạn nhập không hợp lệ. Số tiền phải lớn hơn 10^5 và bé hơn 10^9");
                tbSoTien.Focus();
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void tbSoTien_TextChanged_1(object sender, EventArgs e)
        {
            // không cho khoảng trông
            TextBox textBox = (TextBox)sender;
            textBox.Text = textBox.Text.Replace(" ", "");
        }
    }
}