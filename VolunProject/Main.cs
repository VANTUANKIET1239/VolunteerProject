using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using VolunProject.Data.BLL;

namespace VolunProject
{
    public partial class Main : Form
    {
        bool sidebarExpand = false;
        private UserControl activeForm;
        public Main()
        {
            InitializeComponent();
        }

      

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        public void OpenChildForm(UserControl a, object btnSender)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = a;
            //ActivateButton(btnSender);
            this.MainPanel.Controls.Add(a);
            this.MainPanel.Tag = a;
            //lblTitle.Text = (btnSender as Button).Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.Event_UC(), sender);
        }

        private void rewardsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Redeem.Redeem_UC(), sender);
           // LoginForm.LoginForm.OpenChildForm(MainPanel, new UserInterface.Redeem.Redeem_UC(), sender);
        }
    }
}
