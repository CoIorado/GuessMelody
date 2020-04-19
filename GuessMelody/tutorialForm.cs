using System;
using System.Windows.Forms;
using yt_DesignUI;

namespace GuessMelody
{
    public partial class tutorialForm : Form
    {
        gameForm gameForm;
        bool isPlayButtonPressed = false;           //нужно предусмотреть, чтобы tutorialForm была закрыта именно нажатием кнопки Play, а не стандартной кнопки Windows
        Timer timer1, timer2;
        public tutorialForm(gameForm gameForm)
        {
            InitializeComponent();
            this.gameForm = gameForm;
            Animator.Start();
        }

        private void tutorialForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isPlayButtonPressed)
                gameForm.Close();
        }

        private void tutorialForm_Move(object sender, EventArgs e)
        {
            gameForm.Location = this.Location;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            isPlayButtonPressed = true;
            gameForm.forwardButton_Click(this, null);
            this.Close();
        }

        private void score2Label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (sender as Label).Text = (int.Parse((sender as Label).Text) + 1).ToString();
            if (int.Parse((sender as Label).Text) > 0 && e.Button == MouseButtons.Right)
                (sender as Label).Text = (int.Parse((sender as Label).Text) - 1).ToString();
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            label1.Text = score1Label.Text;
            label2.Text = score2Label.Text;
            label3.Text = player2Label.Text;
            label4.Text = player1Label.Text;

            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();

            if (progressBar1.Value == progressBar1.ValueMaximum)
                timer1.Stop();
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            timer1.Dispose();
            panel3.BringToFront();
            label8.Text = score1Label.Text;
            label9.Text = score2Label.Text;
            label10.Text = player2Label.Text;
            label11.Text = player1Label.Text;
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            playButton.Image = Properties.Resources.play_pressed;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.Image = Properties.Resources.play_unpressed;
        }

        private void pauseButton_MouseEnter(object sender, EventArgs e)
        {
            pauseButton.Image = Properties.Resources.pause_pressed;
        }

        private void pauseButton_MouseLeave(object sender, EventArgs e)
        {
            pauseButton.Image = Properties.Resources.pause_unpressed;
        }

        private void forwardButton_MouseEnter(object sender, EventArgs e)
        {
            forwardButton.Image = Properties.Resources.forward_pressed;
        }

        private void forwardButton_MouseLeave(object sender, EventArgs e)
        {
            forwardButton.Image = Properties.Resources.forward_unpressed;
        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            musicCountLabel.Text = Quiz.musicList.Count.ToString();
            musicDurationLabel.Text = Quiz.musicDuration.ToString();

            panel4.BringToFront();
            label14.Text = score1Label.Text;
            label15.Text = score2Label.Text;
            label16.Text = player2Label.Text;
            label17.Text = player1Label.Text;

            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }

        private void tutorialForm_Load(object sender, EventArgs e)
        {
            Quiz.ReadMusic();
            Quiz.ReadParam();

            player1Label.Text = Quiz.firstPlayerName;
            player2Label.Text = Quiz.secondPlayerName;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (int.Parse(musicDurationLabel.Text) > 0)
            {
                musicDurationLabel.Text = (int.Parse(musicDurationLabel.Text) - 1).ToString();
            }
            if (int.Parse(musicDurationLabel.Text) == 0)
            {
                musicCountLabel.Text = (int.Parse(musicCountLabel.Text) - 1).ToString();
                musicDurationLabel.Text = Quiz.musicDuration.ToString();
            }
            if (int.Parse(musicCountLabel.Text) == 0)
            {
                musicDurationLabel.Text = "0";
                musicCountLabel.ForeColor = label14.ForeColor;
                musicDurationLabel.ForeColor = label14.ForeColor;
                label18.ForeColor = label14.ForeColor;
                label19.ForeColor = label14.ForeColor;
                timer2.Stop();
                timer2.Dispose();
            }
        }
    }
}
