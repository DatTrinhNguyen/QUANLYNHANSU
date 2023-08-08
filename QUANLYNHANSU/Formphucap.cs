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
using System.Windows.Media;

namespace QUANLYNHANSU
{
    public partial class Formphucap : DevExpress.XtraEditors.XtraForm
    {
        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them = false, sua = false; int idPC;
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
        public Formphucap()
        {
            InitializeComponent();
            showHide(true);
            //Khóa chức năng paste
            tbSoTien.ShortcutsEnabled = false;
            tbTen.ShortcutsEnabled = false;
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
            btnKoLuu.Enabled = !kt;
            btnTimKiem.Enabled = kt;
            btnTim.Enabled = false;

            //Tắt bật các text box
            tbSoTien.Enabled = !kt;
            tbTen.Enabled = !kt;
            tbID.Enabled = false;
        }
        void clear()
        {
            //Làm sạch các text box
            tbTen.Clear();
            tbSoTien.Clear();
            tbID.Clear();
        }

        //Load dữ liệu từ database
        void loadData()
        {
            dgvPhuCap.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"IDPC\",\"TENPC\",\"SOTIEN\" FROM public.\"tb.PHUCAP\"WHERE \"TRANGTHAI\" = \'1\';";
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgvPhuCap.DataSource = dataTable;

            }
            connection.Dispose();
            connection.Close();

        }
        //Nút thêm dữ liệu vào database
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            them = true;
            TangidPC();
        }


        //Thêm dữ liệu vào database
        private void Them()
        {
            string ten = tbTen.Text.ToString();
            string sotien = tbSoTien.Text.ToString();
            string idpc = tbID.Text;

            if (!Ten_Condition(ten))
            {
                return;
            }

            if (!SoTien_Condition(sotien))
            {
                return;
            }


            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO public.\"tb.PHUCAP\"(\"IDPC\",\"TENPC\",\"SOTIEN\",\"TRANGTHAI\")" +
            "VALUES( \'" + idpc + "\',\'" + ten + "\', \'" + sotien + "\', \'1\');";
            command.ExecuteNonQuery();
            connection.Dispose();
            connection.Close();
            loadData();
            clear();
            TangidPC();
        }

        //Nút sửa dữ liệu vào database
        private void btnSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            sua = true;
            tbTen.Enabled = false;
        }

        //Sửa dữ liệu trong database
        private void Sua()
        {
            if (dgvPhuCap.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhuCap.SelectedRows[0];
                string ten = tbTen.Text.ToString();
                string sotien = tbSoTien.Text.ToString();
                string idpc = tbID.Text;

                //Biến tạm
                string _idPhuCap = selectedRow.Cells[0].Value.ToString();
                string _ten = selectedRow.Cells[1].Value.ToString();
                string _SoTien = selectedRow.Cells[2].Value.ToString();

                if (_ten != ten)
                {
                    if (!Ten_Condition(ten))
                    {
                        return;
                    }
                }

                if (_SoTien != sotien)
                {
                    if (!SoTien_Condition(sotien))
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
                command.CommandText = "UPDATE public.\"tb.PHUCAP\" " +
                                        "SET \"TENPC\" = \'" + ten + "\',\"SOTIEN\" = \'" + sotien + "\' " +
                                        "WHERE \"IDPC\" = \'" + _idPhuCap + "\';";

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();
                clear();
                sua = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phụ cấp để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Nút xóa dữ liệu (database) trong database
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
                if (dgvPhuCap.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPhuCap.SelectedRows[0];
                    string idPC = selectedRow.Cells[0].Value.ToString();
                    // Kết nối tới cơ sở dữ liệu
                    NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                    command.CommandText = "UPDATE public.\"tb.PHUCAP\" SET  \"TRANGTHAI\"=\'0\' WHERE \"IDPC\"=\'" + idPC + "\';";

                    // Thực thi truy vấn
                    command.ExecuteNonQuery();
                    // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                    loadData();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại phụ cấp xóa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        //Show hide tìm kiếm
        private void btnTimKiem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnKoLuu.Enabled = false;
            tbTen.Enabled = true;
            tbSoTien.Enabled = false;
            btnTim.Enabled = true;
        }

        //Tìm kiếm thông tin
        private void btnTim_Click_1(object sender, EventArgs e)
        {
            dgvPhuCap.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT  \"IDPC\",\"TENPC\",\"SOTIEN\"" +
                " FROM public.\"tb.PHUCAP\"" +
                " WHERE \"TENPC\" ILIKE @Ten" +
                " AND\"TRANGTHAI\"=\'1\';";
            command.Parameters.AddWithValue("@Ten", "%" + tbTen.Text + "%");
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgvPhuCap.DataSource = dataTable;

            }
        }

        //Nút lưu dữ liệu vào database
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
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
        }

        //Nút hủy lưu dữ liệu
        private void btnKoLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn xoá những thông tin thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                showHide(false);
                tbSoTien.Clear();
                tbTen.Clear();
            }
        }

        //Thoát các chức năng
        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                DataGridViewRow row = dgvPhuCap.Rows[e.RowIndex];
                tbTen.Text = row.Cells[1].Value.ToString();
                tbSoTien.Text = row.Cells[2].Value.ToString();
            }

        }

        //Ràng buộc tên phụ cấp
        private void tbTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && tbTen.Text.Length == 0)
            {
                e.Handled = true;
            }

            //ràng buộc độ dài
            if (e.KeyChar != (char)Keys.Back && tbTen.Text.Length == 30)
            {
                e.Handled = true;
            }
        }

        private bool Ten_Condition(string ten)
        {
            //Không cho phép dưới 5 ký tự
            if (ten.Length <= 5 && ten.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Tên phụ cấp quá ngắn", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            //Không cho phép thiếu
            if (ten.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Chưa nhập tên phụ cấp", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }

            //Không cho phép trùng
            if (!Ten_CheckIfDataExists(ten))
            {
                DialogResult dialogResult = MessageBox.Show("Tên phụ cấp đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;

        }

        private bool Ten_CheckIfDataExists(string ten)
        {
            //Kiểm tra dữ liệu trùng
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT \"TENPC\" FROM public.\"tb.PHUCAP\" WHERE \"TENPC\" = \'" + ten + "\';";
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
        private void tbSoTien_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar != (char)Keys.Back && tbSoTien.Text.Length == 9)
            {
                e.Handled = true;
            }
        }
        private bool SoTien_Condition(string sotien)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(tbSoTien.Text.Trim()))
            {
                sb.AppendLine("Bạn chưa nhập số tiền phụ cấp!");
                tbSoTien.Focus();
            }
            else if (!decimal.TryParse(tbSoTien.Text.Trim(), out decimal newsotien) || (newsotien < 10000 || newsotien > 1000000000))
            {
                sb.AppendLine("Số tiền bạn nhập không hợp lệ. Số tiền phải lớn hơn 10^4 và bé hơn 10^9");
                tbSoTien.Focus();
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // Hàm lấy mã cuối cùng trong cơ sở dữ liệu
        private void LayIDCuoiCung()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            // Truy vấn mã nhân viên lớn nhất trong cơ sở dữ liệu
            command.CommandText = "SELECT MAX(\"IDPC\") FROM public.\"tb.PHUCAP\"";
            object kq = command.ExecuteScalar();

            if (kq != null && kq != DBNull.Value)
            {
                idPC = Convert.ToInt32(kq);
            }
            else
            {
                // Nếu chưa có id phụ cấp trong cơ sở dữ liệu, bắt đầu từ 1
                idPC = 0;
            }

            connection.Dispose();
            connection.Close();
        }
        private void TangidPC()
        {
            LayIDCuoiCung(); // Gọi hàm để lấy id phụ cấp cuối cùng
            idPC++;
            tbID.Text = idPC.ToString("D3");
        }
    }
}
