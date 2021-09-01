﻿using System;
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
            positionPlayer1_Debug.Text = playerPosition.ToString();
            whichBulletPlayer1_Debug.Text = playerWhichBullet.ToString();


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
                            allert_Debug.Visible = true;
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
                            allert_Debug.Visible = true;
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

//===========================================

//SHOTING P1

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
                if (playerIsReloadStarted == false)
                {
                    playerReloadTime = 0;
                    playerIsReloadStarted = true;
                    relodeTimerPlayer1.Enabled = Enabled;
                }
                reloadTimeDebug.Text = playerReloadTime.ToString();

                if (playerReloadTime == 3)
                {
                    playerBullet1ShotEnable = true;
                    playerBullet2ShotEnable = true;
                    playerBullet3ShotEnable = true;
                    playerReload = false;
                    reloadTimeDebug.Text = "Reloaded";
                    playerReloadTime = 0;
                    relodeTimerPlayer1.Enabled = false;
                    playerIsReloadStarted = false;
                }
            }
            //=================

            if (player2Reload == true && player2Bullet1ShotEnable == false && player2Bullet2ShotEnable == false && player2Bullet3ShotEnable == false)
            {
                if (player2IsReloadStarted == false)
                {
                    player2ReloadTime = 0;
                    player2IsReloadStarted = true;
                    relodeTimerPlayer2.Enabled = Enabled;
                }
                reloadTimeDebug.Text = player2ReloadTime.ToString();

                if (player2ReloadTime == 3)
                {
                    player2Bullet1ShotEnable = true;
                    player2Bullet2ShotEnable = true;
                    player2Bullet3ShotEnable = true;
                    player2Reload = false;
                    reloadTimeDebug.Text = "Reloaded";
                    player2ReloadTime = 0;
                    relodeTimerPlayer2.Enabled = false;
                    player2IsReloadStarted = false;
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


        }

//=================




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
            fpsCounter_Debug.Text = framerateTicks.ToString();
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
