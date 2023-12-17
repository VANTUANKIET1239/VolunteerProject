namespace VolunProject
{
    partial class OrganizationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SignOutBTN = new System.Windows.Forms.Button();
            this.CreateEventButoon = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.eventButton = new System.Windows.Forms.Button();
            this.ApproveVolunteerBTN = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.sidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.panel3);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(274, 879);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(101, 879);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(274, 879);
            this.sidebarContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VolunProject.Properties.Resources.icons8_menu_40;
            this.pictureBox1.Location = new System.Drawing.Point(29, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 69);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SignOutBTN);
            this.panel3.Controls.Add(this.CreateEventButoon);
            this.panel3.Controls.Add(this.infoButton);
            this.panel3.Controls.Add(this.historyButton);
            this.panel3.Controls.Add(this.eventButton);
            this.panel3.Controls.Add(this.ApproveVolunteerBTN);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 770);
            this.panel3.TabIndex = 2;
            // 
            // SignOutBTN
            // 
            this.SignOutBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignOutBTN.FlatAppearance.BorderSize = 0;
            this.SignOutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignOutBTN.Image = global::VolunProject.Properties.Resources.icons8_shutdown_50;
            this.SignOutBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOutBTN.Location = new System.Drawing.Point(0, 700);
            this.SignOutBTN.Name = "SignOutBTN";
            this.SignOutBTN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SignOutBTN.Size = new System.Drawing.Size(271, 70);
            this.SignOutBTN.TabIndex = 6;
            this.SignOutBTN.Text = "                  Đăng xuất";
            this.SignOutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOutBTN.UseVisualStyleBackColor = true;
            this.SignOutBTN.Click += new System.EventHandler(this.SignOutBTN_Click);
            // 
            // CreateEventButoon
            // 
            this.CreateEventButoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateEventButoon.FlatAppearance.BorderSize = 0;
            this.CreateEventButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEventButoon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEventButoon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateEventButoon.Image = global::VolunProject.Properties.Resources.icons8_create_100;
            this.CreateEventButoon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateEventButoon.Location = new System.Drawing.Point(0, 280);
            this.CreateEventButoon.Name = "CreateEventButoon";
            this.CreateEventButoon.Size = new System.Drawing.Size(271, 70);
            this.CreateEventButoon.TabIndex = 5;
            this.CreateEventButoon.Text = "                       Tạo sự kiện";
            this.CreateEventButoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateEventButoon.UseVisualStyleBackColor = true;
            this.CreateEventButoon.Click += new System.EventHandler(this.CreateEventButoon_Click);
            // 
            // infoButton
            // 
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoButton.Image = global::VolunProject.Properties.Resources.icons8_user_50;
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.Location = new System.Drawing.Point(0, 210);
            this.infoButton.Name = "infoButton";
            this.infoButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.infoButton.Size = new System.Drawing.Size(271, 70);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "                  Thông tin";
            this.infoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.UseVisualStyleBackColor = true;
            // 
            // historyButton
            // 
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.historyButton.Image = global::VolunProject.Properties.Resources.icons8_list_50;
            this.historyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.Location = new System.Drawing.Point(0, 140);
            this.historyButton.Name = "historyButton";
            this.historyButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.historyButton.Size = new System.Drawing.Size(271, 70);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "                  Lịch sử";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // eventButton
            // 
            this.eventButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventButton.FlatAppearance.BorderSize = 0;
            this.eventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eventButton.Image = global::VolunProject.Properties.Resources.icons8_event_50;
            this.eventButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.Location = new System.Drawing.Point(0, 70);
            this.eventButton.Name = "eventButton";
            this.eventButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.eventButton.Size = new System.Drawing.Size(271, 70);
            this.eventButton.TabIndex = 1;
            this.eventButton.Text = "                  Sự kiện";
            this.eventButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // ApproveVolunteerBTN
            // 
            this.ApproveVolunteerBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApproveVolunteerBTN.FlatAppearance.BorderSize = 0;
            this.ApproveVolunteerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveVolunteerBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveVolunteerBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ApproveVolunteerBTN.Image = global::VolunProject.Properties.Resources.icons8_form_50;
            this.ApproveVolunteerBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApproveVolunteerBTN.Location = new System.Drawing.Point(0, 0);
            this.ApproveVolunteerBTN.Margin = new System.Windows.Forms.Padding(0);
            this.ApproveVolunteerBTN.Name = "ApproveVolunteerBTN";
            this.ApproveVolunteerBTN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ApproveVolunteerBTN.Size = new System.Drawing.Size(271, 70);
            this.ApproveVolunteerBTN.TabIndex = 1;
            this.ApproveVolunteerBTN.Text = "                 Duyệt ứng viên ";
            this.ApproveVolunteerBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApproveVolunteerBTN.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(274, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1473, 879);
            this.MainPanel.TabIndex = 3;
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 879);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sidebarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrganizationForm";
            this.Text = "OrganizationForm";
            this.sidebarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CreateEventButoon;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Button ApproveVolunteerBTN;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button SignOutBTN;
        private System.Windows.Forms.Panel MainPanel;
    }
}