using System;
using System.Drawing;
using yt_DesignUI;
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
        bool isForwardButtonPressed = false;
        Timer tmpTimer = new Timer();
        public gameForm(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            Animator.Start();
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            Quiz.ReadMusic();
            Quiz.ReadParam();

            musicCountLabel.Text = Quiz.musicList.Count.ToString();
            musicDurationLabel.Text = Quiz.musicDuration.ToString();
            player1Label.Text = Quiz.firstPlayerName;
            player2Label.Text = Quiz.secondPlayerName;

            progressBar1.Value = 0;
            progressBar1.ValueMinimum = 0;
            progressBar1.ValueMaximum = Quiz.gameDuration;

            this.MaximizeBox = false;

            playButton.Enabled = false;
            pauseButton.Enabled = false;
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
            progressBar1.PerformStep();
            musicDuration--;
            musicDurationLabel.Text = musicDuration.ToString();

            if (progressBar1.Value == progressBar1.ValueMaximum)
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
            playButton.Enabled = true;
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
                    message.Text = "Player #1";
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
                    message.Text = "Player #2";
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
            gameOver.Location = this.Location;
            gameOver.Size = this.Size;
            gameOver.ShowDialog();
        }

        private void musicDurationLabel_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(musicDurationLabel.Text) <= 3)
                musicDurationLabel.ForeColor = Color.Red;
            else
                musicDurationLabel.ForeColor = Color.White;
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

        private void VisualizeMusic()
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

        private void playButton_Click(object sender, EventArgs e)
        {
            ResumeGame();
            ResumeVisualization();
            playButton.Enabled = false;
            pauseButton.Enabled = true;
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            if (playButton.Enabled)
                playButton.Image = Properties.Resources.play_pressed;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            if (playButton.Enabled)
                playButton.Image = Properties.Resources.play_unpressed;
        }

        private void playButton_EnabledChanged(object sender, EventArgs e)
        {
            if (playButton.Enabled)
                playButton.Image = Properties.Resources.play_unpressed;
            else
                playButton.Image = Properties.Resources.play_unabled;
        }

        private void pauseButton_MouseEnter(object sender, EventArgs e)
        {
            if (pauseButton.Enabled)
                pauseButton.Image = Properties.Resources.pause_pressed;
        }

        private void pauseButton_MouseLeave(object sender, EventArgs e)
        {
            if (pauseButton.Enabled)
                pauseButton.Image = Properties.Resources.pause_unpressed;
        }

        private void pauseButton_EnabledChanged(object sender, EventArgs e)
        {
            if (pauseButton.Enabled)
                pauseButton.Image = Properties.Resources.pause_unpressed;
            else
                pauseButton.Image = Properties.Resources.pause_unabled;
        }

        public void forwardButton_Click(object sender, EventArgs e)
        {
            MakeMusic();
            musicCountLabel.Text = Quiz.musicList.Count.ToString();
            timer.Start();
            pauseButton.Enabled = true;
            playButton.Enabled = false;

            if (!isForwardButtonPressed)
                VisualizeMusic();
            else
                ResumeVisualization();

            isForwardButtonPressed = true;
        }

        private void forwardButton_MouseEnter(object sender, EventArgs e)
        {
            if (forwardButton.Enabled)
                forwardButton.Image = Properties.Resources.forward_pressed;
        }

        private void forwardButton_MouseLeave(object sender, EventArgs e)
        {
            if (forwardButton.Enabled)
                forwardButton.Image = Properties.Resources.forward_unpressed;
        }

        private void forwardButton_EnabledChanged(object sender, EventArgs e)
        {
            if (forwardButton.Enabled)
                forwardButton.Image = Properties.Resources.forward_unpressed;
            else
                forwardButton.Image = Properties.Resources.forward_unabled;
        }
    }
}