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
    public partial class tutorialForm : Form
    {
        gameForm gameForm;
        bool isPlayButtonPressed = false;
        public tutorialForm(gameForm gameForm)
        {
            InitializeComponent();
            this.gameForm = gameForm;
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

        private void playButton_Click(object sender, EventArgs e)
        {
            isPlayButtonPressed = true;
            gameForm.forwardButton_Click(this, null);
            this.Close();
        }
    }
}
