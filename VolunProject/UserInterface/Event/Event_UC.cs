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
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;

            // Create and add cards to the flowLayoutPanel
            foreach (string cardText in cardData)
            {
                CardControl cardControl = new CardControl(cardText);
                flowLayoutPanel.Controls.Add(cardControl);
            }

            // Set up a scrollable panel to contain the flowLayoutPanel
       
            scrollablePanel.Dock = DockStyle.Fill;
            scrollablePanel.AutoScroll = true;
         //   scrollablePanel.MaximumSize = System.Drawing.Size(600, 1000);
            scrollablePanel.Controls.Add(flowLayoutPanel);

            // Add the scrollablePanel to the main form
            Controls.Add(scrollablePanel);
        }
    }
    public class CardControl : UserControl
    {
        public CardControl(string cardText)
        {
            // Customize the appearance of the card control
            Size = new System.Drawing.Size(1300, 100);
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
