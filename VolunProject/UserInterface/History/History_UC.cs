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

namespace VolunProject.UserInterface.History
{
    public partial class History_UC : UserControl
    {
        private int isClick;
        public History_UC()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rewardButton_Click(object sender, EventArgs e)
        {
            ++isClick;
            if (isClick == 1)
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
                label1.Text = "Lịch sử đổi thưởng";
            }
        }
    }
}
