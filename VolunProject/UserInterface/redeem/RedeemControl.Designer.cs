namespace VolunProject.UserInterface.Redeem
{
    partial class RedeemControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redeemButton = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.logo_starbucks;
            this.pictureBox1.Location = new System.Drawing.Point(114, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // redeemButton
            // 
            this.redeemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.redeemButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redeemButton.ForeColor = System.Drawing.Color.Yellow;
            this.redeemButton.Location = new System.Drawing.Point(114, 287);
            this.redeemButton.Name = "redeemButton";
            this.redeemButton.Size = new System.Drawing.Size(238, 44);
            this.redeemButton.TabIndex = 1;
            this.redeemButton.Text = "bt1";
            this.redeemButton.UseVisualStyleBackColor = false;
            this.redeemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(195, 237);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 24);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "lb1";
            // 
            // RedeemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.redeemButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RedeemControl";
            this.Size = new System.Drawing.Size(471, 475);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button redeemButton;
        private System.Windows.Forms.Label lb1;
    }
}
