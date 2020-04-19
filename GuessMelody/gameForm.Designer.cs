namespace GuessMelody
{
    partial class gameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.score1Label = new System.Windows.Forms.Label();
            this.score2Label = new System.Windows.Forms.Label();
            this.musicCountLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.musicDurationLabel = new System.Windows.Forms.Label();
            this.visualMusic = new System.Windows.Forms.Panel();
            this.bar7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bar1 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.bar4 = new System.Windows.Forms.Panel();
            this.bar5 = new System.Windows.Forms.Panel();
            this.bar6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.pauseButton = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.progressBar1 = new yt_DesignUI.EgoldsProgressBar();
            this.visualMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Label
            // 
            this.player1Label.BackColor = System.Drawing.Color.Transparent;
            this.player1Label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.player1Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.player1Label.Location = new System.Drawing.Point(24, 42);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(141, 31);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Player #1";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Label
            // 
            this.player2Label.BackColor = System.Drawing.Color.Transparent;
            this.player2Label.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.player2Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.player2Label.Location = new System.Drawing.Point(222, 42);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(141, 31);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "Player #2";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score1Label
            // 
            this.score1Label.AutoSize = true;
            this.score1Label.BackColor = System.Drawing.Color.Transparent;
            this.score1Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.score1Label.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1Label.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.score1Label.Location = new System.Drawing.Point(60, 73);
            this.score1Label.Name = "score1Label";
            this.score1Label.Size = new System.Drawing.Size(70, 74);
            this.score1Label.TabIndex = 4;
            this.score1Label.Text = "0";
            this.score1Label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.score1Label_MouseClick);
            // 
            // score2Label
            // 
            this.score2Label.AutoSize = true;
            this.score2Label.BackColor = System.Drawing.Color.Transparent;
            this.score2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.score2Label.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2Label.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.score2Label.Location = new System.Drawing.Point(258, 73);
            this.score2Label.Name = "score2Label";
            this.score2Label.Size = new System.Drawing.Size(70, 74);
            this.score2Label.TabIndex = 5;
            this.score2Label.Text = "0";
            this.score2Label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.score1Label_MouseClick);
            // 
            // musicCountLabel
            // 
            this.musicCountLabel.AutoSize = true;
            this.musicCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.musicCountLabel.ForeColor = System.Drawing.Color.White;
            this.musicCountLabel.Location = new System.Drawing.Point(272, 523);
            this.musicCountLabel.Name = "musicCountLabel";
            this.musicCountLabel.Size = new System.Drawing.Size(30, 31);
            this.musicCountLabel.TabIndex = 8;
            this.musicCountLabel.Text = "0";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // musicDurationLabel
            // 
            this.musicDurationLabel.AutoSize = true;
            this.musicDurationLabel.BackColor = System.Drawing.Color.Transparent;
            this.musicDurationLabel.ForeColor = System.Drawing.Color.White;
            this.musicDurationLabel.Location = new System.Drawing.Point(68, 523);
            this.musicDurationLabel.Name = "musicDurationLabel";
            this.musicDurationLabel.Size = new System.Drawing.Size(30, 31);
            this.musicDurationLabel.TabIndex = 10;
            this.musicDurationLabel.Text = "0";
            this.musicDurationLabel.TextChanged += new System.EventHandler(this.musicDurationLabel_TextChanged);
            // 
            // visualMusic
            // 
            this.visualMusic.BackColor = System.Drawing.Color.Transparent;
            this.visualMusic.Controls.Add(this.bar7);
            this.visualMusic.Controls.Add(this.panel2);
            this.visualMusic.Controls.Add(this.panel3);
            this.visualMusic.Controls.Add(this.bar1);
            this.visualMusic.Controls.Add(this.bar2);
            this.visualMusic.Controls.Add(this.bar3);
            this.visualMusic.Controls.Add(this.bar4);
            this.visualMusic.Controls.Add(this.bar5);
            this.visualMusic.Controls.Add(this.bar6);
            this.visualMusic.Controls.Add(this.panel7);
            this.visualMusic.Controls.Add(this.panel6);
            this.visualMusic.Location = new System.Drawing.Point(18, 187);
            this.visualMusic.Name = "visualMusic";
            this.visualMusic.Size = new System.Drawing.Size(348, 104);
            this.visualMusic.TabIndex = 12;
            this.visualMusic.Visible = false;
            // 
            // bar7
            // 
            this.bar7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bar7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar7.Location = new System.Drawing.Point(194, 0);
            this.bar7.Name = "bar7";
            this.bar7.Size = new System.Drawing.Size(26, 104);
            this.bar7.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 104);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(322, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 104);
            this.panel3.TabIndex = 12;
            // 
            // bar1
            // 
            this.bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar1.Location = new System.Drawing.Point(2, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(26, 104);
            this.bar1.TabIndex = 3;
            // 
            // bar2
            // 
            this.bar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar2.Location = new System.Drawing.Point(34, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(26, 104);
            this.bar2.TabIndex = 1;
            // 
            // bar3
            // 
            this.bar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar3.Location = new System.Drawing.Point(66, 0);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(26, 104);
            this.bar3.TabIndex = 2;
            // 
            // bar4
            // 
            this.bar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bar4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar4.Location = new System.Drawing.Point(98, 0);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(26, 104);
            this.bar4.TabIndex = 5;
            // 
            // bar5
            // 
            this.bar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bar5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar5.Location = new System.Drawing.Point(130, 0);
            this.bar5.Name = "bar5";
            this.bar5.Size = new System.Drawing.Size(26, 104);
            this.bar5.TabIndex = 3;
            // 
            // bar6
            // 
            this.bar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bar6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar6.Location = new System.Drawing.Point(162, 0);
            this.bar6.Name = "bar6";
            this.bar6.Size = new System.Drawing.Size(26, 104);
            this.bar6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(258, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(26, 104);
            this.panel7.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(290, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(26, 104);
            this.panel6.TabIndex = 8;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Image = global::GuessMelody.Properties.Resources.play_unpressed;
            this.playButton.Location = new System.Drawing.Point(18, 372);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 100);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playButton.TabIndex = 13;
            this.playButton.TabStop = false;
            this.playButton.EnabledChanged += new System.EventHandler(this.playButton_EnabledChanged);
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseButton.Image = global::GuessMelody.Properties.Resources.pause_unpressed;
            this.pauseButton.Location = new System.Drawing.Point(142, 372);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 100);
            this.pauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseButton.TabIndex = 14;
            this.pauseButton.TabStop = false;
            this.pauseButton.EnabledChanged += new System.EventHandler(this.pauseButton_EnabledChanged);
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            this.pauseButton.MouseEnter += new System.EventHandler(this.pauseButton_MouseEnter);
            this.pauseButton.MouseLeave += new System.EventHandler(this.pauseButton_MouseLeave);
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forwardButton.Image = global::GuessMelody.Properties.Resources.forward_unpressed;
            this.forwardButton.Location = new System.Drawing.Point(266, 372);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(100, 100);
            this.forwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forwardButton.TabIndex = 15;
            this.forwardButton.TabStop = false;
            this.forwardButton.EnabledChanged += new System.EventHandler(this.forwardButton_EnabledChanged);
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            this.forwardButton.MouseEnter += new System.EventHandler(this.forwardButton_MouseEnter);
            this.forwardButton.MouseLeave += new System.EventHandler(this.forwardButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Time left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tracks left:";
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(308, 155);
            this.WMP.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(58, 21);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.progressBar1.BackColorProgressLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.progressBar1.BackColorProgressRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.progressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.progressBar1.Location = new System.Drawing.Point(18, 315);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 37);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 21;
            this.progressBar1.Text = "egoldsProgressBar1";
            this.progressBar1.Value = 0;
            this.progressBar1.ValueMaximum = 100;
            this.progressBar1.ValueMinimum = 0;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.visualMusic);
            this.Controls.Add(this.musicDurationLabel);
            this.Controls.Add(this.musicCountLabel);
            this.Controls.Add(this.score2Label);
            this.Controls.Add(this.score1Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.WMP);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MaximizeBox = false;
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess melody";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gameForm_FormClosed);
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.visualMusic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label score1Label;
        private System.Windows.Forms.Label score2Label;
        private System.Windows.Forms.Label musicCountLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label musicDurationLabel;
        private System.Windows.Forms.Panel visualMusic;
        private System.Windows.Forms.Panel bar7;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Panel bar4;
        private System.Windows.Forms.Panel bar6;
        private System.Windows.Forms.Panel bar5;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.PictureBox pauseButton;
        private System.Windows.Forms.PictureBox forwardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private yt_DesignUI.EgoldsProgressBar progressBar1;
    }
}