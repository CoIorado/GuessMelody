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
    public partial class mainForm : Form
    {
        private readonly settingsForm settingsForm = new settingsForm();

        public mainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Quiz.lastFolder))
            {
                MessageBox.Show("Please, choose at least one song.", "No melodies found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            gameForm gameForm = new gameForm(this);
            gameForm.Show();
            this.Hide();

            tutorialForm tutorialForm = new tutorialForm(gameForm);
            tutorialForm.Size = gameForm.Size;
            tutorialForm.Location = gameForm.Location;
            tutorialForm.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Quiz.ReadParam();
            if (!string.IsNullOrEmpty(Quiz.lastFolder))
                Quiz.ReadMusic();
            this.MaximizeBox = false;
        }
    }
}
