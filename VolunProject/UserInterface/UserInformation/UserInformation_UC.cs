using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VolunProject.Data.BLL;
using VolunProject.Data.DAL;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VolunProject.UserInterface.UserInformation
{
    public partial class UserInformation_UC : UserControl
    {
        private bool gender;

        public UserInformation_UC()
        {
            InitializeComponent();
            genderCB.Items.Add(new {genderValue = true,genderDisplay = "Nam"});
            genderCB.Items.Add(new {genderValue = false, genderDisplay = "Nữ" });
            genderCB.DisplayMember = "genderDisplay";
            genderCB.ValueMember = "genderValue";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void curPasswordTB_TextChanged(object sender, EventArgs e)
        {

        }


        private void cityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var city = (int)cityCB.SelectedValue;
            var districtlist = DistrictBLL.District_ByCityId(city);
            districtCB.DisplayMember = "tenQuanHuyen";
            districtCB.ValueMember = "ID";
            districtCB.DataSource = districtlist;
        }

        private void districtCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var district = (int)districtCB.SelectedValue;
            var wardtlist = WardBLL.Ward_ByDistrictId(district);
            wardCB.DisplayMember = "tenXaPhuong";
            wardCB.ValueMember = "ID";
            wardCB.DataSource = wardtlist;
        }

        private void UserInformation_UC_Load(object sender, EventArgs e)     
        {
            var curUser =  OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
            var citylist = CityBLL.City_List();
            cityCB.DisplayMember = "tenTinhThanhPho";
            cityCB.ValueMember = "ID";
            cityCB.DataSource = citylist;
            if (curVol.CityId != null)
            {
                cityCB.SelectedValue = curVol.CityId;
                districtCB.SelectedValue = curVol.DistrictId;
                wardCB.SelectedValue = curVol.WardId;
            }
            scoresLB.Text = curVol.PrestigeScore.ToString();
            userNameTB.Text = curVol.Name;
            accountNameLB.Text = curUser.AccountName;
            descriptionTB.Text = curVol.Description;
            addressTB.Text = curVol.AddressDetail;
            Image image;
            using (MemoryStream ms = new MemoryStream(curUser.ImageUS))
            {
                image = Image.FromStream(ms);
                userImg.Image = image;
            }
            bool? genderNullable = curVol.Gender;
            string gender = genderNullable.HasValue ? (genderNullable.Value ? "Nam" : "Nữ") : "";
            int index = genderCB.FindStringExact(gender);
            if (index != -1)
            {
                genderCB.SelectedIndex = index;
            }
            emailTB.Text = curVol.Email;
            phoneTB.Text = curVol.PhoneNumber;
        }
        private void wardCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;

                    userImg.Image = Image.FromFile(selectedFileName);
                    userImg.SizeMode = PictureBoxSizeMode.Zoom;

                    string filePath = selectedFileName;

                }
            }
        }

        private void accountNameLB_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                VolunteerDTO vol = new VolunteerDTO();
                //byte[] img = OtherFunction.ImageToByteArray(userImg.Image);
                byte[] img = OtherFunction.ImageToByteArray(userImg.Image);
                vol.Name = userNameTB.Text;
                vol.Email = emailTB.Text;
                vol.PhoneNumber = phoneTB.Text;
                vol.Gender = gender;
                vol.Description = descriptionTB.Text;
                vol.CityId = (int)cityCB.SelectedValue;
                vol.WardId = (int)wardCB.SelectedValue;
                vol.DistrictId = (int)districtCB.SelectedValue;
                vol.AddressDetail = addressTB.Text;
                vol.BirthDate = DateTime.Now;
                if(VolunteerBLL.UpdateVolunteer(vol, img))
                {
                    MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void genderCB_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void genderCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            gender = cb.SelectedIndex > 0 ? false : true;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đổi mật khẩu ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                if (curPasswordTB.Text == "")
                {
                    lb1.Text = "Vui lòng nhập mật khẩu hiện tại";
                    lb1.Visible = true;
                }
                else if (newPasswordTB.Text == "")
                {
                    lb1.Text = "Vui lòng nhập mật khẩu mới";
                    lb1.Visible = true;
                }
                else if (confirmPasswordTB.Text == "")
                {
                    lb1.Text = "Vui lòng xác nhận mật khẩu";
                    lb1.Visible = true;
                }
                else if (curPasswordTB.Text != curUser.Password)
                {
                    lb1.Text = "Mật khẩu không đúng";
                    lb1.Visible = true;
                }
                else if (newPasswordTB.Text != confirmPasswordTB.Text)
                {
                    lb1.Text = "Mật khẩu xác nhận không trùng khớp";
                    lb1.Visible = true;
                }
                else if (newPasswordTB.Text == curUser.Password)
                {
                    lb1.Text = "Mật khẩu mới trùng với mật khẩu cũ";
                    lb1.Visible = true;
                }
                else
                {
                    AccountBLL.changePassword(curUser.AccountName, newPasswordTB.Text);
                    lb1.Visible = false;
                    curPasswordTB.Text = "";
                    newPasswordTB.Text = "";
                    confirmPasswordTB.Text = "";
                    MessageBox.Show("Đổi mật khẩu thành công !","Thông báo",MessageBoxButtons.OK);
                }
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }
    }
}
