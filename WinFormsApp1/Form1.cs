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

        int position = 0;

        int playerSpeed = 3;

        int score = 0;

        int framerateTicks = 0;

        public Form1()
        {
            InitializeComponent();
        }


    

        private void gameFramerate_Tick(object sender, EventArgs e)
        {
            framerateTicks++;
            position_Debug.Text = position.ToString();

            switch (position)
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
            //if (movement == true)
            //{
                int lastPlayerPositionTop = player.Top;
                int lastPlayerPositionLeft = player.Left;

                switch (position)
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

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        if ((string)x.Tag == "wall")
                        {
                            if (player.Bounds.IntersectsWith(x.Bounds))
                            {

                                player.Top = lastPlayerPositionTop;
                                player.Left = lastPlayerPositionLeft;
                            }
                        }
                    }
                }     
            //}
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
        }

        private void KayIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (position > 0)
                {
                    position--;
                }
                else position = 3;
            }
            if (e.KeyCode == Keys.D)
            {
                if (position < 3)
                {
                    position++;
                }
                else position = 0;
            }
            if (e.KeyCode == Keys.W)
            {
                goForward = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goBack = false;
            }

            if (e.KeyCode == Keys.R)
            {
                // TODO Restart
            }

        }
    }
}
