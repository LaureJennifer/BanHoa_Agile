namespace QuanLiDuAn_Agile
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                MainApp mainApp = new MainApp();
                mainApp.ShowDialog();
            }

        }
        private bool KiemTraNhapLieu()
        {

            bool check = false;
            if (string.IsNullOrEmpty(txt_acc.Text) || string.IsNullOrEmpty(txt_pass.Text))
            {
                check = false;
                MessageBox.Show("Chua nhap du lieu!", "Thong bao!");
            }
            else
                if (!txt_acc.Text.Contains("@admin"))
            {
                check = false;
                MessageBox.Show("Chua nhap dung du lieu!", "Thong bao!");
            }
            else check = true;

            return check;
        }


    }
}
