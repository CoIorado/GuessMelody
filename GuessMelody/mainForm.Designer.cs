namespace GuessMelody
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.playButton = new yt_DesignUI.yt_Button();
            this.settingsButton = new yt_DesignUI.yt_Button();
            this.exitButton = new yt_DesignUI.yt_Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Indigo;
            this.playButton.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.playButton.BackColorGradientEnabled = true;
            this.playButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(125, 154);
            this.playButton.Name = "playButton";
            this.playButton.RoundingEnable = true;
            this.playButton.Size = new System.Drawing.Size(245, 56);
            this.playButton.TabIndex = 19;
            this.playButton.Text = "Play";
            this.playButton.TextHover = null;
            this.playButton.UseDownPressEffectOnClick = false;
            this.playButton.UseRippleEffect = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Indigo;
            this.settingsButton.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.settingsButton.BackColorGradientEnabled = true;
            this.settingsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(125, 232);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.RoundingEnable = true;
            this.settingsButton.Size = new System.Drawing.Size(245, 56);
            this.settingsButton.TabIndex = 20;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextHover = null;
            this.settingsButton.UseDownPressEffectOnClick = false;
            this.settingsButton.UseRippleEffect = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Indigo;
            this.exitButton.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.exitButton.BackColorGradientEnabled = true;
            this.exitButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(125, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.RoundingEnable = true;
            this.exitButton.Size = new System.Drawing.Size(245, 56);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Exit";
            this.exitButton.TextHover = null;
            this.exitButton.UseDownPressEffectOnClick = false;
            this.exitButton.UseRippleEffect = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.playButton);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess melody";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private yt_DesignUI.yt_Button playButton;
        private yt_DesignUI.yt_Button settingsButton;
        private yt_DesignUI.yt_Button exitButton;
    }
}

