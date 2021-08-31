using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool goLeft=false, goRight = false, goUp = false, goDown = false;

        int position = 0;

        int playerSpeed = 10;

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

            player.BackgroundImage = 

            if (goUp == true)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true)
            {
                player.Top += playerSpeed;
            }

        }





        private void Seconds_Tick(object sender, EventArgs e)
        {

                fpsCounter_Debug.Text = framerateTicks.ToString();
                framerateTicks = 0;
                      
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.A)
            //{
            //    goLeft = true;
            //}
            //if (e.KeyCode == Keys.D)
            //{
            //    goRight = true;
            //}
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
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
                if (position <3)
                {
                    position++;
                }
                else position = 0;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.R)
            {
               // TODO Restart
            }

        }
    }
}
