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
    public partial class RedeemControl : UserControl
    {
        public RedeemControl(string name)
        {              
            InitializeComponent();
            button1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
