namespace QuanLiDuAn_Agile
{

    public partial class ChangeLogin : Form
    {

        public ChangeLogin()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {

            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();


        }

        private void btn_User_Click(object sender, EventArgs e)
        {

            LoginUser loginUser = new LoginUser();
            loginUser.Show();



        }
    }
}
