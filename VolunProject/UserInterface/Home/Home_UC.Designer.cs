﻿namespace VolunProject.UserInterface.Home
{
    partial class Home_UC
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
            this.message2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.postPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.curVolImg = new System.Windows.Forms.PictureBox();
            this.rankImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curVolImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.message2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rankImg);
            this.panel1.Controls.Add(this.message);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 102);
            this.panel1.TabIndex = 1;
            // 
            // message2
            // 
            this.message2.AutoSize = true;
            this.message2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message2.Location = new System.Drawing.Point(1293, 75);
            this.message2.Name = "message2";
            this.message2.Size = new System.Drawing.Size(60, 22);
            this.message2.TabIndex = 3;
            this.message2.Text = "0/100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chung tay xây dựng cộng đồng";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(22, 16);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(689, 32);
            this.message.TabIndex = 0;
            this.message.Text = "Chào + name, bạn đã tích lũy được hạng + Rank";
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.postButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postButton.Location = new System.Drawing.Point(778, 10);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(156, 41);
            this.postButton.TabIndex = 5;
            this.postButton.Text = "Tạo bài viết";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // postPanel
            // 
            this.postPanel.AutoScroll = true;
            this.postPanel.Location = new System.Drawing.Point(346, 186);
            this.postPanel.Name = "postPanel";
            this.postPanel.Size = new System.Drawing.Size(1123, 684);
            this.postPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hãy chia sẻ trải nghiệm của bạn với cộng đồng";
            // 
            // curVolImg
            // 
            this.curVolImg.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.curVolImg.Location = new System.Drawing.Point(11, 10);
            this.curVolImg.Name = "curVolImg";
            this.curVolImg.Size = new System.Drawing.Size(57, 50);
            this.curVolImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.curVolImg.TabIndex = 3;
            this.curVolImg.TabStop = false;
            // 
            // rankImg
            // 
            this.rankImg.Image = global::VolunProject.Properties.Resources.logo_starbucks;
            this.rankImg.Location = new System.Drawing.Point(1359, 3);
            this.rankImg.Name = "rankImg";
            this.rankImg.Size = new System.Drawing.Size(102, 94);
            this.rankImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rankImg.TabIndex = 1;
            this.rankImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.postButton);
            this.panel2.Controls.Add(this.curVolImg);
            this.panel2.Location = new System.Drawing.Point(273, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 67);
            this.panel2.TabIndex = 7;
            // 
            // Home_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.postPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Home_UC";
            this.Size = new System.Drawing.Size(1473, 870);
            this.Load += new System.EventHandler(this.Home_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curVolImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox rankImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label message2;
        private System.Windows.Forms.PictureBox curVolImg;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Panel postPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
