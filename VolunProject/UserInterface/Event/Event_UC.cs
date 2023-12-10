using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolunProject.UserInterface.Event
{
    public partial class Event_UC : UserControl
    {
        public Event_UC()
        {
            InitializeComponent();
            PopulateCardList();
        }

        private void PopulateCardList()
        {
            // Assuming you have a list of data representing your cards
            // For demonstration purposes, I'm using a simple string array
            string[] cardData = { "Card 1", "Card 2", "Card 3", "Card 4", "Card 5", "Card 6", "Card 7", "Card 1", "Card 2", "Card 3", "Card 4", "Card 5", "Card 6", "Card 7" };

            // Set up a FlowLayoutPanel to host the cards
            FlowLayoutPanel EventflowLayoutPanel = new FlowLayoutPanel();
            EventflowLayoutPanel.Dock = DockStyle.Fill;
            EventflowLayoutPanel.WrapContents = false;
            EventflowLayoutPanel.AutoScroll = true;
            EventflowLayoutPanel.MaximumSize = new System.Drawing.Size(1186, 732);
            EventflowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            // Create and add cards to the flowLayoutPanel
            foreach (string cardText in cardData)
            {
                EventControl.EventControl cardControl = new EventControl.EventControl(cardText);
                EventflowLayoutPanel.Controls.Add(cardControl);
            }
            panel1.Controls.Add(EventflowLayoutPanel);
        }
        

        private void Event_UC_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void scrollablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   /* public class CardControl : UserControl
    {
        public CardControl(string cardText)
        {
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
    }*/
}
