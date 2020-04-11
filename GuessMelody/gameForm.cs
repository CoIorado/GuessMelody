using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public enum Winning
    {
        Player1,
        Player2,
        Draw
    }

    public partial class gameForm : Form
    {
        mainForm main;
        Random rnd = new Random();
        int musicDuration = 0;
        bool[] players = new bool[2];
        Timer tmpTimer = new Timer();
        public gameForm(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            MakeMusic();
            musicCountLabel.Text = Quiz.musicList.Count.ToString();
            timer.Start();
            nextButton.Text = "Next";
            VisualiseMusic();
            pauseButton.Enabled = true;
            resumeButton.Enabled = false;
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            Quiz.ReadMusic();
            Quiz.ReadParam();

            musicCountLabel.Text = Quiz.musicList.Count.ToString();
            musicDurationLabel.Text = Quiz.musicDuration.ToString();

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Quiz.gameDuration;

            this.MaximizeBox = false;
        }

        private void MakeMusic()
        {
            if (Quiz.musicList.Count == 0)
            {
                StopVisualization();
                EndGame();
                return;
            }

            musicDuration = Quiz.musicDuration;
            musicDurationLabel.Text = musicDuration.ToString();
            int N = rnd.Next(0, Quiz.musicList.Count);
            WMP.URL = Quiz.musicList[N];
            WMP.Ctlcontrols.play();
            Quiz.songName = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
            Quiz.musicList.RemoveAt(N);
            players[0] = false;
            players[1] = false;
        }

        private void gameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            WMP.Ctlcontrols.stop();
            main.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            musicDurationLabel.Text = musicDuration.ToString();

            if (progressBar1.Value == progressBar1.Maximum)
            {
                StopVisualization();
                EndGame();
                return;
            }

            if (musicDuration == 0)
            {
                MakeMusic();
                musicCountLabel.Text = Quiz.musicList.Count.ToString();
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            PauseGame();
            PauseVisualization();
            pauseButton.Enabled = false;
            resumeButton.Enabled = true;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            ResumeGame();
            ResumeVisualization();
            resumeButton.Enabled = false;
            pauseButton.Enabled = true;
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                timer.Stop();
                WMP.Ctlcontrols.stop();
                this.Close();
            }

            if (timer.Enabled)
            {
                if (!players[0] && e.KeyData == Keys.A)
                {
                    PauseGame();
                    PauseVisualization();
                    messageForm message = new messageForm();
                    message.messageLabel.Text = "Player 1";
                    if (message.ShowDialog() == DialogResult.Yes)
                    {
                        score1Label.Text = (int.Parse(score1Label.Text) + 1).ToString();
                        MakeMusic();
                        musicCountLabel.Text = Quiz.musicList.Count.ToString();
                    }
                    players[0] = true;
                    ResumeGame();
                    ResumeVisualization();
                }
                if (!players[1] && e.KeyData == Keys.P)
                {
                    PauseGame();
                    PauseVisualization();
                    messageForm message = new messageForm();
                    message.messageLabel.Text = "Player 2";
                    if (message.ShowDialog() == DialogResult.Yes)
                    {
                        score2Label.Text = (int.Parse(score2Label.Text) + 1).ToString();
                        MakeMusic();
                        musicCountLabel.Text = Quiz.musicList.Count.ToString();
                    }
                    players[1] = true;
                    ResumeGame();
                    ResumeVisualization();
                }
            }
        }

        private void PauseGame()
        {
            timer.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void ResumeGame()
        {
            timer.Start();
            WMP.Ctlcontrols.play();
        }

        private void EndGame()
        {
            timer.Stop();
            WMP.Ctlcontrols.stop();

            Winning winning;
            if (int.Parse(score1Label.Text) > int.Parse(score2Label.Text))
                winning = Winning.Player1;
            else if (int.Parse(score1Label.Text) < int.Parse(score2Label.Text))
                winning = Winning.Player2;
            else
                winning = Winning.Draw;

            gameOverForm gameOver = new gameOverForm(this, winning);
            gameOver.ShowDialog();
        }

        private void musicDurationLabel_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(musicDurationLabel.Text) <= 3)
                musicDurationLabel.ForeColor = Color.Red;
            else
                musicDurationLabel.ForeColor = Color.Black;
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Quiz.randomStart && WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
        }

        private void score1Label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (sender as Label).Text = (int.Parse((sender as Label).Text) + 1).ToString();
            if (int.Parse((sender as Label).Text) > 0 && e.Button == MouseButtons.Right)
                (sender as Label).Text = (int.Parse((sender as Label).Text) - 1).ToString();
        }

        private void VisualiseMusic()
        {
            visualMusic.Visible = true;

            foreach (Panel panel in visualMusic.Controls)
                panel.Location = new Point(panel.Location.X, rnd.Next(0, 95));

            tmpTimer.Interval = 200;
            tmpTimer.Tick += tmpTimer_Tick;
            tmpTimer.Start();
        }

        private void PauseVisualization()
        {
            tmpTimer.Stop();
        }

        private void ResumeVisualization()
        {
            tmpTimer.Start();
        }

        private void StopVisualization()
        {
            visualMusic.Visible = false;
            tmpTimer.Dispose();
        }

        private void tmpTimer_Tick(object sender, EventArgs e)
        {
            foreach (Panel panel in visualMusic.Controls)
                panel.Location = new Point(panel.Location.X, rnd.Next(0, 95));
        }
    }
}