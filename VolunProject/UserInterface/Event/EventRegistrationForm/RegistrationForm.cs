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

namespace VolunProject.UserInterface.Event.EventRegistrationForm
{
    public partial class RegistrationForm : Form
    {
        private EventDTO eventDTO1;
        public RegistrationForm(EventDTO eventDTO)
        {
            InitializeComponent();
            LoadForm(eventDTO);
        }
        private void LoadForm(EventDTO eventDTO)
        {
            eventDTO1 = eventDTO;
            EventNameLB.Text = eventDTO.EventName;
            OrganizationLB.Text = OrganizationBLL.getOrganizationByID(eventDTO.OrganizationID).OrganizationName;
            AddressLB.Text = $"{eventDTO.DetailAddress}, {eventDTO.wardName}, {eventDTO.districtName}, {eventDTO.cityName}";
            DatetimeLB.Text = $"{eventDTO.StartDate.ToString("dd/MM/yyyy")} - {eventDTO.EndDate.ToString("dd/MM/yyyy")} - {eventDTO.time}";
            /*if ()
            {

            }*/
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            if (EventBLL.Event_Register(eventDTO1.EventID, curVol.VolunteerID))
            {
                DialogResult result = MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            };
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
