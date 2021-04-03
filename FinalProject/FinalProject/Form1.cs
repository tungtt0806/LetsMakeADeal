using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class makeDealForm : Form
    {
        public string[] trash_prizes = {"a candy", "a penny", "a trash bag", "an old shirt", "a coke bottle", "a cotton swabs", "a dried flower", "a broken mouse", "air", "fake jean"};
        public string[] medium_prizes = {"a TV Sony", "$200", "a perfume bottle", "a speaker", "a pair of Nike sneaker", "a monitor", "a CPU", "a GPU", "a washing machine", "a fryer"};
        public string[] amazing_prizes = {"a Lamborghini car", "a house", "$1 million", "a yatch", "a RV", "a 10 Carat diamond ring", "1000 Amazon shares", "a plane", "an island", "$100 million"};
        public int[] door = { 1, 2, 3 };
        public int randomDoor;
        public int randomPrize1, randomPrize2, randomPrize3;
        public bool choice = true;
        public static Random r = new Random();
        public static Random d = new Random();
        public bool door1WasClicked = false;
        public bool door2WasClicked = false;
        public bool door3WasClicked = false;

        public makeDealForm()
        {
            InitializeComponent();
            randomDoor = d.Next(0, 3);
            randomPrize1 = r.Next(0, trash_prizes.Length);
            randomPrize2 = r.Next(0, medium_prizes.Length);
            randomPrize3 = r.Next(0, amazing_prizes.Length);
            choiceButton.Enabled = false;
        }


        public void Door1_Click(object sender, EventArgs e)
        {
            choiceButton.Enabled = true;
            door1WasClicked = true;
            if (choice)
            {
                door1.Tag = randomDoor;
                if(randomDoor == 0)
                {
                    door2.Tag = 1;
                    door3.Tag = 2;
                    door1.Text = trash_prizes[randomPrize1];
                    rewardLabel.Text = "You won " + trash_prizes[randomPrize1] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door1.Enabled = false;
                    door2.Enabled = false;
                    door3.Enabled = false;
                }
                else if(randomDoor == 1)
                {
                    door2.Tag = 0;
                    door3.Tag = 2;
                    door1.Text = medium_prizes[randomPrize2];
                    rewardLabel.Text = "You won " + medium_prizes[randomPrize2] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door1.Enabled = false;
                    door2.Enabled = false;
                    door3.Enabled = false;
                }
                else
                {
                    door2.Tag = 1;
                    door3.Tag = 0;
                    door1.Text = amazing_prizes[randomPrize3];
                    rewardLabel.Text = "You won " + amazing_prizes[randomPrize3] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door1.Enabled = false;
                    door2.Enabled = false;
                    door3.Enabled = false;
                }
            }
        }

        private void Door2_Click(object sender, EventArgs e)
        {
            choiceButton.Enabled = true;
            door2WasClicked = true;
            if (choice)
            {
                door2.Tag = randomDoor;
                if (randomDoor == 0)
                {
                    door1.Tag = 2;
                    door3.Tag = 1;
                    door2.Text = trash_prizes[randomPrize1];
                    rewardLabel.Text = "You won "+ trash_prizes[randomPrize1] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door2.Enabled = false;
                    door1.Enabled = false;
                    door3.Enabled = false;
                }
                else if (randomDoor == 1)
                {
                    door1.Tag = 0;
                    door3.Tag = 2;
                    door2.Text = medium_prizes[randomPrize2];
                    rewardLabel.Text = "You won " + medium_prizes[randomPrize2] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door2.Enabled = false;
                    door1.Enabled = false;
                    door3.Enabled = false;
                }
                else
                {
                    door1.Tag = 1;
                    door3.Tag = 0;
                    door2.Text = amazing_prizes[randomPrize3];
                    rewardLabel.Text = "You won " + amazing_prizes[randomPrize3] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door2.Enabled = false;
                    door1.Enabled = false;
                    door3.Enabled = false;
                }
            }
        }

        private void Door3_Click(object sender, EventArgs e)
        {
            choiceButton.Enabled = true;
            door3WasClicked = true;
            if (choice)
            {
                door3.Tag = randomDoor;
                if (randomDoor == 0)
                {
                    door1.Tag = 2;
                    door2.Tag = 1;
                    door3.Text = trash_prizes[randomPrize1];
                    rewardLabel.Text = "You won " + trash_prizes[randomPrize1] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door3.Enabled = false;
                    door2.Enabled = false;
                    door1.Enabled = false;
                }
                else if (randomDoor == 1)
                {
                    door1.Tag = 0;
                    door2.Tag = 2;
                    door3.Text = medium_prizes[randomPrize2];
                    rewardLabel.Text = "You won " + medium_prizes[randomPrize2] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door3.Enabled = false;
                    door2.Enabled = false;
                    door1.Enabled = false;
                }
                else
                {
                    door1.Tag = 1;
                    door2.Tag = 0;
                    door3.Text = amazing_prizes[randomPrize3];
                    rewardLabel.Text = "You won " + amazing_prizes[randomPrize3] + "." + "You can change doors now or get the prize!";
                    rewardLabel.BackColor = Color.LightCyan;
                    door3.Enabled = false;
                    door2.Enabled = false;
                    door1.Enabled = false;
                }
            }
        }


        private void ChoiceButton_Click(object sender, EventArgs e)
        {
            
                Random r = new Random();
                Random d = new Random();
                randomDoor = d.Next(0, 3);
                randomPrize1 = r.Next(0, trash_prizes.Length);
                randomPrize2 = r.Next(0, medium_prizes.Length);
                randomPrize3 = r.Next(0, amazing_prizes.Length);
                choiceButton.Enabled = false;
                rewardLabel.Text = String.Empty;
                rewardLabel.BackColor = Color.Empty;
                if (door1WasClicked)
                {
                    door2.Enabled = true;
                    door3.Enabled = true;
                    choiceButton.Enabled = false;
                    if (door2WasClicked)
                    {
                        door2.Text = medium_prizes[randomPrize2];
                        rewardLabel.Text = "Congratulation! You won " + amazing_prizes[randomPrize2] + ".";
                        choiceButton.Enabled = false;
                        door3.Text = amazing_prizes[randomPrize3];
                        door2.Enabled = false;
                        door3.Enabled = false;
                    }
                    if (door3WasClicked)
                    {
                        door3.Text = amazing_prizes[randomPrize3];
                        rewardLabel.Text = "Congratulation! You won " + amazing_prizes[randomPrize3] + ".";
                        choiceButton.Enabled = false;
                        door2.Text = medium_prizes[randomPrize2];
                        door2.Enabled = false;
                        door3.Enabled = false;
                    }
                }
                else if (door2WasClicked)
                {
                    door1.Enabled = true;
                    door3.Enabled = true;
                    choiceButton.Enabled = false;
                    if (door1WasClicked)
                    {
                        door1.Text = medium_prizes[randomPrize2];
                        rewardLabel.Text = "Congratulation! You won " + amazing_prizes[randomPrize2] + ".";
                        choiceButton.Enabled = false;
                        door3.Text = amazing_prizes[randomPrize3];
                        door2.Enabled = false;
                        door3.Enabled = false;
                    }
                    if (door3WasClicked)
                    {
                        door3.Text = trash_prizes[randomPrize1];
                        rewardLabel.Text = "Congratulation! You won " + trash_prizes[randomPrize1] + ".";
                        choiceButton.Enabled = false;
                        door1.Text = medium_prizes[randomPrize2];
                        door1.Enabled = false;
                        door3.Enabled = false;
                    }
                }
                else if (door3WasClicked)
                {
                    door1.Enabled = true;
                    door2.Enabled = true;
                    choiceButton.Enabled = false;
                    if (door2WasClicked)
                    {
                        door2.Text = amazing_prizes[randomPrize3];
                        rewardLabel.Text = "Congratulation! You won " + amazing_prizes[randomPrize3] + ".";
                        choiceButton.Enabled = false;
                        door1.Text = medium_prizes[randomPrize2];
                        door2.Enabled = false;
                        door1.Enabled = false;
                    }
                    if (door1WasClicked)
                    {
                        door1.Text = trash_prizes[randomPrize1];
                        rewardLabel.Text = "Congratulation! You won " + trash_prizes[randomPrize1] + ".";
                        choiceButton.Enabled = false;
                        door2.Text = medium_prizes[randomPrize2];
                        door2.Enabled = false;
                        door1.Enabled = false;
                    }
                }
            

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Random d = new Random();
            randomDoor = d.Next(0, 3);
            randomPrize1 = r.Next(0, trash_prizes.Length);
            randomPrize2 = r.Next(0, medium_prizes.Length);
            randomPrize3 = r.Next(0, amazing_prizes.Length);
            door1.Text = "Door 1";
            door2.Text = "Door 2";
            door3.Text = "Door 3";
            rewardLabel.Text = String.Empty;
            rewardLabel.BackColor = Color.Empty;
            door1.Enabled = true;
            door2.Enabled = true;
            door3.Enabled = true;
            door1WasClicked = false;
            door2WasClicked = false;
            door3WasClicked = false;
        }

    }
}
//That Tung Ton