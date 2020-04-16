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
    public partial class gameOverForm : Form
    {
        gameForm gameForm;
        Winning winning;
        public gameOverForm(gameForm gameForm, Winning winning)
        {
            this.gameForm = gameForm;
            this.winning = winning;
            InitializeComponent();
        }

        private void gameOverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
            gameForm.Close();
        }

        private void gameOverForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            if (winning == Winning.Player1)
                label1.Text = "Player 1 \n WON THE GAME";
            else if (winning == Winning.Player2)
                label1.Text = "Player 2 \n WON THE GAME";
            else
                label1.Text = "DRAW";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            gameForm.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            gameForm.Close();
        }

        private void gameOverForm_Move(object sender, EventArgs e)
        {
            gameForm.Location = this.Location;
        }

        private void gameOverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameForm.Close();
        }
    }
}
