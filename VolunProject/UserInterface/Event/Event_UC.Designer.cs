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
            this.scrollablePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // scrollablePanel
            // 
            this.scrollablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scrollablePanel.Location = new System.Drawing.Point(0, 0);
            this.scrollablePanel.MaximumSize = new System.Drawing.Size(1471, 599);
            this.scrollablePanel.Name = "scrollablePanel";
            this.scrollablePanel.Size = new System.Drawing.Size(1471, 599);
            this.scrollablePanel.TabIndex = 0;
            // 
            // Event_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollablePanel);
            this.Name = "Event_UC";
            this.Size = new System.Drawing.Size(1471, 877);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scrollablePanel;
    }
}
