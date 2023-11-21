using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace QuanLiDuAn_Agile
{
    public partial class MainApp : Form
    {
        string _prevId;
        public MainApp()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LEVANHUNG;Initial Catalog=QLBH;Integrated Security=True";
        private SqlConnection conn;

        SqlCommand cmd;
        SqlDataReader reader;

        private void MainApp_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            LoadData();

        }
        public void LoadData()
        {
            conn.Open();

            string Query = "select * from SANPHAM ";
            cmd = new SqlCommand(Query, conn);
            DataTable data = new DataTable();
            data.Load(cmd.ExecuteReader());
            dgv_SanPham.DataSource = data;
            dgv_SanPham.Columns[0].HeaderText = "Id";
            dgv_SanPham.Columns[0].Width = 45;
            dgv_SanPham.Columns[1].HeaderText = "Tên sản phẩm ";
            dgv_SanPham.Columns[1].Width = 310;
            dgv_SanPham.Columns[2].HeaderText = "Giá nhập";
            dgv_SanPham.Columns[2].Width = 233;
            dgv_SanPham.Columns[3].HeaderText = "Số lượng nhập";
            dgv_SanPham.Columns[3].Width = 233;
            conn.Close();


        }
        public bool checkExit(int id)
        {
            // Lấy đối tượng Datagrid view
            DataGridView dgv = this.dgv_SanPham;

            // Lặp qua tất cả các dòng trong Datagrid view
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                // Lấy giá trị Id của dòng thứ i
                int idRow = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);

                // Nếu giá trị Id của dòng thứ i bằng với Id truyền vào
                if (idRow == id)
                {
                    // Trả về true
                    return true;
                }
            }

            // Nếu không tìm thấy Id trong Datagrid view
            // Trả về false
            return false;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = this.txt_Id.Text;
            string tenSanPham = this.txt_Name.Text;
            decimal giaNhap = Convert.ToDecimal(this.txt_GiaNhap.Text);
            int soLuongNhap = Convert.ToInt32(this.txt_SoLuongNhap.Text);

            if (checkExit(int.Parse(id)))
            {
                return;
            }

            if (id == "" || tenSanPham == "" || giaNhap == 0 || soLuongNhap == 0)
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!");
                return;
            }

            conn.Open();

            var command = new SqlCommand("INSERT INTO sanpham (IDSanPham, TEN, GIANHAP, SLNHAP) VALUES (@id, @tenSanPham, @giaNhap, @soLuongNhap)", conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@tenSanPham", tenSanPham);
            command.Parameters.AddWithValue("@giaNhap", giaNhap);
            command.Parameters.AddWithValue("@soLuongNhap", soLuongNhap);
            command.ExecuteNonQuery();
            conn.Close();
            LoadData();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = this.txt_Id.Text;
            string tenSanPham = this.txt_Name.Text;
            decimal giaNhap = Convert.ToDecimal(this.txt_GiaNhap.Text);
            int soLuongNhap = Convert.ToInt32(this.txt_SoLuongNhap.Text);

            if (checkExit(int.Parse(id)))
            {
                return;
            }

            if (id == "" || tenSanPham == "" || giaNhap == 0 || soLuongNhap == 0)
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin!");
                return;
            }
            conn.Open();
            var query = $"UPDATE SANPHAM SET TEN = '{txt_Name.Text}', GIANHAP = '{txt_GiaNhap.Text}', SLNHAP = '{txt_SoLuongNhap.Text}' WHERE IDSanPham = '{txt_Id.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }
        
        private void btn_Del_Click(object sender, EventArgs e)
        {
            conn.Open();
            var deleteCommand = new SqlCommand($"DELETE FROM SANPHAM WHERE IDSanPham = '{txt_Id.Text}'", conn);
            deleteCommand.ExecuteNonQuery();
            txt_Id.Text = "";
            txt_Name.Text = "";
            txt_GiaNhap.Text = "";
            txt_SoLuongNhap.Text = "";
            conn.Close();
            LoadData();
          
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string id = this.txt_Id.Text;
            string tenSanPham = this.txt_Name.Text;
            decimal giaNhap = Convert.ToDecimal(this.txt_GiaNhap.Text);
            int soLuongNhap = Convert.ToInt32(this.txt_SoLuongNhap.Text);

            MessageBox.Show($"Id: {id} - Tên sản phẩm: {tenSanPham} - Giá nhập: {giaNhap} - Số lượng nhập: {soLuongNhap}","Thông tin chi tiết ");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Find.Text = "";
            txt_Id.Text = "";
            txt_Name.Text = "";
            txt_GiaNhap.Text = "";
            txt_SoLuongNhap.Text = "";
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            txt_Id.Text = dgv_SanPham.Rows[row].Cells[0].Value.ToString();
            txt_Name.Text = dgv_SanPham.Rows[row].Cells[1].Value.ToString();
            txt_GiaNhap.Text = dgv_SanPham.Rows[row].Cells[2].Value.ToString();
            txt_SoLuongNhap.Text = dgv_SanPham.Rows[row].Cells[3].Value.ToString();


        }
    }
}