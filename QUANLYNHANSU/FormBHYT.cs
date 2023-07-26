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
    public partial class FormBHYT : DevExpress.XtraEditors.XtraForm
    {
        //Kết nối database
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=QUANLYNHANSU;User ID=postgres;Password=20030930;");
        public FormBHYT()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=QUANLYNHANSU;User ID=postgres;Password=20030930;");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"BHYT\",\"SOTIEN\",\"IDNV\",\"NGAYDONG\",\"NGAYKETTHUC\",\"GHICHU\" FROM public.\"tb.NHANVIENBAOHIEMYTE\"";
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

        private void FormBHYT_Load(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=QUANLYNHANSU;User ID=postgres;Password=20030930;");
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=QUANLYNHANSU;User ID=postgres;Password=20030930;");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
 
            command.CommandText = "INSERT INTO public.\"tb.NHANVIENBAOHIEMYTE\"(\"BHYT\",\"SOTIEN\",\"IDNV\",\"NGAYDONG\",\"NGAYKETTHUC\",\"TRANGTHAI\")" +
            "VALUES(\'" + tbMaBHYT.Text + "\', \'100000\', \'NV2\' , \'09-30-2003\', \'09-30-2003\', \'1\');";
            command.ExecuteNonQuery();
            connection.Dispose();
            connection.Close();
            loadData();

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbMaBHYT.Text = row.Cells[0].Value.ToString();
                tbSoTien.Text = row.Cells[1].Value.ToString();
                tbMaNV.Text = row.Cells[2].Value.ToString();
                dtNgayDong.Text = row.Cells[3].Value.ToString();
                dtNgayKetThuc.Text = row.Cells[4].Value.ToString();
            }
            

        }

    }
}