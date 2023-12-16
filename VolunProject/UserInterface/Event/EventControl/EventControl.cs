﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Event.EventControl
{
    public partial class EventControl : UserControl
    {
        public static event EventHandler DetailEvent;
        public EventDTO EventModel;
        public EventControl(EventDTO eventDTO)
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.LightGray;
            Margin = new Padding(15);
            LoadEvent(eventDTO);
        }
        private void LoadEvent(EventDTO eventDTO)
        {
            EventModel = eventDTO;
            Like.Text = eventDTO.LikeCount.ToString();
            eventTitle.Text = eventDTO.EventName.ToString();
            addressLB.Text = $"{eventDTO.DetailAddress}, {eventDTO.wardName}, {eventDTO.districtName}, {eventDTO.cityName}";
            DateTimeLB.Text = $"{eventDTO.StartDate.ToString("dd/MM/yyyy")} - {eventDTO.EndDate.ToString("dd/MM/yyyy")}";
            TimeLB.Text = eventDTO.time;
            Image image;
            using (MemoryStream ms = new MemoryStream(eventDTO.EventImage))
            {
                image = Image.FromStream(ms);
                EventImageBox.Image = image;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DetailEventBtn_Click(object sender, EventArgs e)
        {
            DetailEvent(this, new EventArgs());
        }
    }
}
