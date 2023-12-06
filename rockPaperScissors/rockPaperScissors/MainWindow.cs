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
        int bestOf = 0;
        string draw;
        string gameMode;

        public MainWindow(string gameMode)
        {
            InitializeComponent();
            this.gameMode = gameMode;
        }
        public MainWindow(string gameMode, int bestOf)
        {
            InitializeComponent();
            this.gameMode = gameMode;
            this.bestOf = bestOf;
        }

       
        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            PictureBox tempButton = sender as PictureBox;

            playerChoice = (string)tempButton.Tag;

            int i = random.Next(0, options.Length);

            computerChoice = options[i];

            updateTextAndImage(playerChoice, PLAYER_PIC);
            updateTextAndImage(computerChoice,CPU_PIC);
            
        }
        private void updateTextAndImage(String text, PictureBox pic)
        {
            
            if (pic == PLAYER_PIC)
            {
               animateHandBlue(text, pic);
            }
            else
            {
                animateHandRed(text, pic);
            }



        }

        private void animateHandRed(string text, PictureBox pic)
        {
            List<Image> animationImages = new List<Image>
    {
        Properties.Resources.rock_red_final_top,
        Properties.Resources.rock_red_final,
        Properties.Resources.rock_red_final_top,
        Properties.Resources.rock_red_final,
        Properties.Resources.rock_red_final_top,
        Properties.Resources.rock_red_final
    };

            int currentIndex = 0;

            Timer animationTimer = new Timer();
            animationTimer.Interval = 250; // Set the interval to 250 milliseconds (.25 second)
            animationTimer.Tick += (sender, e) =>
            {
                // Display the current animation image
                pic.Image = animationImages[currentIndex];

                currentIndex++;

                // If reached the end of the animation, stop the timer
                if (currentIndex >= animationImages.Count)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();

                    // Set the final image based on the player's choice
                    switch (text)
                    {
                        case "R":
                            pic.Image = Properties.Resources.rock_red_final;
                            break;
                        case "P":
                            pic.Image = Properties.Resources.paper_red_final;
                            break;
                        case "S":
                            pic.Image = Properties.Resources.scissor_red_final;
                            break;
                    }

                    
                }
            };

            // Start the timer
            animationTimer.Start();
        }

        private void animateHandBlue(string text, PictureBox pic)
        {
            List<Image> animationImages = new List<Image>
    {
        Properties.Resources.rock_blue_final_top,
        Properties.Resources.rock_blue_final,
        Properties.Resources.rock_blue_final_top,
        Properties.Resources.rock_blue_final,
        Properties.Resources.rock_blue_final_top,
        Properties.Resources.rock_blue_final
    };

            int currentIndex = 0;

            Timer animationTimer = new Timer();
            animationTimer.Interval = 250; // Set the interval to 250 milliseconds (.25 second)
            animationTimer.Tick += (sender, e) =>
            {
                // Display the current animation image
                pic.Image = animationImages[currentIndex];

                currentIndex++;

                // If reached the end of the animation, stop the timer
                if (currentIndex >= animationImages.Count)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();

                    // Set the final image based on the player's choice
                    switch (text)
                    {
                        case "R":
                            pic.Image = Properties.Resources.rock_blue_final;
                            break;
                        case "P":
                            pic.Image = Properties.Resources.paper_blue_final;
                            break;
                        case "S":
                            pic.Image = Properties.Resources.scissor_blue_final;
                            break;
                    }

                    checkGame();
                }
            };

            // Start the timer
            animationTimer.Start();
        }


        private void checkGame()
        {
            if (computerChoice == playerChoice)
            {
                draw = " Draw!";
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
            lblComputerResult.Text = "" + computerScore;
            lblPlayerResult.Text = "" + playerScore;
            lblDraw.Text = draw;

            if (gameMode == "bestOf")
            {
                string result = "";
                if (bestOf == 5)
                {
                    if(playerScore == 5)
                    {

                        executeAfterTimeWin(result);
                    } 
                    else if (computerScore == 5)
                    {
                        executeAfterTimeLose(result);
                    }
                } 
                else if (bestOf == 10)
                {
                    if (playerScore == 10)
                    {
                        executeAfterTimeWin(result);
                    }
                    else if (computerScore == 10)
                    {
                        executeAfterTimeLose(result);
                    }
                } 
                else if (bestOf == 20)
                {
                    if (playerScore == 20)
                    {
                        executeAfterTimeWin(result);
                    }
                    else if (computerScore == 20)
                    {
                        executeAfterTimeLose(result);
                    }
                }
            }
           
        }
        private void executeAfterTimeWin(string result)
        {
            Timer delayTimer = new Timer();
            delayTimer.Interval = 500; // 2000 milliseconds = 2 seconds
            delayTimer.Tick += (sender, e) =>
            {
                delayTimer.Stop(); // Stop the timer
                                   // Code to execute after the 2-second delay
                result = "win";
                End end = new End(result);
                end.Show();
                Visible = false;
            };

            delayTimer.Start(); // Start the timer
        }
        
        private void executeAfterTimeLose(string result)
        {
            Timer delayTimer = new Timer();
            delayTimer.Interval = 500; // 2000 milliseconds = 2 seconds
            delayTimer.Tick += (sender, e) =>
            {
                delayTimer.Stop(); // Stop the timer
                                   // Code to execute after the 2-second delay
                result = "lose";
                End end = new End(result);
                end.Show();
                Visible = false;
            };

            delayTimer.Start(); // Start the timer
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeGameMode_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            int continueMusic = 1;
            Start start = new Start(continueMusic);
            start.Show();
            Visible = false;
        }

        private void CPU_PIC_Click(object sender, EventArgs e)
        {

        }
    }
}
