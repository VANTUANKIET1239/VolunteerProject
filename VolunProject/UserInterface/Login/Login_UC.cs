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
        public static event EventHandler AdminLoginEvent;
        public static event EventHandler ForgetPasswordEvent;
        public static event EventHandler LoginToOrganizationMainEvent;
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
                var account = AccountBLL.Account_ByLoginName(userLogin.Text);
                if (account.RoleName == "ORGANIZATION")
                {
                    LoginToOrganizationMainEvent(this, new EventArgs());
                }
                else
                {
                    LoginEvent(this, new EventArgs());
                }
               
            }
            else
            {
                userLogin.Text = "";
                userPassword.Text = "";
                errorMessage.Text = "Sai tên đăng nhập hoặc mật khẩu !";
                errorMessage.Visible = true;
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignUpEvent(this, new EventArgs());
        }

        private void registerAdminButton_Click(object sender, EventArgs e)
        {
            AdminLoginEvent(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgetPasswordEvent(this, new EventArgs());
        }

        private void Login_UC_Load(object sender, EventArgs e)
        {

        }

        private void closeImg_Click(object sender, EventArgs e)
        {
            if(userPassword.PasswordChar ==  '*')
            {
                showImg.BringToFront();
                userPassword.PasswordChar = '\0';
            }
        }

        private void showImg_Click(object sender, EventArgs e)
        {
            if (userPassword.PasswordChar == '\0')
            {
                closeImg.BringToFront();
                userPassword.PasswordChar = '*';
            }
        }
    }
}
