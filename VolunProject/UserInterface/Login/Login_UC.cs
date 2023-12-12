using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;

namespace VolunProject.UserInterface.Login
{
    public partial class Login_UC : UserControl
    {
        public static event EventHandler SignUpEvent;
        public static event EventHandler LoginEvent;
        public Login_UC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignUpEvent(this, new EventArgs());
        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (AccountBLL.LogIn(userLogin.Text, userPassword.Text))
            {
                LoginEvent(this, new EventArgs());
            }
            else
            {
                userLogin.Text = "";
                userPassword.Text = "";
                errorMessage.Text = "Sai tên đăng nhập hoặc mật khẩu !";
                errorMessage.Visible = true;
            }
        }


        
    }
}
