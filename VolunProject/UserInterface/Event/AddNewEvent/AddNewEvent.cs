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

namespace VolunProject.UserInterface.Event.AddNewEvent
{
    public partial class AddNewEvent : UserControl
    {
        public AddNewEvent()
        {
            InitializeComponent();
        }

        private void AddNewEvent_Load(object sender, EventArgs e)
        {
            var citylist = CityBLL.City_List();
            CityCB.DisplayMember = "tenTinhThanhPho";
            CityCB.ValueMember = "ID";

            CityCB.DataSource = citylist;
           
        }

        private void CityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var city =(int) CityCB.SelectedValue;
            var districtlist = DistrictBLL.District_ByCityId(city);
            DistrictCB.DisplayMember = "tenQuanHuyen";
            DistrictCB.ValueMember = "ID";
            DistrictCB.DataSource = districtlist;
        }

        private void WardCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DistrictCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var district = (int)DistrictCB.SelectedValue;
            var wardtlist = WardBLL.Ward_ByDistrictId(district);
            WardCB.DisplayMember = "tenXaPhuong";
            WardCB.ValueMember = "ID";
            WardCB.DataSource = wardtlist;
        }

        private void UploadBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                
                    string selectedFileName = openFileDialog.FileName;

                    EventImageBox.Image = Image.FromFile(selectedFileName);
                    EventImageBox.SizeMode = PictureBoxSizeMode.Zoom;

                    string filePath = selectedFileName;
                   
                }
            }
        }
    }
}
