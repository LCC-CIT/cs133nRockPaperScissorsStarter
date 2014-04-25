using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program6_10
{
    public partial class RpsForm : Form
    {
        // Random object, declared at class scope
        Random randomNumberGenerator = new Random();

        // instance variables and constants (declared at class scope)
        int userChoice = 0; // nothing chosen yet

        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;

       public RpsForm()
        {
            InitializeComponent();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            userChoice = ROCK;
            userPictureBox.Image = Properties.Resources.Rock;
        }

        // You need to add event handlers for paperButton and scissorsButton


        private void playButton_Click(object sender, EventArgs e)
        {
            int computerChoice = randomNumberGenerator.Next(1, 4);
            switch (computerChoice)
            {
                case ROCK:
                    computerPictureBox.Image = Properties.Resources.Rock;
                    break;
                case PAPER:
                    computerPictureBox.Image = Properties.Resources.Paper;
                    break;
                // This is only partially finished ... you're not done yet!
            }

            // Clear the winner labels
            userWinsLabel.Text = "";
            computerWinsLabel.Text = "";

            // Determine the winner
            if (userChoice == computerChoice)
            {
                userWinsLabel.Text = "Tie";
                computerWinsLabel.Text = "Tie";
            }
            // This is meant as a sample ... you're not done yet!
            // You need to write the rest of the logic for determining the winner
            // and putting the text "winner" in the appropriate label.
        }

    }
}
