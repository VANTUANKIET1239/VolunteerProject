namespace VolunProject.UserInterface.Home
{
    partial class Comment_UC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmtName = new System.Windows.Forms.Label();
            this.commentImg = new System.Windows.Forms.PictureBox();
            this.cmtTextbox = new System.Windows.Forms.TextBox();
            this.cmtLike = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmtLike);
            this.panel1.Controls.Add(this.cmtTextbox);
            this.panel1.Controls.Add(this.cmtName);
            this.panel1.Controls.Add(this.commentImg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 134);
            this.panel1.TabIndex = 0;
            // 
            // cmtName
            // 
            this.cmtName.AutoSize = true;
            this.cmtName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtName.Location = new System.Drawing.Point(51, 13);
            this.cmtName.Name = "cmtName";
            this.cmtName.Size = new System.Drawing.Size(50, 22);
            this.cmtName.TabIndex = 1;
            this.cmtName.Text = "Name";
            // 
            // commentImg
            // 
            this.commentImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.commentImg.Location = new System.Drawing.Point(3, 13);
            this.commentImg.Name = "commentImg";
            this.commentImg.Size = new System.Drawing.Size(42, 38);
            this.commentImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.commentImg.TabIndex = 0;
            this.commentImg.TabStop = false;
            // 
            // cmtTextbox
            // 
            this.cmtTextbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtTextbox.Location = new System.Drawing.Point(55, 38);
            this.cmtTextbox.Multiline = true;
            this.cmtTextbox.Name = "cmtTextbox";
            this.cmtTextbox.Size = new System.Drawing.Size(580, 23);
            this.cmtTextbox.TabIndex = 2;
            this.cmtTextbox.TextChanged += new System.EventHandler(this.cmtTextbox_TextChanged);
            // 
            // cmtLike
            // 
            this.cmtLike.AutoSize = true;
            this.cmtLike.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtLike.ForeColor = System.Drawing.Color.Red;
            this.cmtLike.Location = new System.Drawing.Point(85, 67);
            this.cmtLike.Name = "cmtLike";
            this.cmtLike.Size = new System.Drawing.Size(27, 19);
            this.cmtLike.TabIndex = 3;
            this.cmtLike.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.icons8_love_401;
            this.pictureBox1.Location = new System.Drawing.Point(55, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Comment_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Comment_UC";
            this.Size = new System.Drawing.Size(638, 134);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox commentImg;
        private System.Windows.Forms.Label cmtName;
        private System.Windows.Forms.TextBox cmtTextbox;
        private System.Windows.Forms.Label cmtLike;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
