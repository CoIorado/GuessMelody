using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            foreach (string melody in melodyList.Items)
                Quiz.musicList.Add(melody);

            Quiz.gameDuration = int.Parse(gameDurationCB.Text);
            Quiz.musicDuration = int.Parse(musicDurationCB.Text);
            Quiz.randomStart = randomMelodyCB.Checked;
            Quiz.subFolders = subfolderCB.Checked;
            Quiz.WriteParam();

            this.Close();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = null;
                
                musicList = Directory.GetFiles(fbDialog.SelectedPath, "*.mp3", subfolderCB.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);

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
            randomMelodyCB.Checked = Quiz.randomStart;
            subfolderCB.Checked = Quiz.subFolders;

            if (string.IsNullOrEmpty(Quiz.lastFolder))
                return;

            Quiz.ReadMusic();
            melodyList.Items.Clear();
            melodyList.Items.AddRange(Quiz.musicList.ToArray());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            melodyList.Items.Clear();
            Quiz.musicList.Clear();
            Quiz.lastFolder = "";
        }
    }
}
