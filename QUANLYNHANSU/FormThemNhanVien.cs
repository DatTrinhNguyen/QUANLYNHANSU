using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace QUANLYNHANSU
{
    public partial class FormThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        //Kết nối database
        SqlConnection connection;
        SqlCommand command;
        String str = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public FormThemNhanVien()
        {
            
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT IDNV,HOTEN,(CASE WHEN GIOITINH=1 THEN N'Nam' ELSE N'Nữ' END )AS GIOITINH," +
                "CONVERT(VARCHAR(30), NGAYSINH, 103)AS NGAYSINH,EMAIL,LUONGCOBAN  FROM [tb.NHANVIEN]";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            if (cbGioiTinh.Text == "Nam")
            {
                cbGioiTinh.Text = "1";
            }
            else
            {
                cbGioiTinh.Text = "0";
            }
            command.CommandText = "INSERT INTO[tb.NHANVIEN] VALUES(N'"+ tbHoTen.Text + "', '"+ cbGioiTinh.Text + "', '"
                                    + dtNgaySinh.Text+"','" + tbEmail.Text + "','"+ tbLuongCoBan.Text + "','1')";
            tbHoTen.Clear();
            tbEmail.Clear();
            tbLuongCoBan.Clear();
            cbGioiTinh.ResetText();
            dtNgaySinh.ResetText();

            command.ExecuteNonQuery();
            loadData();
            connection.Close();
        }
    }
}