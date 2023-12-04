using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data;

namespace VolunProject.LoginForm
{
    public partial class LoginForm : Form
    {
        private UserControl activeForm;
        private object panelDesktopPane;
        private object lblTitle;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Login.Login_UC(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void OpenChildForm(UserControl a, object btnSender)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = a;
            //ActivateButton(btnSender);
            this.panel1.Controls.Add(a);
            this.panel1.Tag = a;
            //lblTitle.Text = (btnSender as Button).Text;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.RegisterUser.Register_UC(),sender);
        }



        /*        private void ActivateButton(object btnSender)
                {
                    throw new NotImplementedException();
                }*/
    }
}
