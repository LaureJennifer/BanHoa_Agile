namespace QuanLiDuAn_Agile
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {

        }
        private bool KiemTraNhapLieu()
        {

            bool check = false;
            if (string.IsNullOrEmpty(txt_accUser.Text) || string.IsNullOrEmpty(txt_passUser.Text))
            {
                check = false;
                MessageBox.Show("Chua nhap du lieu!", "Thong bao!");
            }
            else check = true;

            return check;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                MainApp mainApp = new MainApp();
                mainApp.ShowDialog();
            }
        }


    }
}
