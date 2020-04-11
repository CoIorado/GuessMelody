﻿namespace GuessMelody
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
            this.selectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.subfolderCB = new System.Windows.Forms.CheckBox();
            this.okButton1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.randomMelodyCB = new System.Windows.Forms.CheckBox();
            this.musicDurationCB = new System.Windows.Forms.ComboBox();
            this.gameDurationCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // selectButton
            // 
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(13, 315);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(181, 36);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select folder...";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(202, 315);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 36);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // subfolderCB
            // 
            this.subfolderCB.AutoSize = true;
            this.subfolderCB.Location = new System.Drawing.Point(531, 323);
            this.subfolderCB.Margin = new System.Windows.Forms.Padding(4);
            this.subfolderCB.Name = "subfolderCB";
            this.subfolderCB.Size = new System.Drawing.Size(118, 23);
            this.subfolderCB.TabIndex = 3;
            this.subfolderCB.Text = "Subfolders";
            this.subfolderCB.UseVisualStyleBackColor = true;
            // 
            // okButton1
            // 
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Location = new System.Drawing.Point(429, 544);
            this.okButton1.Margin = new System.Windows.Forms.Padding(4);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(106, 36);
            this.okButton1.TabIndex = 4;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(543, 544);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 36);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.randomMelodyCB);
            this.groupBox1.Controls.Add(this.musicDurationCB);
            this.groupBox1.Controls.Add(this.gameDurationCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game preferences";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 70);
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
            // randomMelodyCB
            // 
            this.randomMelodyCB.AutoSize = true;
            this.randomMelodyCB.Location = new System.Drawing.Point(10, 119);
            this.randomMelodyCB.Name = "randomMelodyCB";
            this.randomMelodyCB.Size = new System.Drawing.Size(136, 23);
            this.randomMelodyCB.TabIndex = 4;
            this.randomMelodyCB.Text = "Random start";
            this.randomMelodyCB.UseVisualStyleBackColor = true;
            // 
            // musicDurationCB
            // 
            this.musicDurationCB.FormattingEnabled = true;
            this.musicDurationCB.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.musicDurationCB.Location = new System.Drawing.Point(147, 67);
            this.musicDurationCB.Name = "musicDurationCB";
            this.musicDurationCB.Size = new System.Drawing.Size(58, 27);
            this.musicDurationCB.TabIndex = 3;
            this.musicDurationCB.Text = "10";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music duration";
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
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.subfolderCB);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectButton);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox melodyList;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox subfolderCB;
        private System.Windows.Forms.Button okButton1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox randomMelodyCB;
        private System.Windows.Forms.ComboBox musicDurationCB;
        private System.Windows.Forms.ComboBox gameDurationCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}