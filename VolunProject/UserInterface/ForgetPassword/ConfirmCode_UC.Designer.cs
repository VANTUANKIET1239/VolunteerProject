namespace VolunProject.UserInterface.ForgetPassword
{
    partial class ConfirmCode_UC
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.codeTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timeLB = new System.Windows.Forms.Label();
            this.resendButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã xác nhận";
            // 
            // codeTB
            // 
            this.codeTB.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTB.Location = new System.Drawing.Point(323, 242);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(438, 39);
            this.codeTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian hiệu lực";
            // 
            // timeLB
            // 
            this.timeLB.AutoSize = true;
            this.timeLB.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLB.Location = new System.Drawing.Point(317, 129);
            this.timeLB.Name = "timeLB";
            this.timeLB.Size = new System.Drawing.Size(74, 32);
            this.timeLB.TabIndex = 3;
            this.timeLB.Text = "0:00";
            this.timeLB.Click += new System.EventHandler(this.label3_Click);
            // 
            // resendButton
            // 
            this.resendButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resendButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resendButton.Location = new System.Drawing.Point(605, 322);
            this.resendButton.Name = "resendButton";
            this.resendButton.Size = new System.Drawing.Size(139, 43);
            this.resendButton.TabIndex = 4;
            this.resendButton.Text = "Gửi lại mã";
            this.resendButton.UseVisualStyleBackColor = false;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(321, 182);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(70, 22);
            this.message.TabIndex = 5;
            this.message.Text = "label3";
            this.message.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.message);
            this.panel1.Controls.Add(this.resendButton);
            this.panel1.Controls.Add(this.timeLB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.codeTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 508);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(194)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(342, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lấy lại mật khẩu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ConfirmCode_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ConfirmCode_UC";
            this.Size = new System.Drawing.Size(836, 709);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLB;
        private System.Windows.Forms.Button resendButton;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
