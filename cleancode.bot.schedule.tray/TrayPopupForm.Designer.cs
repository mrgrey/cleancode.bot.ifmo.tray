namespace cleancode.bot.schedule.tray
{
    partial class TrayPopupForm
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
            this.hideTimer = new System.Windows.Forms.Timer(this.components);
            this.closeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // hideTimer
            // 
            this.hideTimer.Interval = 10000;
            // 
            // closeLinkLabel
            // 
            this.closeLinkLabel.AutoSize = true;
            this.closeLinkLabel.Location = new System.Drawing.Point(231, 253);
            this.closeLinkLabel.Name = "closeLinkLabel";
            this.closeLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.closeLinkLabel.TabIndex = 0;
            this.closeLinkLabel.TabStop = true;
            this.closeLinkLabel.Text = "Закрыть";
            this.closeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeLinkLabel_LinkClicked);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(12, 9);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(45, 13);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Группа:";
            // 
            // groupLinkLabel
            // 
            this.groupLinkLabel.AutoSize = true;
            this.groupLinkLabel.Location = new System.Drawing.Point(63, 9);
            this.groupLinkLabel.Name = "groupLinkLabel";
            this.groupLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.groupLinkLabel.TabIndex = 2;
            // 
            // TrayPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 275);
            this.ControlBox = false;
            this.Controls.Add(this.groupLinkLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.closeLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayPopupForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TrayPopupForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer hideTimer;
        private System.Windows.Forms.LinkLabel closeLinkLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.LinkLabel groupLinkLabel;
    }
}