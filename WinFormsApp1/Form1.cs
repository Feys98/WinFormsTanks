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

        bool goForward = false, goBack = false;

        int playersPosition = 0;

        int playerSpeed = 3;

        int score = 0;

        int framerateTicks = 0;


        //==BULLETS
        bool playersShoot = false;
        bool playersBullet1Shot = false, playersBullet2Shot = false, playersBullet3Shot = false;
        int playerWhichBullet = 0;
        int playersBullet1Position, playersBullet2Position, playersBullet3Position;



        public Form1()
        {
            InitializeComponent();
        }




        private void gameFramerate_Tick(object sender, EventArgs e)
        {
            framerateTicks++;
            position_Debug.Text = playersPosition.ToString();
            whichBullet_Debug.Text = playerWhichBullet.ToString();


            switch (playersPosition)
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

            int lastPlayerPositionTop = player.Top;
            int lastPlayerPositionLeft = player.Left;

            switch (playersPosition)
            {
                case 0:
                    if (goForward == true)
                        player.Top -= playerSpeed;
                    if (goBack == true)
                        player.Top += playerSpeed;
                    break;
                case 1:
                    if (goForward == true)
                        player.Left += playerSpeed;
                    if (goBack == true)
                        player.Left -= playerSpeed;
                    break;
                case 2:
                    if (goForward == true)
                        player.Top += playerSpeed;
                    if (goBack == true)
                        player.Top -= playerSpeed;
                    break;
                case 3:
                    if (goForward == true)
                        player.Left -= playerSpeed;
                    if (goBack == true)
                        player.Left += playerSpeed;
                    break;
            }

            foreach (Control _wall in this.Controls)
            {
                if (_wall is PictureBox)
                {
                    if ((string)_wall.Tag == "wall")
                    {
                        if (player.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            player.Top = lastPlayerPositionTop;
                            player.Left = lastPlayerPositionLeft;
                            allert_Debug.Visible = true;
                        }

                        if (playersBullet1.Bounds.IntersectsWith(_wall.Bounds))                        
                        {
                            playersBullet1.Visible = false;
                            playersBullet1Shot = false;
                            playersBullet1.Location = new Point (0,0);
                        }
                        if (playersBullet2.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            playersBullet2.Visible = false;
                            playersBullet2Shot = false;
                            playersBullet2.Location = new Point(0, 0);
                        }
                        if (playersBullet3.Bounds.IntersectsWith(_wall.Bounds))
                        {
                            playersBullet3.Visible = false;
                            playersBullet3Shot = false;
                            playersBullet3.Location = new Point(0, 0);
                        }
                    }
                }
            }

            if (playersShoot == true)
            {

                switch (playerWhichBullet)
                {
                    case 0:
                        playersBullet1Position = playersPosition;
                        playersBullet1.Location = player.Location;
                        playersBullet1Shot = true;
                        playersBullet1.Visible = true;
                        interfaceBullet1.Visible = false;
                        break;
                    case 1:
                        playersBullet2Position = playersPosition;
                        playersBullet2.Location = player.Location;
                        playersBullet2Shot = true;
                        playersBullet2.Visible = true;
                        interfaceBullet2.Visible = false;
                        break;
                    case 2:
                        playersBullet3Position = playersPosition;
                        playersBullet3.Location = player.Location;
                        playersBullet3Shot = true;
                        playersBullet3.Visible = true;
                        interfaceBullet3.Visible = false;
                        break;
                    default:
                        break;
                }
                playerWhichBullet++;
                if (playerWhichBullet > 2) playerWhichBullet = 0;
                playersShoot = false;

            }

            if (playersBullet1Shot == true)
            {
                switch (playersBullet1Position)
                {
                    case 0:
                        playersBullet1.Top -= 5;
                        break;
                    case 1:
                        playersBullet1.Left += 5;
                        break;
                    case 2:
                        playersBullet1.Top += 5;
                        break;
                    case 3:
                        playersBullet1.Left -= 5;
                        break;
                    default:
                        break;
                }
            }

            if (playersBullet2Shot == true)
            {
                switch (playersBullet2Position)
                {
                    case 0:
                        playersBullet2.Top -= 5;
                        break;
                    case 1:
                        playersBullet2.Left += 5;
                        break;
                    case 2:
                        playersBullet2.Top += 5;
                        break;
                    case 3:
                        playersBullet2.Left -= 5;
                        break;
                    default:
                        break;
                }
            }

            if (playersBullet3Shot == true)
            {
                switch (playersBullet3Position)
                {
                    case 0:
                        playersBullet3.Top -= 5;
                        break;
                    case 1:
                        playersBullet3.Left += 5;
                        break;
                    case 2:
                        playersBullet3.Top += 5;
                        break;
                    case 3:
                        playersBullet3.Left -= 5;
                        break;
                    default:
                        break;
                }
            }


        }

        private void playersBullet1_Click(object sender, EventArgs e)
        {

        }

        private void Seconds_Tick(object sender, EventArgs e)
        {

            fpsCounter_Debug.Text = framerateTicks.ToString();
            framerateTicks = 0;

        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goForward = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goBack = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                playersShoot = true;
            }
        }


        private void KayIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (playersPosition > 0)
                {
                    playersPosition--;
                }
                else playersPosition = 3;
            }
            if (e.KeyCode == Keys.D)
            {
                if (playersPosition < 3)
                {
                    playersPosition++;
                }
                else playersPosition = 0;
            }
            if (e.KeyCode == Keys.W)
            {
                goForward = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goBack = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                playersShoot = false;
            }

            if (e.KeyCode == Keys.R)
            {
                // TODO Restart
            }

        }
    }
}
