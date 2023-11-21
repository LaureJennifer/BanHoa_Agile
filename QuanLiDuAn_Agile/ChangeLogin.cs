using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            loginAdmin.ShowDialog();
            this.Close();

        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            LoginUser loginUser = new LoginUser();  
            loginUser.ShowDialog();
            this.Close();


        }
    }
}
