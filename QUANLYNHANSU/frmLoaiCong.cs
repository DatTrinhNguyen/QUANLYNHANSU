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
namespace QUANLYNHANSU
{
    public partial class frmLoaiCong : DevExpress.XtraEditors.XtraForm
    {

        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them = false, sua = false;
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
        public frmLoaiCong()
        {
            InitializeComponent();
            showHide(true);
            //Khóa chức năng paste
            tbTenLCONG.ShortcutsEnabled = false;
            tbHeSo.ShortcutsEnabled = false;
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
            btnTimKiem.Enabled = kt;
            btnThoat.Enabled = !kt;

            //Tắt bật các text box
            tbTenLCONG.Enabled = !kt;
            tbHeSo.Enabled = !kt;

            //Làm sạch các text box
            tbTenLCONG.Clear();
            tbHeSo.Clear();

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
            command.CommandText = "SELECT \"IDLCONG\",\"TENLCONG\",\"HESO\" FROM public.\"tb.LOAICONG\"WHERE \"TRANGTHAI\" = \'1\';";
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

        //Nút thêm dữ liệu vào database
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            them = true;
        }

        //Thêm dữ liệu vào database
        private void Them()
        {
            string tencong = tbTenLCONG.Text.ToString();
            string heso = tbHeSo.Text.ToString();

            if (!TenCong_Condition(tencong))
            {
                return;
            }

            if (!HeSo_Condition(heso))
            {
                return;
            }


            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO public.\"tb.LOAICONG\"(\"TENLCONG\",\"HESO\",\"TRANGTHAI\")" +
            "VALUES(\'" + tencong + "\', \'" + heso + "\', \'1\');";
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
                string tencong = tbTenLCONG.Text.ToString();
                string heso = tbHeSo.Text.ToString();

                //Biến tạm
                string _idLoaiCong = selectedRow.Cells[0].Value.ToString();
                string _tenCong = selectedRow.Cells[1].Value.ToString();
                string _heSo = selectedRow.Cells[2].Value.ToString();

                if (_tenCong != tencong)
                {
                    if (!TenCong_Condition(tencong))
                    {
                        return;
                    }
                }

                if (_heSo != heso)
                {
                    if (!HeSo_Condition(heso))
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
                command.CommandText = "UPDATE public.\"tb.LOAICONG\" " +
                                        "SET \"TENLCONG\" = \'" + tencong + "\',\"HESO\" = \'" + heso + "\' " +
                                        "WHERE \"IDLCONG\" = \'" + _idLoaiCong + "\';";

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();


            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại công để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Nút xóa dữ liệu (database) trong database
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                showHide(true);
                Xoa();
            }
        }

       

        //Xóa dữ liệu (vô hiệu hóa) 
        private void Xoa()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                string idLCONG = selectedRow.Cells[0].Value.ToString();
                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.LOAICONG\" SET  \"TRANGTHAI\"=\'0\' WHERE \"IDLCONG\"=\'" + idLCONG + "\';";

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại ca xóa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Show hide tìm kiếm
        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            tbTenLCONG.Enabled = true;
            tbHeSo.Enabled = false;
            btnTim.Enabled = true;
        }


        //Tìm kiếm thông tin
        private void btnTim_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT  \"IDLCONG\",\"TENLCONG\",\"HESO\" FROM public.\"tb.LOAICONG\" WHERE \"BHXH\" LIKE '%" + tbTenLCONG.Text + "%' AND\"TRANGTHAI\"=\'1\';";
            command.ExecuteNonQuery();
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dgv.DataSource = dataTable;

            }
        }

        //Nút lưu dữ liệu vào database
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Them();
                }
            }

            if (sua == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Sua();
                }

            }
            showHide(true);
            them = false;
            sua = false;
        }

        //Nút hủy lưu dữ liệu
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy lưu không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                showHide(true);
                them = false;
                sua = false;
            }
        }

        //Thoát các chức năng
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát chức năng không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                showHide(true);
                them = false;
                sua = false;
                loadData();
            }
        }

        // Chọn dữ liệu để show lên text box
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sua == true)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbTenLCONG.Text = row.Cells[1].Value.ToString();
                tbHeSo.Text = row.Cells[2].Value.ToString();
            }

        }


        //Ràng buộc tên ca
        private void tbTenLCONG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && tbTenLCONG.Text.Length == 0)
            {
                e.Handled = true;
            }


            if (e.KeyChar != (char)Keys.Back && tbTenLCONG.Text.Length == 30)
            {
                e.Handled = true;
            }
        }

        private bool TenCong_Condition(string tenca)
        {
            //Không cho phép thiếu
            if (tenca.Length <= 5)
            {
                DialogResult dialogResult = MessageBox.Show("Tên công quá ngắn", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }


            //Không cho phép trùng
            if (!TenCong_CheckIfDataExists(tenca))
            {
                DialogResult dialogResult = MessageBox.Show("Tên công đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;

        }

        private bool TenCong_CheckIfDataExists(string tencong)
        {
            //Kiểm tra dữ liệu trùng
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT \"TENLCONG\" FROM public.\"tb.LOAICONG\" WHERE \"TENLCONG\" = \'" + tencong + "\';";
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

        //Ràng buộc hệ số
        private void TbHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && tbHeSo.Text.Length == 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back && e.KeyChar == (char)'0' && tbHeSo.Text.Length == 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.' && tbHeSo.Text.Length == 1)
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && tbHeSo.Text.Length > 1)
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)Keys.Back && tbHeSo.Text.Length == 5)
            {
                e.Handled = true;
            }
        }


        private bool HeSo_Condition(string heso)
        {
            //Không cho phép thiếu
            if (heso.Length == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Hệ số không được bỏ trống", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }

            //Sai định dạng
            if (heso.EndsWith("."))
            {
                DialogResult dialogResult = MessageBox.Show("Hệ số không hợp lệ", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            if (!double.TryParse(heso.Trim(), out double newheso) || newheso < 1)
            {
                DialogResult dialogResult = MessageBox.Show("Hệ số không hợp lệ", "Lỗi", MessageBoxButtons.RetryCancel);
                return false;
            }
            return true;
        }
    }




}