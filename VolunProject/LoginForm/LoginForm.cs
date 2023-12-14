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
using VolunProject.UserInterface.RegisterUser;


namespace VolunProject.LoginForm
{
    public partial class LoginForm : Form
    {
        private static UserControl activeForm;
        private object panelDesktopPane;
        private object lblTitle;
        private Main main;

        public LoginForm()
        {
            InitializeComponent();
            main = new Main();
            sub();
        }
        public void sub()
        {
            Login_UC.SignUpEvent += button2_Click_1;
            Login_UC.LoginEvent += Login_UC_LoginEvent;
            Register_UC.registerEvent += Register_UC_registerEvent;
            Register_UC.backEvent += Register_UC_backEvent;
            Main.signOutEvent += Main_signOutEvent;

        }

        private void Register_UC_backEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void Main_signOutEvent(object sender, EventArgs e)
        {
            this.Show();
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
            main.Hide();
        }

        private void Register_UC_registerEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void Login_UC_LoginEvent(object sender, EventArgs e)
        {
            this.Hide();
            main.Closed += (s, args) => this.Close();
            main.Show();
            //main.OpenChildForm(new UserInterface.UserInformation.UserInformation_UC(),sender);
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
