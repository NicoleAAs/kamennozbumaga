using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kamennozbumaga
{
    public partial class Form1 : Form
    {
        
        string Computer;
        string[] computer = { "Rock", "Paper", "Scissors" };
        Random random = new Random();
        int RandomType;
        string PlayerPicks;

        public Form1()
        {
            InitializeComponent();
        }

        private void StoneButton_Click(object sender, EventArgs e)
        {
            PlayerPicks = "Rock";
            RandomType = random.Next(0, 3);
            Computer = computer[RandomType];
            Game();
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            PlayerPicks = "Paper";
            RandomType = random.Next(0, 3);
            Computer = computer[RandomType];
            Game();
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            PlayerPicks = "Scissors";
            RandomType = random.Next(0, 3);
            Computer = computer[RandomType];
            Game();
        }

        void Game()
        {
            string message = "Võitja on: ";
            string computerWins = "Arvuti!";
            string playerWins = "Mängija!";
            string draw = "Mitte keegi?";


            if (PlayerPicks == "Rock" && Computer == "Paper") // mängija: kivi, Arvuti: paber = Arvuti võidab
            {
                MessageBox.Show(message + computerWins);
            }
            else if (PlayerPicks == "Rock" && Computer == "Scissors") // mängija: kivi, Arvuti: Käärid = Arvuti võidab
            {
                MessageBox.Show(message + playerWins);

            }
            else if (PlayerPicks == "Paper" && Computer == "Scissors") // mängija: PAber, Arvuti: Käärid = Arvuti võidab
            {
                MessageBox.Show(message + computerWins);

            }
            else if (PlayerPicks == "Paper" && Computer == "Rock") // mängija: Paber, Arvuti: kivi = mängija võidab
            {
                MessageBox.Show(message + playerWins);

            }
            else if (PlayerPicks == "Scissors" && Computer == "Rock") // mängija: Käärid, Arvuti: kivi = Arvuti võidab
            {
                MessageBox.Show(message + computerWins);

            }
            else if (PlayerPicks == "Scissors" && Computer == "Paper") // mängija: Käärid, Arvuti: Paber = Maängija võidab
            {
                MessageBox.Show(message + playerWins);

            }
            if (PlayerPicks == "Scissors" && Computer == "Scissors") // mängija: Käärid, Arvuti Scissors = Viik
            {
                MessageBox.Show(message + draw);

            }
            if (PlayerPicks == "Paper" && Computer == "Paper")// mängija: Käärid, Arvuti Scissors = Viik
            {
                MessageBox.Show(message + draw);
            }
            if (PlayerPicks == "Rock" && Computer == "Rock")
            {
                MessageBox.Show(message + draw);
            }
            if (PlayerPicks == "Scissros" && Computer == "Scissors")// mängija: Käärid, Arvuti Scissors = Viik
            {
                MessageBox.Show(message + draw);
            }
            private void playerswWins_Click(object sender, EventArgs e)
            {
                if (PlayerPicks > Computer)
                {
                    PlayerPicks = Computer + " Wins the game";
                }
                else
                {
                    PlayerPicks = "Win";
                }
            }
        }

       
    }
}
