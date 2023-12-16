namespace VolunProject.UserInterface.Event.OrganizationEvent
{
    partial class OrganizationEvent
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
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.districtCB = new System.Windows.Forms.ComboBox();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // categoryCB
            // 
            this.categoryCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(607, 76);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(225, 27);
            this.categoryCB.TabIndex = 13;
            this.categoryCB.Text = "Chọn loại";
            // 
            // districtCB
            // 
            this.districtCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtCB.FormattingEnabled = true;
            this.districtCB.Location = new System.Drawing.Point(329, 76);
            this.districtCB.Name = "districtCB";
            this.districtCB.Size = new System.Drawing.Size(225, 27);
            this.districtCB.TabIndex = 12;
            this.districtCB.Text = "Chọn quận";
            // 
            // cityCB
            // 
            this.cityCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(66, 76);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(225, 27);
            this.cityCB.TabIndex = 11;
            this.cityCB.Text = "Chọn thành phố";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1473, 722);
            this.panel1.TabIndex = 10;
            // 
            // Searchtxt
            // 
            this.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searchtxt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(67, 20);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(297, 30);
            this.Searchtxt.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(402, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // OrganizationEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.districtCB);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "OrganizationEvent";
            this.Size = new System.Drawing.Size(1473, 879);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.ComboBox districtCB;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
