﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.EntityADO.NET;
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
        private OrganizationForm OrganizationForm;

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
            Login_UC.AdminLoginEvent += Login_UC_AdminLoginEvent;
            AdminRegister_UC.BackEvent += AdminRegister_UC_BackEvent;
            AdminRegister_UC.LoginEvent += AdminRegister_UC_LoginEvent;
            Login_UC.LoginToOrganizationMainEvent += Login_UC_LoginToOrganizationMainEvent;
        }
        private void Login_UC_LoginToOrganizationMainEvent(object sender, EventArgs e)
        {

            this.Hide();
            OrganizationForm = new OrganizationForm();
            OrganizationForm.Closed += (s, args) => this.Close();
            OrganizationForm.Show();
        }
        private void AdminRegister_UC_LoginEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void AdminRegister_UC_BackEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
        }

        private void Login_UC_AdminLoginEvent(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.RegisterUser.AdminRegister_UC(), sender);
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(this.panel1, new UserInterface.Login.Login_UC(), sender);
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



    }
}
