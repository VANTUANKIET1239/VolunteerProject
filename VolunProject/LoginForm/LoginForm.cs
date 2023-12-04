using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.UserInterface.Login;


namespace VolunProject.LoginForm
{
    public partial class LoginForm : Form
    {
        private static UserControl activeForm;
        private object panelDesktopPane;
        private object lblTitle;

        public LoginForm()
        {
            InitializeComponent();
            sub();
        }
        public void sub()
        {
            Login_UC.SignUpEvent += button2_Click_1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
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
        public static void OpenChildForm(Panel panel,UserControl a, object btnSender)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = a;
            //ActivateButton(btnSender);
            panel.Controls.Add(a);
            panel.Tag = a;
            //lblTitle.Text = (btnSender as Button).Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1,new UserInterface.RegisterUser.Register_UC(),sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        /*        private void ActivateButton(object btnSender)
                {
                    throw new NotImplementedException();
                }*/
    }
}
