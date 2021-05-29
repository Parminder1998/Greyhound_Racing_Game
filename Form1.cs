using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greyhound_Racing_Game
{
    public partial class Form1 : Form
    {  
        Punter[] myPunters = new Punter[3];  //Punter clas hold all the details of player and update 
       
        Dogs[] DogsArray = new Dogs[4]; // Dog class hold all the code of 4 dogs running randomly

        public Form1()
        {
            InitializeComponent();
            DogsRace();
            Punters();
            LabelsClear();
        }
        public void LabelsClear() // Clear all labels
        {
            lblParminder.Text = "";
            lblJashan.Text = "";
            lblJaskaran.Text = "";
        }
        public void Punters()
        {
            //create an array of punters and instantiate factory class
            for (int i = 0; i < 3; i++)
            {
                myPunters[i] = Factory.Punterdata(i);
            }

            //set the labels to the classes and update
            myPunters[0].MyLabel = lblParminder;
            myPunters[0].MyRadioButton = rbParmindeer;
            myPunters[0].MyRadioButton.Text = myPunters[0].Name + " has $" + myPunters[0].Cash;
            myPunters[1].MyLabel = lblJaskaran;
            myPunters[1].MyRadioButton = rbJaskaran;
            myPunters[1].MyRadioButton.Text = myPunters[1].Name + " has $" + myPunters[1].Cash;
            myPunters[2].MyLabel = lblJashan;
            myPunters[2].MyRadioButton = rbJashan;
            myPunters[2].MyRadioButton.Text = myPunters[2].Name + " has $" + myPunters[2].Cash;

        }
        public void GameOverCheck() // Checks to see if the game is over and close game
        {
            if (myPunters[0].Cash <= 0 && myPunters[1].Cash <= 0 && myPunters[2].Cash <= 0)
            {
                MessageBox.Show("Congratulations, all of your bettors are broke! Try Again :D");
                LabelsClear();
                ResetRace();
                this.Close();
            }

        }
        public void BettorBroke() // Checks to see if anyone is broke and cannot continue and update label and blank out radio button
        {
            if (myPunters[0].Cash <= 0) // player Parminder 
            {
                lblParminder.Text = "Parminder is now broke and cannot continue betting";
                rbParmindeer.Enabled = false;
            }
            if (myPunters[1].Cash <= 0)//player   jaskaran
            {
                lblJaskaran.Text = "Jaskaran is now broke and cannot continue betting";
                rbJaskaran.Enabled = false;
            }
            if (myPunters[2].Cash <= 0)// player jashan
            {
                lblJashan.Text = "Jashan is now broke and cannot continue betting";
                rbJashan.Enabled = false;
            }
        }

        public void ResetBetAmount() // Reset the bet amounts to zero if the punter is busted
        {
            if (myPunters[0].Cash == 0)
            {
                myPunters[0].myBet.Amount = 0;
            }
            if (myPunters[1].Cash == 0)
            {
                myPunters[1].myBet.Amount = 0;
            }
            if (myPunters[2].Cash == 0)
            {
                myPunters[2].myBet.Amount = 0;
            }
        }
        public void DogsRace() // Instantiate the Dogs
        {
            DogsArray[0] = new Dogs { MyPictureBox = pbDog1, StartingPosition = pbDog1.Left, DogName = "#1", RaceTrackLength = pbRaceTrack.Width - pbDog1.Width, Randomiser = new Random() };
            DogsArray[1] = new Dogs { MyPictureBox = pbDog2, StartingPosition = pbDog2.Left, DogName = "#2", RaceTrackLength = pbRaceTrack.Width - pbDog2.Width, Randomiser = DogsArray[0].Randomiser };
            DogsArray[2] = new Dogs { MyPictureBox = pbDog3, StartingPosition = pbDog3.Left, DogName = "#3", RaceTrackLength = pbRaceTrack.Width - pbDog3.Width, Randomiser = DogsArray[0].Randomiser };
            DogsArray[3] = new Dogs { MyPictureBox = pbDog4, StartingPosition = pbDog4.Left, DogName = "#4", RaceTrackLength = pbRaceTrack.Width - pbDog4.Width, Randomiser = DogsArray[0].Randomiser };
        }
        private void btnRace_Click(object sender, EventArgs e)
        {
            //Check to see if the punters have enough money to proceed with the race and provide warning if not
            if (myPunters[0].Cash < udBoxBet.Value && rbParmindeer.Enabled)
            {
                MessageBox.Show("Sorry but Parminder does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            if (myPunters[1].Cash < udBoxBet.Value && rbJaskaran.Enabled)
            {
                MessageBox.Show("Sorry but Jaskaran does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            if (myPunters[2].Cash < udBoxBet.Value && rbJashan.Enabled)
            {
                MessageBox.Show("Sorry but Jashan does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            else
            {
                //Reset starting positions
                foreach (Dogs t in DogsArray)
                {
                    t.MyPictureBox.Left = t.StartingPosition;
                }

                // Start the timer for the race
                timer1.Enabled = true;
                btnRace.Enabled = false; // Disable the race button
            }

        }

        private void btnBet_Click(object sender, EventArgs e)
        {

            int punter = 0;

            if (rbParmindeer.Checked)
            {
                punter = 0;
            }
            else if (rbJaskaran.Checked)
            {
                punter = 1;
            }
            else if (rbJashan.Checked)
            {
                punter = 2;
            }

            myPunters[punter].PlaceBet((int)udBoxBet.Value, (int)udBoxDog.Value - 1); // Updates the bet amount and Dog # using the Placebet.Punter class with Form designer details

        }

        private void rbParmindeer_CheckedChanged(object sender, EventArgs e)
        {

            //Show that Parminder is betting in the bettor label
            lblBettor.Text = myPunters[0].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[0].Cash;
        }

        private void rbJaskaran_CheckedChanged(object sender, EventArgs e)
        {
            //Show that Jaskaran is betting in the bettor label
            lblBettor.Text = myPunters[1].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[1].Cash;
        }

        private void rbJashan_CheckedChanged(object sender, EventArgs e)
        {
            //Show that Jashan is betting in the bettor label
            lblBettor.Text = myPunters[2].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[2].Cash;
        }

        public void ResetRace() // Reset Dog positions back to start
        {
            // Reset the label text
            myPunters[0].MyLabel.ResetText();
            myPunters[1].MyLabel.ResetText();
            myPunters[2].MyLabel.ResetText();
            //Reset the bet amounts to zero
            myPunters[0].myBet.Amount = 0;
            myPunters[1].myBet.Amount = 0;
            myPunters[2].myBet.Amount = 0;

            foreach (Dogs t in DogsArray)
            {
                t.MyPictureBox.Left = t.StartingPosition;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Run the timer event for the race and return the winner and bet results
            // If no bet is placed then return warning message and try again
            try
            {
                int winner;

                for (int i = 0; i < DogsArray.Length; i++)
                {
                    if (DogsArray[i].Run(pbRaceTrack)) // use Dog.Run class for race and if true return a winner and stop timer event
                    {
                        winner = i;
                        timer1.Enabled = false;
                        MessageBox.Show("Dog #" + (winner + 1) + " Wins!");

                        for (int j = 0; j < myPunters.Length; j++)
                        {
                            if (myPunters[j].myBet.PayOut(winner) != 0) // if punters payout is not 0
                                myPunters[j].Cash += myPunters[j].myBet.PayOut(winner); // Update punters cash with the bet payout amount
                            myPunters[j].MyRadioButton.Text = myPunters[j].Name + " has $" + myPunters[j].Cash; // Updates the radio button text with new cash value
                        }

                        ResetRace(); // Resets the starting positions, bet amounts, and labels
                        ResetBetAmount(); // Reset bet amounts if bettor is bust
                        BettorBroke(); // Checks to see if anyone is bust and blank them out
                        GameOverCheck(); // Checks to see if the game is over and close if true

                        break;

                    }

                }

            }

            catch
            {
                MessageBox.Show("A bet was not placed, you could have won some coin.");
            }
        }

        private void btnLockIn_Click(object sender, EventArgs e)
        {

            try
            {
                if (myPunters[0].Cash < myPunters[0].myBet.Amount)
                {
                    MessageBox.Show("Busted  Parminder does not have enough money to Spend");
                    btnRace.Enabled = false;
                }
                if (myPunters[1].Cash < myPunters[1].myBet.Amount)
                {
                    MessageBox.Show("Busted  Jaskaran does not have enough money to Spend");
                    btnRace.Enabled = false;
                }
                if (myPunters[2].Cash < myPunters[2].myBet.Amount)
                {
                    MessageBox.Show("Busted  Jashan does not have enough money to Spend");
                    btnRace.Enabled = false;
                }
                else
                {
                    btnRace.Enabled = true;
                }
            }

            catch
            {
                MessageBox.Show("Please place all bets");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblParminder_Click(object sender, EventArgs e)
        {

        }
    }
}
