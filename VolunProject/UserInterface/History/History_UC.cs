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
using VolunProject.UserInterface.Event.EventHistoryControl;

namespace VolunProject.UserInterface.History
{
    public partial class History_UC : UserControl
    {
        private int isClick;
        public History_UC()
        {
            InitializeComponent();
            sub();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }
        private void sub()
        {
            EventHistoryControl.LoadHistoryEvent += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            var listRedeemedRewards = EventBLL.SendApproveEventRegistration_ByVolunteerID(curVol.VolunteerID);
            foreach (var item in listRedeemedRewards)
            {
                EventHistoryControl rewardHistoryControl = new EventHistoryControl(item);
                flowLayoutPanel1.Controls.Add(rewardHistoryControl);
            }
            label1.Text = "Lịch sử tham gia";

        }

        private void rewardButton_Click(object sender, EventArgs e)
        {
            
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
                var listRedeemedRewards = RewardBLL.getRewardsByVolunteerID(curVol.VolunteerID);
                foreach (var item in listRedeemedRewards)
                {
                    item.RedeemDate = RewardBLL.getVolunteerRewardByID(curVol.VolunteerID, item.RewardID).RedeemDate;
                    RewardHistoryControl rewardHistoryControl = new RewardHistoryControl(item);
                    flowLayoutPanel1.Controls.Add(rewardHistoryControl);
                }
                label1.Text = "Lịch sử quà tặng";
     
        }
    }
}
