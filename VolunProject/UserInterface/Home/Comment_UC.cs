using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolunProject.Data.DTO;

namespace VolunProject.UserInterface.Home
{
    public partial class Comment_UC : UserControl
    {
        public Comment_UC(byte[] img, CommentDTO commentDTO)
        {
            InitializeComponent();
        }

        private void cmtTextbox_TextChanged(object sender, EventArgs e)
        {
            int charCount = cmtTextbox.Text.Length;
            if (charCount <= 69) cmtTextbox.Height = 26;
            else
            {
                int line = charCount / 69;
                cmtTextbox.Height = 22 * (++line);
            }
        }
    }
}
