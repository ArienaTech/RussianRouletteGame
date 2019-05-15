using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteAssignment1
{
    public partial class GameMain : Form
    {
        public GameMain(string player_name)
        {
            InitializeComponent();
            Label_player.Text = "Player: " + player_name;
        }
        Random rnd = new Random(); //random chamber for bullet
        Random r = new Random(); //random location for timer_gun 
        int playerChamber;
        int[] playerGun = new int[7] { 0, 0, 0, 0, 0, 0, 0 }; //Give extra chamber to prevent error in program
        int chamberPull = 0;
        int round = 0;
        int Shoot_away = 0;
        int total_score = 0;
        int x_Bullet = 275, y_Bullet = 118;

        private void GameMain_Load(object sender, EventArgs e)
        {
            Pic_blood.Hide(); Pic_Broken.Hide();
            Pic_smokeLeft.Hide(); Pic_smokeRight.Hide();
            Pic_GunSpin.Hide(); Gun_PointAway.Hide();
            timer_bullet.Stop(); timer_gun.Start();
            Pic_bulletLeft.Hide();

            GameSound music = new GameSound();
            music.background_music();
        }
        //Functions below:
        private void LoadChamber()
        {
            playerChamber = rnd.Next(1, 7); //This will give random chamber from 1 to 6

            /*Below is to check which chamber the bullet will land */ 
            //MessageBox.Show("Player chamber: " + playerChamber);   
        }
        private void SpinChamber()
        {
            playerGun[playerChamber] = 1;
        }
        private void Fn_Round()
        {
            round++;
            Label_round.Text = "Round " + round;
        }
        private void PointAway()
        {
            Fn_Round();
            chamberPull++;
        }
        private void Restart()
        {
            Application.ExitThread();
            Application.Restart();
        }
        //Calling functions into each buttons
        private void Btn_load_Click(object sender, EventArgs e)
        {
            GameSound loadsound = new GameSound();
            loadsound.load_sound();

            LoadChamber();        
        }
        private void Btn_spin_Click(object sender, EventArgs e)
        {
            GameSound spinsound = new GameSound();
            spinsound.spin_sound();
            Pic_GunSpin.Show();

            SpinChamber();

            if (playerChamber == 0)
            {
                MessageBox.Show("WARNING: There is no bullet in the chamber");
				chamberPull = 0;
				round = 0;
				Shoot_away = 0;
				total_score = 0;
			}
        }

        private void Btn_shootMe_Click(object sender, EventArgs e)
        {
            GameSound shotsound = new GameSound();
            shotsound.shot_sound();
            Pic_GunSpin.Hide(); Pic_smokeLeft.Show();
            Gun_PointAway.Hide(); Gun_PointHead.Show();
            Fn_Round();
            chamberPull++;

			if (playerChamber == 0)
			{
				chamberPull = 0;
				round = 0;
				Shoot_away = 0;
				total_score = 0;
				playerChamber = 0;

				MessageBox.Show("WARNING: There is no bullet in the chamber");
			}
			else if (playerGun[chamberPull] == 1)
            {
				timer_bullet.Start();

				GameSound girlScream = new GameSound();
				girlScream.girl_scream();
				Pic_blood.Show();

				MessageBox.Show("Ohhh nooo!! You're dead!\nBetter Lucks Next Time...\n\n***Restart Game***");
				Pic_smokeLeft.Hide();
				Restart();
            }
            else if (playerChamber != 0 && playerGun[chamberPull] != 1)
			    {
				total_score += 20;
				MessageBox.Show("You survived");
				Label_score.Text = "Total Score: " + total_score;
				Pic_smokeLeft.Hide();
			}
                if (round >= 6)
                {
                    GameSound girlOhYeah = new GameSound();
                    girlOhYeah.girl_OhYeah();
                    MessageBox.Show("YOU WON!!!\n\n***End Game***\n***Restart Game***");
                    Restart();
                }        
        }
        private void Btn_shootAway_Click(object sender, EventArgs e)
        {
            GameSound shotsound = new GameSound();
            shotsound.shot_sound();
            Pic_smokeLeft.Hide(); Pic_GunSpin.Hide();
            Gun_PointAway.Show(); Pic_smokeRight.Show();
            Pic_Broken.Show(); Gun_PointHead.Hide();
            PointAway();
            Shoot_away++;

                if (playerChamber == 0)
                {
                    MessageBox.Show("WARNING: There is no bullet in the chamber");

                }
                if (Shoot_away <= 2) //If shoot away is less or equal to 2
                {
                    total_score += 10;
                    MessageBox.Show("You survived");
                    Label_score.Text = "Total Score: " + total_score;
                    Pic_smokeRight.Hide();
                    Pic_Broken.Hide();
                }
                if (Shoot_away == 2) //If shoot away is equal to 2, this messsage will show
                {
                    MessageBox.Show("WARNING: If you shoot away more than 2 times - game will restart");
                    Pic_smokeRight.Hide();
                    Pic_Broken.Hide();
                }
                if (Shoot_away > 2 && playerGun[chamberPull] == 0) //Shoot Away more than 2 and bullet has not been fired
                {
                    MessageBox.Show("***Game Restart***\nYou shoot away more than 2 times and the bullet has not been fired...");

                    Restart();
                }
                if (round == 6) //if round is 6 
                {
                    GameSound girlOhYeah = new GameSound();
                    girlOhYeah.girl_OhYeah();
                    MessageBox.Show("YOU WON!!!\n\n***End Game***\n***Restart Game***");
                    Shoot_away = 0;
                    chamberPull++;

                    Restart();
                }
        }
        private void Btn_restart_Click(object sender, EventArgs e)
        {
            Restart();
        }
        private void timer_gun_Tick(object sender, EventArgs e) //Timer to make Gun move
        {
            int x, y;
            x = r.Next(318, 328);
            y = r.Next(106, 126);
            Gun_PointHead.Location = new Point(x, y);
        }
        private void timer_bullet_Tick(object sender, EventArgs e) //Bullet shoot to the left
        {
            Pic_bulletLeft.Show();
            x_Bullet -= 10;
            Pic_bulletLeft.Location = new Point(x_Bullet, y_Bullet);
        }
        private void timer_spin_Tick(object sender, EventArgs e)
        {
            Pic_GunSpin.Hide();
        }
        private void Label_toPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("***How to Play***\n\n1. Load the bullet\n2. Spin the chamber\n3. Press shoot me or shoot away\n\n" +
                "There are 1 in 6 chances the bullet is in the chamber.\n" +
                "You can shoot away 2 times during the game to avoid the bullet.\n\n" +
                "To win: you must survive all 6 rounds; each survived round is 20 points and 10 points when you shoot away.\n" +
                "The maximum points is 120 points.");
        }
    }
}
