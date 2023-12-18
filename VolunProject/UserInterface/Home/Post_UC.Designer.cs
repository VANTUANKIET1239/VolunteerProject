namespace VolunProject.UserInterface.Home
{
    partial class Post_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentPanel = new System.Windows.Forms.Panel();
            this.postID = new System.Windows.Forms.Label();
            this.captionTextbox = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.volName = new System.Windows.Forms.Label();
            this.cmtLabel = new System.Windows.Forms.Label();
            this.likeLabel = new System.Windows.Forms.Label();
            this.commentTextbox = new System.Windows.Forms.TextBox();
            this.cmtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.likePanel = new System.Windows.Forms.Panel();
            this.cmtPanel = new System.Windows.Forms.Panel();
            this.postImg = new System.Windows.Forms.PictureBox();
            this.likeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmtImg = new System.Windows.Forms.PictureBox();
            this.volImg = new System.Windows.Forms.PictureBox();
            this.contentPanel.SuspendLayout();
            this.cmtFlowLayout.SuspendLayout();
            this.imgPanel.SuspendLayout();
            this.likePanel.SuspendLayout();
            this.cmtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmtImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volImg)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentPanel.Controls.Add(this.postID);
            this.contentPanel.Controls.Add(this.captionTextbox);
            this.contentPanel.Controls.Add(this.time);
            this.contentPanel.Controls.Add(this.volImg);
            this.contentPanel.Controls.Add(this.volName);
            this.contentPanel.Location = new System.Drawing.Point(6, 9);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(705, 117);
            this.contentPanel.TabIndex = 0;
            // 
            // postID
            // 
            this.postID.AutoSize = true;
            this.postID.Location = new System.Drawing.Point(599, 28);
            this.postID.Name = "postID";
            this.postID.Size = new System.Drawing.Size(35, 13);
            this.postID.TabIndex = 12;
            this.postID.Text = "label1";
            this.postID.Visible = false;
            // 
            // captionTextbox
            // 
            this.captionTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.captionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.captionTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionTextbox.Location = new System.Drawing.Point(4, 84);
            this.captionTextbox.Multiline = true;
            this.captionTextbox.Name = "captionTextbox";
            this.captionTextbox.ReadOnly = true;
            this.captionTextbox.Size = new System.Drawing.Size(697, 24);
            this.captionTextbox.TabIndex = 11;
            this.captionTextbox.TextChanged += new System.EventHandler(this.captionTextbox_TextChanged);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(80, 45);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(45, 19);
            this.time.TabIndex = 2;
            this.time.Text = "Time";
            // 
            // volName
            // 
            this.volName.AutoSize = true;
            this.volName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volName.Location = new System.Drawing.Point(80, 23);
            this.volName.Name = "volName";
            this.volName.Size = new System.Drawing.Size(40, 22);
            this.volName.TabIndex = 0;
            this.volName.Text = "Tên";
            // 
            // cmtLabel
            // 
            this.cmtLabel.AutoSize = true;
            this.cmtLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtLabel.Location = new System.Drawing.Point(44, 10);
            this.cmtLabel.Name = "cmtLabel";
            this.cmtLabel.Size = new System.Drawing.Size(46, 24);
            this.cmtLabel.TabIndex = 9;
            this.cmtLabel.Text = "cmt";
            // 
            // likeLabel
            // 
            this.likeLabel.AutoSize = true;
            this.likeLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeLabel.ForeColor = System.Drawing.Color.Red;
            this.likeLabel.Location = new System.Drawing.Point(35, 8);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(70, 24);
            this.likeLabel.TabIndex = 6;
            this.likeLabel.Text = "Likes";
            this.likeLabel.Click += new System.EventHandler(this.likeLabel_Click);
            // 
            // commentTextbox
            // 
            this.commentTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextbox.Location = new System.Drawing.Point(43, 3);
            this.commentTextbox.Multiline = true;
            this.commentTextbox.Name = "commentTextbox";
            this.commentTextbox.Size = new System.Drawing.Size(657, 26);
            this.commentTextbox.TabIndex = 7;
            this.commentTextbox.TextChanged += new System.EventHandler(this.commentTextbox_TextChanged);
            // 
            // cmtFlowLayout
            // 
            this.cmtFlowLayout.AutoScroll = true;
            this.cmtFlowLayout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmtFlowLayout.Controls.Add(this.cmtImg);
            this.cmtFlowLayout.Controls.Add(this.commentTextbox);
            this.cmtFlowLayout.Location = new System.Drawing.Point(5, 238);
            this.cmtFlowLayout.Name = "cmtFlowLayout";
            this.cmtFlowLayout.Size = new System.Drawing.Size(704, 175);
            this.cmtFlowLayout.TabIndex = 1;
            // 
            // imgPanel
            // 
            this.imgPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgPanel.Controls.Add(this.postImg);
            this.imgPanel.Controls.Add(this.likePanel);
            this.imgPanel.Controls.Add(this.cmtPanel);
            this.imgPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPanel.Location = new System.Drawing.Point(6, 132);
            this.imgPanel.MinimumSize = new System.Drawing.Size(703, 100);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(703, 100);
            this.imgPanel.TabIndex = 11;
            // 
            // likePanel
            // 
            this.likePanel.Controls.Add(this.likeButton);
            this.likePanel.Controls.Add(this.likeLabel);
            this.likePanel.Location = new System.Drawing.Point(3, 33);
            this.likePanel.Name = "likePanel";
            this.likePanel.Size = new System.Drawing.Size(129, 50);
            this.likePanel.TabIndex = 9;
            // 
            // cmtPanel
            // 
            this.cmtPanel.Controls.Add(this.cmtLabel);
            this.cmtPanel.Controls.Add(this.pictureBox1);
            this.cmtPanel.Location = new System.Drawing.Point(307, 32);
            this.cmtPanel.Name = "cmtPanel";
            this.cmtPanel.Size = new System.Drawing.Size(116, 48);
            this.cmtPanel.TabIndex = 9;
            // 
            // postImg
            // 
            this.postImg.Image = global::VolunProject.Properties.Resources.download;
            this.postImg.Location = new System.Drawing.Point(3, 3);
            this.postImg.MaximumSize = new System.Drawing.Size(703, 600);
            this.postImg.Name = "postImg";
            this.postImg.Size = new System.Drawing.Size(31, 28);
            this.postImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postImg.TabIndex = 3;
            this.postImg.TabStop = false;
            this.postImg.Visible = false;
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeButton.Image = global::VolunProject.Properties.Resources.icons8_heart_24;
            this.likeButton.Location = new System.Drawing.Point(5, 8);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(28, 30);
            this.likeButton.TabIndex = 5;
            this.likeButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.icons8_comment_24;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cmtImg
            // 
            this.cmtImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.cmtImg.Location = new System.Drawing.Point(3, 3);
            this.cmtImg.Name = "cmtImg";
            this.cmtImg.Size = new System.Drawing.Size(34, 26);
            this.cmtImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmtImg.TabIndex = 8;
            this.cmtImg.TabStop = false;
            // 
            // volImg
            // 
            this.volImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.volImg.Location = new System.Drawing.Point(3, 14);
            this.volImg.Name = "volImg";
            this.volImg.Size = new System.Drawing.Size(71, 64);
            this.volImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volImg.TabIndex = 1;
            this.volImg.TabStop = false;
            // 
            // Post_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.cmtFlowLayout);
            this.Controls.Add(this.contentPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.Name = "Post_UC";
            this.Size = new System.Drawing.Size(720, 416);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.cmtFlowLayout.ResumeLayout(false);
            this.cmtFlowLayout.PerformLayout();
            this.imgPanel.ResumeLayout(false);
            this.likePanel.ResumeLayout(false);
            this.likePanel.PerformLayout();
            this.cmtPanel.ResumeLayout(false);
            this.cmtPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmtImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox volImg;
        private System.Windows.Forms.Label volName;
        private System.Windows.Forms.FlowLayoutPanel cmtFlowLayout;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox postImg;
        private System.Windows.Forms.Label likeLabel;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.TextBox commentTextbox;
        private System.Windows.Forms.Label cmtLabel;
        private System.Windows.Forms.PictureBox cmtImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox captionTextbox;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.Label postID;
        private System.Windows.Forms.Panel likePanel;
        private System.Windows.Forms.Panel cmtPanel;
    }
}
