using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rockPaperScissors
{
    public partial class MainWindow : Form
    {

        string playerChoice;
        string computerChoice;
        string[] options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;
        string gameMode;

        public MainWindow(string gameMode)
        {
            InitializeComponent();
            this.gameMode = gameMode;
        }

       
        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;

            playerChoice = (string)tempButton.Tag;

            int i = random.Next(0, options.Length);

            computerChoice = options[i];

            updateTextAndImage(playerChoice, PLAYER_PIC);
            updateTextAndImage(computerChoice,CPU_PIC);
            checkGame();
        }
        private void updateTextAndImage(String text, PictureBox pic)
        {
            if (pic == PLAYER_PIC)
            {
                switch (text)
                {
                    case "R":
                        pic.Image = Properties.Resources.rock_emoji;
                        break;
                    case "P":
                        pic.Image = Properties.Resources.paper_emoji;
                        break;
                    case "S":
                        pic.Image = Properties.Resources.scissors_blue;
                        break;

                }
            }
            else
            {
                switch (text)
                {
                    case "R":
                        pic.Image = Properties.Resources.rock_emoji;
                        break;
                    case "P":
                        pic.Image = Properties.Resources.paper_emoji;
                        break;
                    case "S":
                        pic.Image = Properties.Resources.scissors_pink;
                        break;

                }
            }



        }

        private void checkGame()
        {
            if (computerChoice == playerChoice)
            {
                draw = " Draw!";
                End end = new End();
                end.Show();
                Visible = false;
            }
            else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "P" && computerChoice == "S" || playerChoice == "S" && computerChoice == "R")
            {
                computerScore++;
                draw = null;
            }
            else
            {
                playerScore++;
                draw = null;
            }
            lblComputerResult.Text = "Computer Score" + computerScore;
            lblPlayerResult.Text = "Player Score" + playerScore;
            lblDraw.Text = draw;

            if (gameMode == "best of")
            {
                
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
