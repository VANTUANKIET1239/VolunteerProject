using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolunProject.UserInterface.Redeem
{
    public partial class Redeem_UC : UserControl
    {
        public Redeem_UC()
        {
            InitializeComponent();
            createRedeem();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void createRedeem()
        {
            List<string> strings = new List<string>() { "ưqdqd", "qưdwqdwq", "qưdwqdq", "qưdqwdwqd" , "ưqdqd", "qưdwqdwq", "qưdwqdq", "qưdqwdwqd" };
            listRedeemFlowlayoutpanel.AutoScroll = true;
            listRedeemFlowlayoutpanel.FlowDirection = FlowDirection.LeftToRight;
            foreach (var item in strings)
            {
                RedeemControl redeemControl = new RedeemControl(item);
                listRedeemFlowlayoutpanel.Controls.Add(redeemControl);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void listRedeemFlowlayoutpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    /*public class RedeemControl : UserControl
    {
        public RedeemControl(string ten)
        {
            PictureBox pictureBox5 = new PictureBox();
            pictureBox5.Location = new System.Drawing.Point(1353, 278);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(349, 300);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;

        }
    }*/
}
