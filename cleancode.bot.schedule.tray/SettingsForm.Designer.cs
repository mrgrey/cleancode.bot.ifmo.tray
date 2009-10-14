namespace cleancode.bot.schedule.tray
{
    partial class SettingsForm
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
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.onScreenPositionGroupBox = new System.Windows.Forms.GroupBox();
            this.positionTopLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.positionBottomLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.positionTopRightRadioButton = new System.Windows.Forms.RadioButton();
            this.positionBottomRightRadioButton = new System.Windows.Forms.RadioButton();
            this.positionMiddleCenterRadioButton = new System.Windows.Forms.RadioButton();
            this.onScreenPositionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(9, 9);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(45, 13);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Группа:";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(60, 6);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(12, 116);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // onScreenPositionGroupBox
            // 
            this.onScreenPositionGroupBox.Controls.Add(this.positionMiddleCenterRadioButton);
            this.onScreenPositionGroupBox.Controls.Add(this.positionBottomRightRadioButton);
            this.onScreenPositionGroupBox.Controls.Add(this.positionTopRightRadioButton);
            this.onScreenPositionGroupBox.Controls.Add(this.positionBottomLeftRadioButton);
            this.onScreenPositionGroupBox.Controls.Add(this.positionTopLeftRadioButton);
            this.onScreenPositionGroupBox.Location = new System.Drawing.Point(12, 32);
            this.onScreenPositionGroupBox.Name = "onScreenPositionGroupBox";
            this.onScreenPositionGroupBox.Size = new System.Drawing.Size(148, 80);
            this.onScreenPositionGroupBox.TabIndex = 3;
            this.onScreenPositionGroupBox.TabStop = false;
            this.onScreenPositionGroupBox.Text = "Позиция окна:";
            // 
            // positionTopLeftRadioButton
            // 
            this.positionTopLeftRadioButton.AutoSize = true;
            this.positionTopLeftRadioButton.Location = new System.Drawing.Point(6, 19);
            this.positionTopLeftRadioButton.Name = "positionTopLeftRadioButton";
            this.positionTopLeftRadioButton.Size = new System.Drawing.Size(14, 13);
            this.positionTopLeftRadioButton.TabIndex = 0;
            this.positionTopLeftRadioButton.TabStop = true;
            this.positionTopLeftRadioButton.Tag = "TopLeft";
            this.positionTopLeftRadioButton.UseMnemonic = false;
            this.positionTopLeftRadioButton.UseVisualStyleBackColor = true;
            // 
            // positionBottomLeftRadioButton
            // 
            this.positionBottomLeftRadioButton.AutoSize = true;
            this.positionBottomLeftRadioButton.Location = new System.Drawing.Point(6, 61);
            this.positionBottomLeftRadioButton.Name = "positionBottomLeftRadioButton";
            this.positionBottomLeftRadioButton.Size = new System.Drawing.Size(14, 13);
            this.positionBottomLeftRadioButton.TabIndex = 1;
            this.positionBottomLeftRadioButton.TabStop = true;
            this.positionBottomLeftRadioButton.Tag = "BottomLeft";
            this.positionBottomLeftRadioButton.UseMnemonic = false;
            this.positionBottomLeftRadioButton.UseVisualStyleBackColor = true;
            // 
            // positionTopRightRadioButton
            // 
            this.positionTopRightRadioButton.AutoSize = true;
            this.positionTopRightRadioButton.Location = new System.Drawing.Point(128, 19);
            this.positionTopRightRadioButton.Name = "positionTopRightRadioButton";
            this.positionTopRightRadioButton.Size = new System.Drawing.Size(14, 13);
            this.positionTopRightRadioButton.TabIndex = 2;
            this.positionTopRightRadioButton.TabStop = true;
            this.positionTopRightRadioButton.Tag = "TopRight";
            this.positionTopRightRadioButton.UseMnemonic = false;
            this.positionTopRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // positionBottomRightRadioButton
            // 
            this.positionBottomRightRadioButton.AutoSize = true;
            this.positionBottomRightRadioButton.Location = new System.Drawing.Point(128, 61);
            this.positionBottomRightRadioButton.Name = "positionBottomRightRadioButton";
            this.positionBottomRightRadioButton.Size = new System.Drawing.Size(14, 13);
            this.positionBottomRightRadioButton.TabIndex = 3;
            this.positionBottomRightRadioButton.TabStop = true;
            this.positionBottomRightRadioButton.Tag = "BottomRight";
            this.positionBottomRightRadioButton.UseMnemonic = false;
            this.positionBottomRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // positionMiddleCenterRadioButton
            // 
            this.positionMiddleCenterRadioButton.AutoSize = true;
            this.positionMiddleCenterRadioButton.Location = new System.Drawing.Point(69, 37);
            this.positionMiddleCenterRadioButton.Name = "positionMiddleCenterRadioButton";
            this.positionMiddleCenterRadioButton.Size = new System.Drawing.Size(14, 13);
            this.positionMiddleCenterRadioButton.TabIndex = 4;
            this.positionMiddleCenterRadioButton.TabStop = true;
            this.positionMiddleCenterRadioButton.Tag = "MiddleCenter";
            this.positionMiddleCenterRadioButton.UseMnemonic = false;
            this.positionMiddleCenterRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 151);
            this.Controls.Add(this.onScreenPositionGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.groupLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.onScreenPositionGroupBox.ResumeLayout(false);
            this.onScreenPositionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox onScreenPositionGroupBox;
        private System.Windows.Forms.RadioButton positionBottomRightRadioButton;
        private System.Windows.Forms.RadioButton positionTopRightRadioButton;
        private System.Windows.Forms.RadioButton positionBottomLeftRadioButton;
        private System.Windows.Forms.RadioButton positionTopLeftRadioButton;
        private System.Windows.Forms.RadioButton positionMiddleCenterRadioButton;
    }
}