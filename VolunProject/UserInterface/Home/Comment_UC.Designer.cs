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
            this.cmtTextbox = new System.Windows.Forms.TextBox();
            this.cmtName = new System.Windows.Forms.Label();
            this.commentImg = new System.Windows.Forms.PictureBox();
            this.cmtID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmtID);
            this.panel1.Controls.Add(this.cmtTextbox);
            this.panel1.Controls.Add(this.cmtName);
            this.panel1.Controls.Add(this.commentImg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 70);
            this.panel1.TabIndex = 0;
            // 
            // cmtTextbox
            // 
            this.cmtTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmtTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmtTextbox.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtTextbox.Location = new System.Drawing.Point(55, 38);
            this.cmtTextbox.Multiline = true;
            this.cmtTextbox.Name = "cmtTextbox";
            this.cmtTextbox.ReadOnly = true;
            this.cmtTextbox.Size = new System.Drawing.Size(559, 23);
            this.cmtTextbox.TabIndex = 2;
            this.cmtTextbox.TextChanged += new System.EventHandler(this.cmtTextbox_TextChanged);
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
            // cmtID
            // 
            this.cmtID.AutoSize = true;
            this.cmtID.Location = new System.Drawing.Point(383, 14);
            this.cmtID.Name = "cmtID";
            this.cmtID.Size = new System.Drawing.Size(35, 13);
            this.cmtID.TabIndex = 3;
            this.cmtID.Text = "label1";
            this.cmtID.Visible = false;
            // 
            // Comment_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Comment_UC";
            this.Size = new System.Drawing.Size(638, 71);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox commentImg;
        private System.Windows.Forms.Label cmtName;
        private System.Windows.Forms.TextBox cmtTextbox;
        private System.Windows.Forms.Label cmtID;
    }
}
