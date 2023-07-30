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
        bool them = false, sua = false;
        static string Database = "postgres", Password= "30062003";
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
        public FormBHYT()
        {
            InitializeComponent();
            showHide(true);
            //Khóa chức năng paste
            tbMaBHYT.ShortcutsEnabled = false;
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

        //Nút thêm dữ liệu vào database
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            them = true;
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
                    if(!NgayDong_Condition(ngayDong))
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
        }


        // Chọn dữ liệu để show lên text box
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sua == true)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbMaBHYT.Text = row.Cells[0].Value.ToString();
                tbSoTien.Text = row.Cells[1].Value.ToString();
                tbMaNV.Text = row.Cells[2].Value.ToString();
                dtNgayDong.Text = row.Cells[3].Value.ToString();
                dtNgayKetThuc.Text = row.Cells[4].Value.ToString();
            }

        }

        //Ràng buộc điều kiện 

        //IDBHYT 2 KÝ TỰ CHỮ CÁI ĐẦU , 13 KÝ TỰ SỐ ĐẰNG SAU , KHÔNG CHO PASTE ,KHÔNG CHO VIẾT DẤU CÁCH , KHÔNG CHO BỎ TRỐNG , KHÔNG VƯỢT QUÁ 15 KÝ TỰ
        //,KHÔNG CHO THIẾU,KHÔNG TRÙNG IDBHYT
        private void tbMaBHYT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //2 ký tự chữ đầu
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && tbMaBHYT.Text.Length < 2)
            {
                e.Handled = true;
            }
            //13 ký tự sau là số
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && tbMaBHYT.Text.Length >= 2)
            {
                e.Handled = true;
            }
            //không cho phép quá 15 ký tự
            if (e.KeyChar != (char)Keys.Back && tbMaBHYT.Text.Length == 15)
            {
                e.Handled = true;
            }
        }


        private bool MaBHYT_Condition(string idBHYT)
        {
            //Không cho phép thiếu
            if (idBHYT.Length != 15)
            {
                DialogResult dialogResult = MessageBox.Show("Mã BHYT không đúng định dạng", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }


            //Không cho phép trùng
            if (!MaBHYT_CheckIfDataExists(idBHYT))
            {
                DialogResult dialogResult = MessageBox.Show("Mã BHYT đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;

        }

        private bool MaBHYT_CheckIfDataExists(string idBHYT)
        {
            //Kiểm tra dữ liệu trùng
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT \"BHYT\" FROM public.\"tb.NHANVIENBAOHIEMYTE\" WHERE \"BHYT\" = \'" + idBHYT + "\';";
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
            //không cho phép quá 15 ký tự
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

            //Mã NV không tồn tại
            if (!MaNV_CheckIfDataNotExists(idNV))
            {
                DialogResult dialogResult = MessageBox.Show("Mã NV chưa tồn tại", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;

    }



        private bool MaNV_CheckIfDataExists(string idNV)
        {
            //Kiểm tra dữ liệu đã được đăng ký chưa
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT \"IDNV\" FROM public.\"tb.NHANVIENBAOHIEMYTE\" WHERE \"IDNV\" = \'" + idNV + "\';";
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

        private bool MaNV_CheckIfDataNotExists(string idNV)
        {
            //Kiểm tra dữ liệu đã tồn tại chưa
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database + ";User ID=postgres;Password=" + Password + ";");
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


        //NGÀY ĐÓNG <= NGÀY HIỆN TẠI
        //Ràng buộc ngày đóng tiền
        private bool NgayDong_Condition(string ngayDong)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(ngayDong))
            {
                sb.AppendLine("Bạn chưa nhập thời gian đóng!");
            }
            else if (!DateTime.TryParse(ngayDong, out DateTime inputTime))
            {
                sb.AppendLine("Thời gian bạn nhập không hợp lệ. Vui lòng nhập đúng định dạng thời gian.");
            }
            else if (inputTime >= DateTime.Now)
            {
                sb.AppendLine("Thời gian đóng phải nhỏ hơn thời gian hiện tại.");
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        //NGÀY KẾT THỨC > NGÀY NGÀY HIỆN TẠI
        //Ràng buộc ngày kết thúc

        private bool NgayKetThuc_Condition(string ngayKetThuc)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(ngayKetThuc))
            {
                sb.AppendLine("Bạn chưa nhập thời gian kết thúc!");
            }
            else if (!DateTime.TryParse(ngayKetThuc, out DateTime inputTime))
            {
                sb.AppendLine("Thời gian bạn nhập không hợp lệ. Vui lòng nhập đúng định dạng thời gian.");
            }
            else if (inputTime <= DateTime.Now)
            {
                sb.AppendLine("Thời gian kết thúc phải lớn hơn thời gian hiện tại.");
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //CHỈ CHO NHẬP SỐ , KHÔNG CHO PASTE ,KHÔNG CHO VIẾT DẤU CÁCH , KHÔNG CHO BỎ TRỐNG , KHÔNG CHO NHẬP SỐ 0 VÔ NGHĨA, 10^9>SỐ TIỀN>10^5

        //Ràng buộc Số tiền


        private void tbSoTien_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập từ 1-9
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < '1' || e.KeyChar > '9'))
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
            else if (!decimal.TryParse(tbSoTien.Text.Trim(), out decimal newSoTien) || (newSoTien < 100000 || newSoTien > 1000000000))
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