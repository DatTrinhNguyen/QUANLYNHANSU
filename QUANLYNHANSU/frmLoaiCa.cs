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
    public partial class frmLoaiCa : DevExpress.XtraEditors.XtraForm
    {
        // biến điều khiển (có thể bỏ nếu tìm đc cách hay hơn)
        bool them = false, sua = false;
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
        public frmLoaiCa()
        {
            InitializeComponent();
            showHide(true);
            //Khóa chức năng paste
            tbTenLC.ShortcutsEnabled = false;
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


            //Tắt bật các text box
            tbTenLC.Enabled = !kt;
            tbHeSo.Enabled = !kt;

            //Làm sạch các text box
            tbTenLC.Clear();
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
            command.CommandText = "SELECT \"IDLC\",\"TENLC\",\"HESO\" FROM public.\"tb.LOAICA\"WHERE \"TRANGTHAI\" = \'1\';";
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
            string tenca = tbTenLC.Text.ToString();
            string heso = tbHeSo.Text.ToString();

            /*if (!MaBHXH_Condition(idBHYT))
            {
                return;
            }

            if (!MaNV_Condition(maNV))
            {
                return;
            }*/


            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO public.\"tb.LOAICA\"(\"TENLC\",\"HESO\",\"TRANGTHAI\")" +
            "VALUES(\'" + tenca + "\', \'" + heso + "\', \'1\');";
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
                string tenca = tbTenLC.Text.ToString();
                string heso = tbHeSo.Text.ToString();

                //Biến tạm
                string _idLoaiCa = selectedRow.Cells[0].Value.ToString();
                string _tenCa = selectedRow.Cells[2].Value.ToString();
                string _heSo = selectedRow.Cells[1].Value.ToString();
                
                /*if (_idBHYT != idBHYT)
                {
                    if (!MaBHXH_Condition(idBHYT))
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
                */


                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.LOAICA\" " +
                                        "SET \"TENLC\" = \'" + tenca + "\',\"HESO\" = \'" + heso + "\', " +
                                        "WHERE \"IDLC\" = \'" + _idLoaiCa + "\';";

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();


            }
            else
            {
                MessageBox.Show("Vui lòng chọn ca để sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string idLC = selectedRow.Cells[0].Value.ToString();
                // Kết nối tới cơ sở dữ liệu
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                // Sử dụng truy vấn UPDATE để cập nhật thông tin của nhân viên
                command.CommandText = "UPDATE public.\"tb.LOAICA\" SET  \"TRANGTHAI\"=\'0\' WHERE \"IDLC\"=\'" + idLC + "\';";

                // Thực thi truy vấn
                command.ExecuteNonQuery();
                // Sau khi sửa thông tin xong, cập nhật lại DataGridView
                loadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ca xóa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        


        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            tbTenLC.Enabled = false;
            tbHeSo.Enabled = false;
            btnTim.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + Database.name + ";User ID=postgres;Password=" + Database.pass + ";");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT  \"IDLC\",\"TENLC\",\"HESO\" FROM public.\"tb.LOAICA\" WHERE \"BHXH\" LIKE '%" + tbTenLC.Text + "%' AND\"TRANGTHAI\"=\'1\';";
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
        }

        // Chọn dữ liệu để show lên text box
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sua == true)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbTenLC.Text = row.Cells[1].Value.ToString();
                tbHeSo.Text = row.Cells[2].Value.ToString();
            }

        }


        private void tbTenLC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TbHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}