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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VolunProject.UserInterface.RegisterUser
{
    public partial class AdminRegister_UC : UserControl
    {
        public static event EventHandler LoginEvent;
        public static event EventHandler BackEvent;
        public AdminRegister_UC()
        {
            InitializeComponent();
        }

        private void AdminRegister_UC_Load(object sender, EventArgs e)
        {
            organizeComboBox.DataSource = OrganizationBLL.getOrganization();
            organizeComboBox.DisplayMember = "OrganizationName";
            organizeComboBox.ValueMember = "OrganizationID";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BackEvent(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string pin = pinCodeTextBox.Text;
            string orgID = (string) organizeComboBox.SelectedValue;
            var organization = OrganizationBLL.getOrganizationByID(orgID);
            if (organization.COCK != pin)
            {
                errorMessage.Text = "Mã pin không đúng !";
                errorMessage.Visible = true;
            }
            else if (username == "")
            {
                errorMessage.Text = "Vui lòng nhập tên đăng nhập !";
                errorMessage.Visible = true;
            }
            else if (password == "")
            {
                errorMessage.Text = "Vui lòng nhập mật khẩu !";
                errorMessage.Visible = true;
            }
            else if (confirmPassword == "")
            {
                errorMessage.Text = "Vui lòng xác nhận mật khẩu !";
                errorMessage.Visible = true;
            }
            else if (confirmPassword != password)
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
                accountDTO.OrganizationID = (string)organizeComboBox.SelectedValue;
                accountDTO.AccountName = usernameTextBox.Text;
                accountDTO.Password = passwordTextBox.Text;
                if (OrganizationBLL.SignUp(accountDTO))
                {
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                    LoginEvent(this, new EventArgs());
                }
            }
        }
    }
}
