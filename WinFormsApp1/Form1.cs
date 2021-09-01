using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Classes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //debug

        int framerateTicks = 0;

        //====

        //player 1 variables
        bool playerGoForward = false, playerGoBack = false;
        int playerPosition = 0;
        int playerSpeed = 3;
        int playerScore = 0;
        bool playerIsDead = false;


        //==BULLETS
        bool playerShoot = false;
        bool playerBullet1Shot = false, playerBullet2Shot = false, playerBullet3Shot = false;
        bool playerBullet1ShotEnable = true, playerBullet2ShotEnable = true, playerBullet3ShotEnable = true;
        int playerWhichBullet = 0;
        int playerBullet1Position, playerBullet2Position, playerBullet3Position;
        Point playerBulletNewLocation;
        bool playerReload = false;
  
        int playerReloadTime = 0;
        bool playerIsReloadStarted = false;



        //===========

        //player 2 variables

        bool player2GoForward = false, player2GoBack = false;
        int player2Position = 0;
        int player2Speed = 3;
        int player2Score = 0;
        bool player2IsDead = false;


        //==BULLETS
        bool player2Shoot = false;
        bool player2Bullet1Shot = false, player2Bullet2Shot = false, player2Bullet3Shot = false;
        bool player2Bullet1ShotEnable = true, player2Bullet2ShotEnable = true, player2Bullet3ShotEnable = true;

        int player2WhichBullet = 0;

        int player2Bullet1Position, player2Bullet2Position, player2Bullet3Position;
        Point player2BulletNewLocation;
        bool player2Reload = false;

        int player2ReloadTime = 0;
        bool player2IsReloadStarted = false;
        //===========

        public Form1()
        {
            InitializeComponent();
        }


        private void gameFramerate_Tick(object sender, EventArgs e)
        {
            framerateTicks++;


            interfacePlayerScore.Text = playerScore.ToString();
            interfacePlayer2Score.Text = player2Score.ToString();

            switch (playerPosition)
            {
                case 0:
                    player.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel_pos0;
                    break;
                case 1:
                    player.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel_pos1;
                    break;
                case 2:
                    player.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel_pos2;
                    break;
                case 3:
                    player.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel_pos3;
                    break;
            }
            switch (player2Position)
            {
                case 0:
                    player2.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel2_pos0;
                    break;
                case 1:
                    player2.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel2_pos1;
                    break;
                case 2:
                    player2.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel2_pos2;
                    break;
                case 3:
                    player2.BackgroundImage = WinFormsApp1.Properties.Resources.TankModel2_pos3;
                    break;
            }

//SAVING POSITION FOR COLISION WITCH WALLS BEFORE MOVEMENT

            int lastPlayerPositionTop = player.Top;
            int lastPlayerPositionLeft = player.Left;

            int lastPlayer2PositionTop = player2.Top;
            int lastPlayer2PositionLeft = player2.Left;


            //PLAYER1 movement
            switch (playerPosition)
            {
                case 0:
                    if (playerGoForward == true)
                        player.Top -= playerSpeed;
                    if (playerGoBack == true)
                        player.Top += playerSpeed;
                    break;
                case 1:
                    if (playerGoForward == true)
                        player.Left += playerSpeed;
                    if (playerGoBack == true)
                        player.Left -= playerSpeed;
                    break;
                case 2:
                    if (playerGoForward == true)
                        player.Top += playerSpeed;
                    if (playerGoBack == true)
                        player.Top -= playerSpeed;
                    break;
                case 3:
                    if (playerGoForward == true)
                        player.Left -= playerSpeed;
                    if (playerGoBack == true)
                        player.Left += playerSpeed;
                    break;
            }


//player2 movement


            switch (player2Position)
            {
                case 0:
                    if (player2GoForward == true)
                        player2.Top -= player2Speed;
                    if (player2GoBack == true)
                        player2.Top += player2Speed;
                    break;
                case 1:
                    if (player2GoForward == true)
                        player2.Left += player2Speed;
                    if (player2GoBack == true)
                        player2.Left -= player2Speed;
                    break;
                case 2:
                    if (player2GoForward == true)
                        player2.Top += player2Speed;
                    if (player2GoBack == true)
                        player2.Top -= player2Speed;
                    break;
                case 3:
                    if (player2GoForward == true)
                        player2.Left -= player2Speed;
                    if (player2GoBack == true)
                        player2.Left += player2Speed;
                    break;
            }



//COLISIONS=================================




            foreach (Control _wall in this.Controls)
            {
                if (_wall is PictureBox)
                {
                    if ((string)_wall.Tag == "wall")
                    {


//player1 bullet colision with wall

                        if (player.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            player.Top = lastPlayerPositionTop;
                            player.Left = lastPlayerPositionLeft;
                        }

                        if (playerBullet1.Bounds.IntersectsWith(_wall.Bounds))                        
                        {
                            playerBullet1.Visible = false;
                            playerBullet1Shot = false;
                            playerBullet1.Location = new Point (0,0);
                        }
                        if (playerBullet2.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            playerBullet2.Visible = false;
                            playerBullet2Shot = false;
                            playerBullet2.Location = new Point(0, 0);
                        }
                        if (playerBullet3.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            playerBullet3.Visible = false;
                            playerBullet3Shot = false;
                            playerBullet3.Location = new Point(0, 0);
                        }

//player2 bullet colision with wall

                        if (player2.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            player2.Top = lastPlayer2PositionTop;
                            player2.Left = lastPlayer2PositionLeft;
                        }

                        if (player2Bullet1.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            player2Bullet1.Visible = false;
                            player2Bullet1Shot = false;
                            player2Bullet1.Location = new Point(0, 0);
                        }
                        if (player2Bullet2.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            player2Bullet2.Visible = false;
                            player2Bullet2Shot = false;
                            player2Bullet2.Location = new Point(0, 0);
                        }
                        if (player2Bullet3.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            player2Bullet3.Visible = false;
                            player2Bullet3Shot = false;
                            player2Bullet3.Location = new Point(0, 0);
                        }
                    }
                }
            }


//colisions player1 with player2
            if (playerBullet1.Bounds.IntersectsWith(player2.Bounds))
            {
                playerBullet1.Visible = false;
                playerBullet1Shot = false;
                playerBullet1.Location = new Point(0, 0);
                player2.Location = new Point(4000,4000);
                player2IsDead = true;
                playerScore++;
            }
            if (playerBullet2.Bounds.IntersectsWith(player2.Bounds))
            {
                playerBullet2.Visible = false;
                playerBullet2Shot = false;
                playerBullet2.Location = new Point(0, 0);
                player2.Location = new Point(4000, 4000);
                player2IsDead = true;
                playerScore++;
            }
            if (playerBullet3.Bounds.IntersectsWith(player2.Bounds))
            {
                playerBullet3.Visible = false;
                playerBullet3Shot = false;
                playerBullet3.Location = new Point(0, 0);
                player2.Location = new Point(4000, 4000);
                player2IsDead = true;
                playerScore++;
            }



            if (player.Bounds.IntersectsWith(player2.Bounds))
            {
                player.Top = lastPlayerPositionTop;
                player.Left = lastPlayerPositionLeft;
            }



            //colisions player2 with player1


            if (player2Bullet1.Bounds.IntersectsWith(player.Bounds))
            {
                player2Bullet1.Visible = false;
                player2Bullet1Shot = false;
                player2Bullet1.Location = new Point(0, 0);
                player.Location = new Point(5000, 5000);
                playerIsDead = true;
                player2Score++;

            }
            if (player2Bullet2.Bounds.IntersectsWith(player.Bounds))
            {
                player2Bullet2.Visible = false;
                player2Bullet2Shot = false;
                player2Bullet2.Location = new Point(0, 0);
                player.Location = new Point(5000, 5000);
                playerIsDead = true;
                player2Score++;
            }
            if (player2Bullet3.Bounds.IntersectsWith(player.Bounds))
            {
                player2Bullet3.Visible = false;
                player2Bullet3Shot = false;
                player2Bullet3.Location = new Point(0, 0);
                player.Location = new Point(5000, 5000);
                playerIsDead = true;
                player2Score++;
            }



            if (player2.Bounds.IntersectsWith(player.Bounds))
            {
                player2.Top = lastPlayer2PositionTop;
                player2.Left = lastPlayer2PositionLeft;
            }

            //===========================================

            //SHOTING P1


            if (playerBullet1ShotEnable == false && playerBullet2ShotEnable == false && playerBullet3ShotEnable == false)
            {
                interfacePressR.Visible = true;
            }

            if (player2Bullet1ShotEnable == false && player2Bullet2ShotEnable == false && player2Bullet3ShotEnable == false)
            {
                interfacePress0.Visible = true;
            }


            if (playerShoot == true && (playerBullet1ShotEnable == true || playerBullet2ShotEnable == true || playerBullet3ShotEnable == true))
            {
                playerBulletNewLocation = new Point(player.Location.X + player.Size.Width/2 - playerBullet1.Size.Height/2, player.Location.Y + player.Size.Height/2 - playerBullet1.Size.Width / 2);

                switch (playerWhichBullet)
                {
                    case 0:
                        if (playerBullet1ShotEnable == true)
                        {
                            playerBullet1Position = playerPosition;
                            playerBullet1.Location = playerBulletNewLocation;
                            playerBullet1Shot = true;
                            playerBullet1.Visible = true;
                            playerBullet1ShotEnable = false;
                            interfacePlayerBullet1.Visible = false;
                        }
                        else playerWhichBullet++;
                        break;
                    case 1:
                        if (playerBullet2ShotEnable == true)
                        {
                        playerBullet2Position = playerPosition;
                        playerBullet2.Location = playerBulletNewLocation;
                        playerBullet2Shot = true;
                        playerBullet2.Visible = true;
                        playerBullet2ShotEnable = false;
                            interfacePlayerBullet2.Visible = false;
                        }
                        else playerWhichBullet++;
                        break;
                    case 2:
                        if (playerBullet3ShotEnable == true)
                        {
                        playerBullet3Position = playerPosition;
                        playerBullet3.Location = playerBulletNewLocation;
                        playerBullet3Shot = true;
                        playerBullet3.Visible = true;
                        playerBullet3ShotEnable = false;
                        interfacePlayerBullet3.Visible = false;
                        }
                        else playerWhichBullet++;
                        break;
                    default:
                        break;
                }
                playerWhichBullet++;
                if (playerWhichBullet > 2) playerWhichBullet = 0;
                playerShoot = false;

            }


            //=================

            if (player2Shoot == true && (player2Bullet1ShotEnable == true || player2Bullet2ShotEnable == true || player2Bullet3ShotEnable == true))
            {
                player2BulletNewLocation = new Point(player2.Location.X + player2.Size.Width / 2 - player2Bullet1.Size.Height / 2, player2.Location.Y + player2.Size.Height / 2 - player2Bullet1.Size.Width / 2);

                switch (player2WhichBullet)
                {
                    case 0:
                        if (player2Bullet1ShotEnable == true)
                        {
                            player2Bullet1Position = player2Position;
                            player2Bullet1.Location = player2BulletNewLocation;
                            player2Bullet1Shot = true;
                            player2Bullet1.Visible = true;
                            player2Bullet1ShotEnable = false;
                            interfacePlayer2Bullet1.Visible = false;
                        }
                        else player2WhichBullet++;
                        break;
                    case 1:
                        if (player2Bullet2ShotEnable == true)
                        {
                            player2Bullet2Position = player2Position;
                            player2Bullet2.Location = player2BulletNewLocation;
                            player2Bullet2Shot = true;
                            player2Bullet2.Visible = true;
                            player2Bullet2ShotEnable = false;
                            interfacePlayer2Bullet2.Visible = false;
                        }
                        else player2WhichBullet++;
                        break;
                    case 2:
                        if (player2Bullet3ShotEnable == true)
                        {
                            player2Bullet3Position = player2Position;
                            player2Bullet3.Location = player2BulletNewLocation;
                            player2Bullet3Shot = true;
                            player2Bullet3.Visible = true;
                            player2Bullet3ShotEnable = false;
                            interfacePlayer2Bullet3.Visible = false;
                        }
                        else player2WhichBullet++;
                        break;
                    default:
                        break;
                }
                player2WhichBullet++;
                if (player2WhichBullet > 2) player2WhichBullet = 0;
                player2Shoot = false;

            }


            //=================

            //RELOAD P1

            if (playerReload == true && playerBullet1ShotEnable== false && playerBullet2ShotEnable == false && playerBullet3ShotEnable == false)
            {
                interfacePressR.Visible = false;
                interfacePlayerReloading.Visible = true;
                if (playerIsReloadStarted == false)
                {
                    playerReloadTime = 0;
                    playerIsReloadStarted = true;
                    relodeTimerPlayer1.Enabled = Enabled;
                }

                if (playerReloadTime == 3)
                {
                    playerBullet1ShotEnable = true;
                    playerBullet2ShotEnable = true;
                    playerBullet3ShotEnable = true;
                    playerReload = false;
                    playerReloadTime = 0;
                    relodeTimerPlayer1.Enabled = false;
                    playerIsReloadStarted = false;
                    interfacePlayerBullet1.Visible = true;
                    interfacePlayerBullet2.Visible = true;
                    interfacePlayerBullet3.Visible = true;
                    interfacePlayerReloading.Visible = false;
                }
            }
            //=================

            if (player2Reload == true && player2Bullet1ShotEnable == false && player2Bullet2ShotEnable == false && player2Bullet3ShotEnable == false)
            {
                interfacePress0.Visible = false;
                interfacePlayer2Reloading.Visible = true;
                if (player2IsReloadStarted == false)
                {
                    player2ReloadTime = 0;
                    player2IsReloadStarted = true;
                    relodeTimerPlayer2.Enabled = Enabled;
                }

                if (player2ReloadTime == 3)
                {
                    player2Bullet1ShotEnable = true;
                    player2Bullet2ShotEnable = true;
                    player2Bullet3ShotEnable = true;
                    player2Reload = false;
                    player2ReloadTime = 0;
                    relodeTimerPlayer2.Enabled = false;
                    player2IsReloadStarted = false;
                    interfacePlayer2Bullet1.Visible = true;
                    interfacePlayer2Bullet2.Visible = true;
                    interfacePlayer2Bullet3.Visible = true;
                    interfacePlayer2Reloading.Visible = false;
                }
            }

            //=================


            //player1 bullet shot
            if (playerBullet1Shot == true)
            {
                switch (playerBullet1Position)
                {
                    case 0:
                        playerBullet1.Top -= 5;
                        break;
                    case 1:
                        playerBullet1.Left += 5;
                        break;
                    case 2:
                        playerBullet1.Top += 5;
                        break;
                    case 3:
                        playerBullet1.Left -= 5;
                        break;
                    default:
                        break;
                }
            }

            if (playerBullet2Shot == true)
            {
                switch (playerBullet2Position)
                {
                    case 0:
                        playerBullet2.Top -= 5;
                        break;
                    case 1:
                        playerBullet2.Left += 5;
                        break;
                    case 2:
                        playerBullet2.Top += 5;
                        break;
                    case 3:
                        playerBullet2.Left -= 5;
                        break;
                    default:
                        break;
                }
            }

            if (playerBullet3Shot == true)
            {
                switch (playerBullet3Position)
                {
                    case 0:
                        playerBullet3.Top -= 5;
                        break;
                    case 1:
                        playerBullet3.Left += 5;
                        break;
                    case 2:
                        playerBullet3.Top += 5;
                        break;
                    case 3:
                        playerBullet3.Left -= 5;
                        break;
                    default:
                        break;
                }
            }


//player2 bullet shot

            if (player2Bullet1Shot == true)
            {
                switch (player2Bullet1Position)
                {
                    case 0:
                        player2Bullet1.Top -= 5;
                        break;
                    case 1:
                        player2Bullet1.Left += 5;
                        break;
                    case 2:
                        player2Bullet1.Top += 5;
                        break;
                    case 3:
                        player2Bullet1.Left -= 5;
                        break;
                    default:
                        break;
                }
            }

            if (player2Bullet2Shot == true)
            {
                switch (player2Bullet2Position)
                {
                    case 0:
                        player2Bullet2.Top -= 5;
                        break;
                    case 1:
                        player2Bullet2.Left += 5;
                        break;
                    case 2:
                        player2Bullet2.Top += 5;
                        break;
                    case 3:
                        player2Bullet2.Left -= 5;
                        break;
                    default:
                        break;
                }
            }

            if (player2Bullet3Shot == true)
            {
                switch (player2Bullet3Position)
                {
                    case 0:
                        player2Bullet3.Top -= 5;
                        break;
                    case 1:
                        player2Bullet3.Left += 5;
                        break;
                    case 2:
                        player2Bullet3.Top += 5;
                        break;
                    case 3:
                        player2Bullet3.Left -= 5;
                        break;
                    default:
                        break;
                }
            }

//RESPAWNING
            if (playerIsDead==true)
            {
                Random rng = new Random();

                switch (rng.Next(4)+1)
                {
                    case 1:
                        player.Location = spawner1.Location;
                        playerIsDead = false;
                        break;
                    case 2:
                        player.Location = spawner2.Location;
                        playerIsDead = false;
                        break;
                    case 3:
                        player.Location = spawner3.Location;
                        playerIsDead = false;
                        break;
                    case 4:
                        player.Location = spawner4.Location;
                        playerIsDead = false;
                        break;
                    default:
                        break;
                }
            }

            if (player2IsDead == true)
            {
                Random rng = new Random();

                switch (rng.Next(4) + 1)
                {
                    case 1:
                        player2.Location = spawner1.Location;
                        player2IsDead = false;
                        break;
                    case 2:
                        player2.Location = spawner2.Location;
                        player2IsDead = false;
                        break;
                    case 3:
                        player2.Location = spawner3.Location;
                        player2IsDead = false;
                        break;
                    case 4:
                        player2.Location = spawner4.Location;
                        player2IsDead = false;
                        break;
                    default:
                        break;
                }
            }
        }

//=================END OF MAIN TIMER_TICK



        private void relodeTimerPlayer1_Tick(object sender, EventArgs e)
        {         
            playerReloadTime++;
            if (playerReloadTime > 3) playerReloadTime = 0;
        }

        private void relodeTimerPlayer2_Tick(object sender, EventArgs e)
        {
            player2ReloadTime++;
            if (player2ReloadTime > 3) player2ReloadTime = 0;
        }

        private void seconds_Tick(object sender, EventArgs e)
        {
            framerateTicks = 0;
        }



        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // controls p1

            if (e.KeyCode == Keys.W)
            {
                playerGoForward = true;
            }
            if (e.KeyCode == Keys.S)
            {
                playerGoBack = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                playerShoot = true;
            }
            //==============

            // controls p2

            if (e.KeyCode == Keys.Up)
            {
                player2GoForward = true;
            }
            if (e.KeyCode == Keys.Down)
            { 
                player2GoBack = true;
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                player2Shoot = true;
            }

            //==============
        }


        private void KayIsUp(object sender, KeyEventArgs e)
        {
            // controls p1

            if (e.KeyCode == Keys.A)
            {
                if (playerPosition > 0)
                {
                    playerPosition--;
                }
                else playerPosition = 3;
            }
            if (e.KeyCode == Keys.D)
            {
                if (playerPosition < 3)
                {
                    playerPosition++;
                }
                else playerPosition = 0;
            }
            if (e.KeyCode == Keys.W)
            {
                playerGoForward = false;
            }
            if (e.KeyCode == Keys.S)
            {
                playerGoBack = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                playerShoot = false;
            }

            if (e.KeyCode == Keys.R)
            {
                playerReload = true;
            }
            //==============

            // controls p2

            if (e.KeyCode == Keys.Left)
            {
                if (player2Position > 0)
                {
                    player2Position--;
                }
                else player2Position = 3;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (player2Position < 3)
                {
                    player2Position++;
                }
                else player2Position = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                player2GoForward = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                player2GoBack = false;
            }

            if (e.KeyCode == Keys.NumPad0)
            {
                player2Shoot = false;
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                player2Reload = true;
            }

            //==============
        }
    }
}
