using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessMelody
{
    public partial class messageForm : Form
    {
        int answerTime = 5;
        public messageForm()
        {
            InitializeComponent();
        }

        private void messageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                yesButton.PerformClick();
            if (e.KeyData == Keys.Escape)
                noButton.PerformClick();
        }

        private void messageForm_Load(object sender, EventArgs e)
        {
            answerTime = 5;
            timeLabel.Text = answerTime.ToString();
            timer1.Start();
            this.MaximizeBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            answerTime--;
            timeLabel.Text = answerTime.ToString();

            if (answerTime == 0)
            {
                timer1.Stop();
                System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(Properties.Resources.sfx1);
                soundPlayer.Play();
            }
        }

        private void timeLabel_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(timeLabel.Text) <= 3)
                timeLabel.ForeColor = Color.Red;
            else
                timeLabel.ForeColor = Color.White;
        }

        private void songNameLabel_Click(object sender, EventArgs e)
        {
            if (int.Parse(timeLabel.Text) <= 0)
            {
                songNameLabel.Font = new Font(songNameLabel.Font.FontFamily, 15);
                songNameLabel.Text = Quiz.songName;
                songNameLabel.ForeColor = Color.DarkGoldenrod;
                songNameLabel.Cursor = Cursors.Arrow;
            }
        }

        private void messageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
