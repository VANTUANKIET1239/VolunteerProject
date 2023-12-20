using System;
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
using VolunProject.Data.BLL;
using VolunProject.Data.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VolunProject.UserInterface.Home
{
    public partial class Post_UC : UserControl
    {
        int newWidth;
        int newHeight;
        public Post_UC(PostDTO postDTO)
        {
            InitializeComponent();
            uploadInfo(postDTO);
            loadComment();
        }

        private void uploadInfo(PostDTO postDTO)
        {
            var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
            var vol = VolunteerBLL.GetVolunteerByVolunteerID(postDTO.VolunteerID);
            var account = AccountBLL.GetAccountByID(vol.AccountID);
            captionTextbox.Text = postDTO.Caption;
            Image image;
            using (MemoryStream ms = new MemoryStream(account.ImageUS))
            {
                image = Image.FromStream(ms);
                volImg.Image = image;
            }
            using (MemoryStream ms = new MemoryStream(curUser.ImageUS))
            {
                image = Image.FromStream(ms);
                cmtImg.Image = image;
            }
            if (vol.Name == "") volName.Text = account.AccountName;
            else volName.Text = vol.Name;
            time.Text = postDTO.CreateDate.ToString();
            postID.Text = postDTO.PostID;
            if (postDTO.State == true)
            {
                using (MemoryStream ms = new MemoryStream(postDTO.Image))
                {
                    image = Image.FromStream(ms);
                    postImg.Image = image;
                    postImg.Visible = true;
                }
                ResizePictureBox();
            }
            else
            {
                postImg.Height = 0;
                postImg.Width = 0;
            }
            likeLabel.Text = postDTO.PostLike.ToString();
        }
        private void commentTextbox_TextChanged(object sender, EventArgs e)
        {
            int charCount = commentTextbox.Text.Length;
            if (charCount <= 71) commentTextbox.Height = 26;
            else
            {
                int line = charCount / 71;
                commentTextbox.Height = 22 * (line+1);
            }
        }
        private void ResizePictureBox()
        {
            if (postImg.Image != null)
            {
                //newWidth = postImg.Image.Width;
                newWidth = 696;
                newHeight = postImg.Image.Height;
                //if (newWidth > 706) newWidth = 706;
                if (newHeight > 600) newHeight = 600;
                postImg.Width = newWidth;
                postImg.Height = newHeight;
                imgPanel.Height += newHeight;
                likePanel.Location = new Point(3, 33 + newHeight);
                cmtPanel.Location = new Point(307, 32 + newHeight);
                cmtFlowLayout.Location = new Point(7, cmtFlowLayout.Location.Y + newHeight);
                this.Height += newHeight;
            }
        }
        private void captionTextbox_TextChanged(object sender, EventArgs e)
        {
            int charCount = captionTextbox.Text.Length;
            if (charCount <= 76) captionTextbox.Height = 24;
            else
            {
                int line = charCount / 76;
                captionTextbox.Height = 22 * (line + 1);
                this.Height += 22 * line;
                contentPanel.Height += 22 * line;
                imgPanel.Location = new Point(307, 3 + 22 * line);
                cmtFlowLayout.Location = new Point(7, 225 + 22 * line);
            }
        }

        private void likeLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadComment()
        {
            var list = CommentBLL.GetAllCommentByID(postID.Text);
            foreach(var item in list)
            {
                var volunteer = VolunteerBLL.GetVolunteerByVolunteerID(item.VolunteerID);
                var account = AccountBLL.GetAccountByID(volunteer.AccountID);
                string name;
                if (volunteer.Name != "") name = volunteer.Name;
                else name = account.AccountName;
                Comment_UC comment_UC = new Comment_UC(account.ImageUS,item,name);
                flowLayoutPanel1.Controls.Add(comment_UC);
            }
            cmtLabel.Text = list.Count().ToString();
        }
        private void commentTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && commentTextbox.Text.Length > 0)
            {
                var curUser = OtherFunction.SessionManager.GetSessionValue<AccountDTO>("curUser");
                var curVol = VolunteerBLL.GetVolunteer(curUser.AccountID);
                CommentDTO commentDTO = new CommentDTO();
                string enteredText = commentTextbox.Text;

                commentDTO.CommentContent = enteredText;
                commentDTO.PostID = postID.Text;
                commentDTO.VolunteerID = curVol.VolunteerID;
                commentDTO.State = true;
                if (CommentBLL.CreateComment(commentDTO))
                {
                    flowLayoutPanel1.Controls.Clear();
                    loadComment();
                }             
                commentTextbox.Clear();              
                e.SuppressKeyPress = true;
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            
            if (PostBLL.Event_LikePost(postID.Text) == true)
            {
                likeLabel.Text = PostBLL.countLike(postID.Text).ToString();
                likeButton.BackColor = Color.Pink;
            }
            else
            {
                likeLabel.Text = PostBLL.countLike(postID.Text).ToString();
                likeButton.BackColor = Color.White;
            }
        }
    }
}
