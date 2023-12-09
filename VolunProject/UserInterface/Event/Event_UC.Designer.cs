namespace VolunProject.UserInterface.Event
{
    partial class Event_UC
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
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.districtCB = new System.Windows.Forms.ComboBox();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Searchtxt
            // 
            this.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searchtxt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(67, 41);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(297, 30);
            this.Searchtxt.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(402, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 30);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 696);
            this.panel1.TabIndex = 3;
            // 
            // cityCB
            // 
            this.cityCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(67, 102);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(225, 27);
            this.cityCB.TabIndex = 4;
            this.cityCB.Text = "Chọn thành phố";
            // 
            // districtCB
            // 
            this.districtCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtCB.FormattingEnabled = true;
            this.districtCB.Location = new System.Drawing.Point(327, 102);
            this.districtCB.Name = "districtCB";
            this.districtCB.Size = new System.Drawing.Size(225, 27);
            this.districtCB.TabIndex = 5;
            this.districtCB.Text = "Chọn quận";
            // 
            // categoryCB
            // 
            this.categoryCB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(589, 102);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(225, 27);
            this.categoryCB.TabIndex = 7;
            this.categoryCB.Text = "Chọn loại";
            // 
            // Event_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.districtCB);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Event_UC";
            this.Size = new System.Drawing.Size(1186, 877);
            this.Load += new System.EventHandler(this.Event_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.ComboBox districtCB;
        private System.Windows.Forms.ComboBox categoryCB;
    }
}
