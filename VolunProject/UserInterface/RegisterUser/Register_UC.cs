using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.RegisterUser
{
    public partial class Register_UC : UserControl
    {
        public static event EventHandler registerEvent;
        public static event EventHandler backEvent;
        public Register_UC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            if(username == "")
            {
                errorMessage.Text = "Vui lòng nhập tên đăng nhập !";
                errorMessage.Visible = true;
            }
            else if(password == "")
            {
                errorMessage.Text = "Vui lòng nhập mật khẩu !";
                errorMessage.Visible = true;
            }
            else if(confirmPassword == "")
            {
                errorMessage.Text = "Vui lòng xác nhận mật khẩu !";
                errorMessage.Visible = true;
            }
            else if(confirmPassword != password)
            {
                errorMessage.Text = "Mật khẩu không trùng khớp !";
                errorMessage.Visible = true;
            }
            else if (AccountBLL.checkAccountName(username))
            {
                errorMessage.Text = "Tên đăng nhập đã tồn tại !";
                errorMessage.Visible = true;
            }
            else
            {
                AccountDTO accountDTO = new AccountDTO();
                accountDTO.AccountName  = usernameTextBox.Text;
                accountDTO.Password = passwordTextBox.Text;
                if (AccountBLL.SignUp(accountDTO))
                {
                    registerEvent(this, new EventArgs());
                    MessageBox.Show("Đăng kí tài khoản thành công !","Thông báo");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backEvent(this, new EventArgs());
        }
    }
}
