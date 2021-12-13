using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;

        string[] CPUchoiceList = { "kivi", "paber", "käärid","paber", "käärid", "kivi" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUChoice;

        string playerChoice;

        int playerScore;
        int CPUScore;

        public Form1()
        {
            InitializeComponent();

            countDownTimer.Enabled = true;

            playerChoice = "none";

            txtCountDown.Text = "5";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "kivi";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paber";
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "käärid";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            playerScore = 0;

            CPUScore = 0;

            rounds = 3;

            txtScore.Text = "Mängija: " + playerScore + " - " + "Bot: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;

            picCPU.Image = Properties.Resources.qq;

            gameOver = false;
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerPerRound -= 1;
            txtCountDown.Text = timerPerRound.ToString();
            txtRounds.Text = "Ümar: " + rounds;

            if (timerPerRound < 1)
            {
                countDownTimer.Enabled = false;

                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUChoice = CPUchoiceList[randomNumber];

                switch (CPUChoice)
                {
                    case "kivi":
                        picCPU.Image = Properties.Resources.rock;
                        break;

                    case "paber":
                        picCPU.Image = Properties.Resources.paper;
                        break;

                    case "käärid":
                        picCPU.Image = Properties.Resources.scissors;
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }

                else
                {
                    if (playerScore > CPUScore)
                    {
                        MessageBox.Show("Mängija võitis");
                    }
                    else
                    {
                        MessageBox.Show("Bot võitis");
                    }

                    gameOver = true;
                }
            }
        }

        private void checkGame()
        {
            if (playerChoice=="kivi" && CPUChoice=="paber")
            {
                CPUScore += 1;

                rounds -= 1;
                MessageBox.Show("Bot võitis, Paber mähib Kivi");
            }

            else if (playerChoice == "käärid" && CPUChoice == "kivi")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("Bot võitis, Kivi lõhub Käärid");
            }

            else if (playerChoice == "paber" && CPUChoice == "käärid")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("Bot võitis, Käärid lõikasid Paberit");
            }

            else if (playerChoice == "kivi" && CPUChoice == "käärid")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Mängija võidab, Kivi lõhub Käärid");
            }

            else if (playerChoice == "paber" && CPUChoice == "kivi")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Mängija võidab, Paber katab Kivi");
            }

            else if (playerChoice == "käärid" && CPUChoice == "paber")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Mängija võidab, Käärid lõikavad Paberit");
            }

            else if (playerChoice == "none")
            {
                MessageBox.Show("Otsust langetama");
            }
            else
            {
                MessageBox.Show("Viik");
            }

            startNextRound();
        }

        private void startNextRound()
        {
            if (gameOver==true)
            {
                return;
            }

            txtScore.Text = "Mängija: " + playerScore + " - " + "Bot: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;

            picCPU.Image = Properties.Resources.qq;
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules help = new Rules();
            help.Show();
        }
    }
}
