using System;
using System.Windows.Forms;
using System.IO;
using yt_DesignUI;

namespace GuessMelody
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
            Animator.Start();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (melodyList.Items.Count == 0)
            {
                Quiz.musicList.Clear();
                Quiz.lastFolder = "";
            }
            else
            {
                foreach (string melody in melodyList.Items)
                    Quiz.musicList.Add(melody);
            }

            Quiz.gameDuration = int.Parse(gameDurationCB.Text);
            Quiz.musicDuration = int.Parse(musicDurationCB.Text);
            Quiz.randomStart = randomStart.Checked;
            Quiz.subFolders = subfolders.Checked;
            if (string.IsNullOrEmpty(player1Name.Text))
                Quiz.firstPlayerName = player1Name.TextPreview;
            else
                Quiz.firstPlayerName = player1Name.Text;
            if (string.IsNullOrEmpty(player2Name.Text))
                Quiz.secondPlayerName = player2Name.TextPreview;
            else
                Quiz.secondPlayerName = player2Name.Text;

            Quiz.WriteParam();

            this.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = null;
                
                musicList = Directory.GetFiles(fbDialog.SelectedPath, "*.mp3", subfolders.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);

                Quiz.lastFolder = fbDialog.SelectedPath;

                melodyList.Items.Clear();
                melodyList.Items.AddRange(musicList);
                Quiz.musicList.Clear();
                Quiz.musicList.AddRange(musicList);
            }
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            gameDurationCB.Text = Convert.ToString(Quiz.gameDuration);
            musicDurationCB.Text = Convert.ToString(Quiz.musicDuration);
            randomStart.Checked = Quiz.randomStart;
            subfolders.Checked = Quiz.subFolders;
            player1Name.Text = "";
            player2Name.Text = "";
            player1Name.TextPreview = Quiz.firstPlayerName;
            player2Name.TextPreview = Quiz.secondPlayerName;

            if (string.IsNullOrEmpty(Quiz.lastFolder))
                return;

            Quiz.ReadMusic();
            melodyList.Items.Clear();
            melodyList.Items.AddRange(Quiz.musicList.ToArray());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            melodyList.Items.Clear();
        }
    }
}
