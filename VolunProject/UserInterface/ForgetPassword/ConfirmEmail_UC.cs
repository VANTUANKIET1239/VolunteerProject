using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolunProject.UserInterface.ForgetPassword
{
    public partial class ConfirmEmail_UC : UserControl
    {
        public static event EventHandler BackEvent;
        public static event EventHandler GetPasswordEvent;
        public ConfirmEmail_UC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackEvent(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPasswordEvent(this, new EventArgs());
        }
    }
}
