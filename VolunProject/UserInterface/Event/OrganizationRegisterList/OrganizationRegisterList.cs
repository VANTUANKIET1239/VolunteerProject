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
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;

namespace VolunProject.UserInterface.Event.OrganizationRegisterList
{
    public partial class OrganizationRegisterList : UserControl
    {
        public OrganizationRegisterList()
        {
            InitializeComponent();
        }

        private void OrganizationRegisterList_Load(object sender, EventArgs e)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var eventlist = EventBLL.Event_ByOrganizationId(curUser.OrganizationID);   
            EventListCB.DisplayMember = "EventName";
            EventListCB.ValueMember = "EventID";
            EventListCB.DataSource = eventlist;
            StatusDefault();

            FlowLayoutPanel EventflowLayoutPanel = new FlowLayoutPanel();
            EventflowLayoutPanel.Dock = DockStyle.Fill;
            EventflowLayoutPanel.WrapContents = false;
            EventflowLayoutPanel.AutoScroll = true;
            EventflowLayoutPanel.MaximumSize = new System.Drawing.Size(1700, 722);
            EventflowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            // Create and add cards to the flowLayoutPanel
           /* foreach (EventDTO cardText in events)
            {
                EventControl.EventControl cardControl = new EventControl.EventControl(cardText);
                EventflowLayoutPanel.Controls.Add(cardControl);
            }
            panel1.Controls.Add(EventflowLayoutPanel);*/

        }
        public void StatusDefault()
        {
            StatusDTO status = new StatusDTO("A", "Đã duyệt");
            StatusDTO status2 = new StatusDTO("C", "Chờ duyệt");
            StatusDTO status3 = new StatusDTO("R", "Từ chối");
            StatusCB.ValueMember = "status";
            StatusCB.DisplayMember = "statusName";
            StatusCB.Items.AddRange(new List<StatusDTO>() { status, status2, status3 }.ToArray());
        }

        private void StatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EventListCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
