namespace GuessMelody
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.melodyList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.player2Name = new yt_DesignUI.EgoldsGoogleTextBox();
            this.player1Name = new yt_DesignUI.EgoldsGoogleTextBox();
            this.randomStart = new yt_DesignUI.EgoldsToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameDurationCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.musicDurationCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectButton = new yt_DesignUI.yt_Button();
            this.subfolders = new yt_DesignUI.EgoldsToggleSwitch();
            this.clearButton = new yt_DesignUI.yt_Button();
            this.okButton = new yt_DesignUI.yt_Button();
            this.cancelButton = new yt_DesignUI.yt_Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // melodyList
            // 
            this.melodyList.FormattingEnabled = true;
            this.melodyList.ItemHeight = 19;
            this.melodyList.Location = new System.Drawing.Point(13, 18);
            this.melodyList.Margin = new System.Windows.Forms.Padding(4);
            this.melodyList.Name = "melodyList";
            this.melodyList.Size = new System.Drawing.Size(636, 289);
            this.melodyList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.player2Name);
            this.groupBox1.Controls.Add(this.player1Name);
            this.groupBox1.Controls.Add(this.randomStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gameDurationCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.musicDurationCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game preferences";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Second player";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "First player";
            // 
            // player2Name
            // 
            this.player2Name.BackColor = System.Drawing.Color.White;
            this.player2Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.player2Name.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.player2Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.player2Name.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.player2Name.FontTextPreview = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.player2Name.ForeColor = System.Drawing.Color.Black;
            this.player2Name.Location = new System.Drawing.Point(450, 71);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(150, 40);
            this.player2Name.TabIndex = 9;
            this.player2Name.TextInput = "";
            this.player2Name.TextPreview = "Player #2";
            this.player2Name.UseSystemPasswordChar = false;
            // 
            // player1Name
            // 
            this.player1Name.BackColor = System.Drawing.Color.White;
            this.player1Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.player1Name.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.player1Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.player1Name.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1Name.FontTextPreview = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1Name.ForeColor = System.Drawing.Color.Black;
            this.player1Name.Location = new System.Drawing.Point(450, 25);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(150, 40);
            this.player1Name.TabIndex = 8;
            this.player1Name.TextInput = "";
            this.player1Name.TextPreview = "Player #1";
            this.player1Name.UseSystemPasswordChar = false;
            // 
            // randomStart
            // 
            this.randomStart.BackColor = System.Drawing.Color.White;
            this.randomStart.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.randomStart.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.randomStart.Checked = false;
            this.randomStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomStart.Font = new System.Drawing.Font("Consolas", 12F);
            this.randomStart.Location = new System.Drawing.Point(6, 129);
            this.randomStart.Name = "randomStart";
            this.randomStart.Size = new System.Drawing.Size(160, 15);
            this.randomStart.TabIndex = 7;
            this.randomStart.Text = "Random start";
            this.randomStart.TextOnChecked = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "sec";
            // 
            // gameDurationCB
            // 
            this.gameDurationCB.FormattingEnabled = true;
            this.gameDurationCB.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "150",
            "180"});
            this.gameDurationCB.Location = new System.Drawing.Point(147, 34);
            this.gameDurationCB.Name = "gameDurationCB";
            this.gameDurationCB.Size = new System.Drawing.Size(58, 27);
            this.gameDurationCB.TabIndex = 2;
            this.gameDurationCB.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game duration";
            // 
            // musicDurationCB
            // 
            this.musicDurationCB.FormattingEnabled = true;
            this.musicDurationCB.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.musicDurationCB.Location = new System.Drawing.Point(147, 78);
            this.musicDurationCB.Name = "musicDurationCB";
            this.musicDurationCB.Size = new System.Drawing.Size(58, 27);
            this.musicDurationCB.TabIndex = 3;
            this.musicDurationCB.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music duration";
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.Tomato;
            this.selectButton.BackColorAdditional = System.Drawing.Color.Tomato;
            this.selectButton.BackColorGradientEnabled = false;
            this.selectButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.selectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.selectButton.ForeColor = System.Drawing.Color.White;
            this.selectButton.Location = new System.Drawing.Point(13, 314);
            this.selectButton.Name = "selectButton";
            this.selectButton.RoundingEnable = true;
            this.selectButton.Size = new System.Drawing.Size(181, 37);
            this.selectButton.TabIndex = 7;
            this.selectButton.Text = "Select folder...";
            this.selectButton.TextHover = null;
            this.selectButton.UseDownPressEffectOnClick = false;
            this.selectButton.UseRippleEffect = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // subfolders
            // 
            this.subfolders.BackColor = System.Drawing.Color.White;
            this.subfolders.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.subfolders.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.subfolders.Checked = false;
            this.subfolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subfolders.Font = new System.Drawing.Font("Consolas", 12F);
            this.subfolders.Location = new System.Drawing.Point(506, 327);
            this.subfolders.Name = "subfolders";
            this.subfolders.Size = new System.Drawing.Size(142, 15);
            this.subfolders.TabIndex = 8;
            this.subfolders.Text = "Subfolders";
            this.subfolders.TextOnChecked = "";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Tomato;
            this.clearButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.clearButton.BackColorGradientEnabled = false;
            this.clearButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(200, 314);
            this.clearButton.Name = "clearButton";
            this.clearButton.RoundingEnable = true;
            this.clearButton.Size = new System.Drawing.Size(106, 37);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.TextHover = null;
            this.clearButton.UseDownPressEffectOnClick = false;
            this.clearButton.UseRippleEffect = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Tomato;
            this.okButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.okButton.BackColorGradientEnabled = false;
            this.okButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(430, 585);
            this.okButton.Name = "okButton";
            this.okButton.RoundingEnable = true;
            this.okButton.Size = new System.Drawing.Size(106, 37);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.TextHover = "Save";
            this.okButton.UseDownPressEffectOnClick = false;
            this.okButton.UseRippleEffect = true;
            this.okButton.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cancelButton.BackColorGradientEnabled = false;
            this.cancelButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(542, 585);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RoundingEnable = true;
            this.cancelButton.Size = new System.Drawing.Size(106, 37);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextHover = "";
            this.cancelButton.UseDownPressEffectOnClick = false;
            this.cancelButton.UseRippleEffect = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 635);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.subfolders);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.melodyList);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox melodyList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox musicDurationCB;
        private System.Windows.Forms.ComboBox gameDurationCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private yt_DesignUI.EgoldsToggleSwitch randomStart;
        private yt_DesignUI.yt_Button selectButton;
        private yt_DesignUI.EgoldsToggleSwitch subfolders;
        private yt_DesignUI.yt_Button clearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private yt_DesignUI.EgoldsGoogleTextBox player2Name;
        private yt_DesignUI.EgoldsGoogleTextBox player1Name;
        private yt_DesignUI.yt_Button okButton;
        private yt_DesignUI.yt_Button cancelButton;
    }
}