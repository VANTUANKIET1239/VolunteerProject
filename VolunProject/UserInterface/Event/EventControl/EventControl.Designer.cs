namespace VolunProject.UserInterface.Event.EventControl
{
    partial class EventControl
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
            this.eventTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JoinEventBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DetailEventBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventTitle
            // 
            this.eventTitle.AutoSize = true;
            this.eventTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitle.Location = new System.Drawing.Point(29, 22);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(166, 24);
            this.eventTitle.TabIndex = 0;
            this.eventTitle.Text = "Sự kiện gì đó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "634/2323/23 Mã Lò, Bình trị đông A , quận bình tân, TP HCM";
            // 
            // JoinEventBtn
            // 
            this.JoinEventBtn.BackColor = System.Drawing.Color.Bisque;
            this.JoinEventBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinEventBtn.Location = new System.Drawing.Point(952, 46);
            this.JoinEventBtn.Name = "JoinEventBtn";
            this.JoinEventBtn.Size = new System.Drawing.Size(112, 32);
            this.JoinEventBtn.TabIndex = 3;
            this.JoinEventBtn.Text = "Tham gia";
            this.JoinEventBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DetailEventBtn
            // 
            this.DetailEventBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DetailEventBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailEventBtn.Location = new System.Drawing.Point(812, 46);
            this.DetailEventBtn.Name = "DetailEventBtn";
            this.DetailEventBtn.Size = new System.Drawing.Size(112, 32);
            this.DetailEventBtn.TabIndex = 5;
            this.DetailEventBtn.Text = "Chi tiết";
            this.DetailEventBtn.UseVisualStyleBackColor = false;
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DetailEventBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.JoinEventBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventTitle);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(1100, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button JoinEventBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DetailEventBtn;
    }
}
