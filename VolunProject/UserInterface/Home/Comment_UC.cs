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
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Home
{
    public partial class Comment_UC : UserControl
    {
        public Comment_UC(byte[] img, CommentDTO commentDTO, string name)
        {
            InitializeComponent();
            Image image;
            using (MemoryStream ms = new MemoryStream(img))
            {
                image = Image.FromStream(ms);
                commentImg.Image = image;
            }
            cmtTextbox.Text = commentDTO.CommentContent;
            cmtID.Text = commentDTO.CommentID;
            cmtName.Text = name;
        }

        private void cmtTextbox_TextChanged(object sender, EventArgs e)
        {
            int charCount = cmtTextbox.Text.Length;
            if (charCount <= 69)
            {
                cmtTextbox.Height = 26;
                panel1.Height = 70;
                this.Height = 70;
            }
            else
            {
                int line = charCount / 69;
                cmtTextbox.Height = 22 * (line + 1);
                panel1.Height = 70 + 22 * line;
                this.Height = 70 + 22 * line;

            }
        }
    }
}
