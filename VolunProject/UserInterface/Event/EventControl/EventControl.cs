using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolunProject.UserInterface.Event.EventControl
{
    public partial class EventControl : UserControl
    {
        public EventControl(string cardText)
        {
            InitializeComponent();
            // Customize the appearance of the card control
            Size = new System.Drawing.Size(1100, 100);
            BackColor = System.Drawing.Color.LightGray;
            Margin = new Padding(15);
            // Add a label to display the card text
            Label label = new Label();
            label.Text = cardText;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;

            // Add the label to the card control
            Controls.Add(label);
        }

    }
}
