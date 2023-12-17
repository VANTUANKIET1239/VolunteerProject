using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.DTO;
using VolunProject.UserInterface.Event;
using VolunProject.UserInterface.Event.EventControl;
using VolunProject.UserInterface.Login;

namespace VolunProject
{
    public partial class OrganizationForm : Form
    {
        bool sidebarExpand = false;
        private UserControl activeForm;
        public static event EventHandler signOutEventOr;
        public OrganizationForm()
        {
            InitializeComponent();
            sub();
        }

        private void sub()
        {
            EventControl.DetailEvent += EventControl_DetailEvent;
        }

        private void EventControl_DetailEvent(object sender, EventArgs e)
        {
            var eventControll = sender as EventControl;
            OpenChildForm(new UserInterface.EventDetail.EventDetail_UC(eventControll.EventModel), sender);
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
        private void CreateEventButoon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.AddNewEvent.AddNewEvent(), sender);
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInterface.Event.OrganizationEvent.OrganizationEvent(), sender);
        }

        private void SignOutBTN_Click(object sender, EventArgs e)
        {
            signOutEventOr(this, new EventArgs());
        }
    }
}
