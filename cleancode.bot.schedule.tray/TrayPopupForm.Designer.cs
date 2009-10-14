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
            this.tomorrowLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mainSchedulePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hideTimer
            // 
            this.hideTimer.Interval = 5000;
            // 
            // closeLinkLabel
            // 
            this.closeLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLinkLabel.Location = new System.Drawing.Point(413, 38);
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
            this.groupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.groupLinkLabel_LinkClicked);
            // 
            // tomorrowLinkLabel
            // 
            this.tomorrowLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tomorrowLinkLabel.Location = new System.Drawing.Point(12, 38);
            this.tomorrowLinkLabel.Name = "tomorrowLinkLabel";
            this.tomorrowLinkLabel.Size = new System.Drawing.Size(59, 13);
            this.tomorrowLinkLabel.TabIndex = 3;
            this.tomorrowLinkLabel.TabStop = true;
            this.tomorrowLinkLabel.Text = "На завтра";
            this.tomorrowLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tomorrowLinkLabel_LinkClicked);
            // 
            // mainSchedulePanel
            // 
            this.mainSchedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSchedulePanel.Location = new System.Drawing.Point(15, 25);
            this.mainSchedulePanel.Name = "mainSchedulePanel";
            this.mainSchedulePanel.Size = new System.Drawing.Size(449, 0);
            this.mainSchedulePanel.TabIndex = 4;
            // 
            // TrayPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 60);
            this.ControlBox = false;
            this.Controls.Add(this.mainSchedulePanel);
            this.Controls.Add(this.tomorrowLinkLabel);
            this.Controls.Add(this.groupLinkLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.closeLinkLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrayPopupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TrayPopupForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer hideTimer;
        private System.Windows.Forms.LinkLabel closeLinkLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.LinkLabel groupLinkLabel;
        private System.Windows.Forms.LinkLabel tomorrowLinkLabel;
        private System.Windows.Forms.Panel mainSchedulePanel;
    }
}