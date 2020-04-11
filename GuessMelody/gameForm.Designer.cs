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
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.nextButton = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.score1Label = new System.Windows.Forms.Label();
            this.score2Label = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.musicCountLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.musicDurationLabel = new System.Windows.Forms.Label();
            this.visualMusic = new System.Windows.Forms.Panel();
            this.bar7 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.bar1 = new System.Windows.Forms.Panel();
            this.bar5 = new System.Windows.Forms.Panel();
            this.bar6 = new System.Windows.Forms.Panel();
            this.bar4 = new System.Windows.Forms.Panel();
            this.bar8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.visualMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 503);
            this.WMP.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(245, 46);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // nextButton
            // 
            this.nextButton.FlatAppearance.BorderSize = 2;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(18, 427);
            this.nextButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(281, 60);
            this.nextButton.TabIndex = 1;
            this.nextButton.TabStop = false;
            this.nextButton.Text = "Play";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(59, 27);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(141, 31);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Player #1";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(485, 27);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(141, 31);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "Player #2";
            // 
            // score1Label
            // 
            this.score1Label.AutoSize = true;
            this.score1Label.Location = new System.Drawing.Point(59, 95);
            this.score1Label.Name = "score1Label";
            this.score1Label.Size = new System.Drawing.Size(30, 31);
            this.score1Label.TabIndex = 4;
            this.score1Label.Text = "0";
            this.score1Label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.score1Label_MouseClick);
            // 
            // score2Label
            // 
            this.score2Label.AutoSize = true;
            this.score2Label.Location = new System.Drawing.Point(485, 95);
            this.score2Label.Name = "score2Label";
            this.score2Label.Size = new System.Drawing.Size(30, 31);
            this.score2Label.TabIndex = 5;
            this.score2Label.Text = "0";
            this.score2Label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.score1Label_MouseClick);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.FlatAppearance.BorderSize = 2;
            this.pauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Location = new System.Drawing.Point(317, 427);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(165, 60);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.TabStop = false;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Enabled = false;
            this.resumeButton.FlatAppearance.BorderSize = 2;
            this.resumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resumeButton.Location = new System.Drawing.Point(500, 427);
            this.resumeButton.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(165, 60);
            this.resumeButton.TabIndex = 7;
            this.resumeButton.TabStop = false;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // musicCountLabel
            // 
            this.musicCountLabel.AutoSize = true;
            this.musicCountLabel.Location = new System.Drawing.Point(327, 281);
            this.musicCountLabel.Name = "musicCountLabel";
            this.musicCountLabel.Size = new System.Drawing.Size(30, 31);
            this.musicCountLabel.TabIndex = 8;
            this.musicCountLabel.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(647, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // musicDurationLabel
            // 
            this.musicDurationLabel.AutoSize = true;
            this.musicDurationLabel.Location = new System.Drawing.Point(635, 362);
            this.musicDurationLabel.Name = "musicDurationLabel";
            this.musicDurationLabel.Size = new System.Drawing.Size(30, 31);
            this.musicDurationLabel.TabIndex = 10;
            this.musicDurationLabel.Text = "0";
            this.musicDurationLabel.TextChanged += new System.EventHandler(this.musicDurationLabel_TextChanged);
            // 
            // visualMusic
            // 
            this.visualMusic.Controls.Add(this.bar8);
            this.visualMusic.Controls.Add(this.bar7);
            this.visualMusic.Controls.Add(this.bar1);
            this.visualMusic.Controls.Add(this.bar4);
            this.visualMusic.Controls.Add(this.bar6);
            this.visualMusic.Controls.Add(this.bar5);
            this.visualMusic.Controls.Add(this.bar3);
            this.visualMusic.Controls.Add(this.bar2);
            this.visualMusic.Location = new System.Drawing.Point(18, 226);
            this.visualMusic.Name = "visualMusic";
            this.visualMusic.Size = new System.Drawing.Size(186, 104);
            this.visualMusic.TabIndex = 12;
            this.visualMusic.Visible = false;
            // 
            // bar7
            // 
            this.bar7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bar7.Location = new System.Drawing.Point(144, 0);
            this.bar7.Name = "bar7";
            this.bar7.Size = new System.Drawing.Size(18, 104);
            this.bar7.TabIndex = 0;
            // 
            // bar2
            // 
            this.bar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bar2.Location = new System.Drawing.Point(24, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(18, 104);
            this.bar2.TabIndex = 1;
            // 
            // bar3
            // 
            this.bar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bar3.Location = new System.Drawing.Point(48, 0);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(18, 104);
            this.bar3.TabIndex = 2;
            // 
            // bar1
            // 
            this.bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(18, 104);
            this.bar1.TabIndex = 3;
            // 
            // bar5
            // 
            this.bar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bar5.Location = new System.Drawing.Point(96, 0);
            this.bar5.Name = "bar5";
            this.bar5.Size = new System.Drawing.Size(18, 104);
            this.bar5.TabIndex = 3;
            // 
            // bar6
            // 
            this.bar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bar6.Location = new System.Drawing.Point(120, 0);
            this.bar6.Name = "bar6";
            this.bar6.Size = new System.Drawing.Size(18, 104);
            this.bar6.TabIndex = 4;
            // 
            // bar4
            // 
            this.bar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bar4.Location = new System.Drawing.Point(72, 0);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(18, 104);
            this.bar4.TabIndex = 5;
            // 
            // bar8
            // 
            this.bar8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bar8.Location = new System.Drawing.Point(168, 0);
            this.bar8.Name = "bar8";
            this.bar8.Size = new System.Drawing.Size(18, 104);
            this.bar8.TabIndex = 5;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.visualMusic);
            this.Controls.Add(this.musicDurationLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.musicCountLabel);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.score2Label);
            this.Controls.Add(this.score1Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.WMP);
            this.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess melody";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gameForm_FormClosed);
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.visualMusic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label score1Label;
        private System.Windows.Forms.Label score2Label;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Label musicCountLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label musicDurationLabel;
        private System.Windows.Forms.Panel visualMusic;
        private System.Windows.Forms.Panel bar8;
        private System.Windows.Forms.Panel bar7;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Panel bar4;
        private System.Windows.Forms.Panel bar6;
        private System.Windows.Forms.Panel bar5;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Panel bar2;
    }
}