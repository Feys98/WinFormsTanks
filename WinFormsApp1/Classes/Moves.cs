using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Classes
{
    public static class Moves
    {
        public static void playerMove(PictureBox obj, int position,int playerSpeed, bool goForward, bool goBack)
        {
            switch (position)
            {
                case 0:

                    if (goForward == true)
                    {
                        obj.Top -= playerSpeed;
                    }
                    if (goBack == true)
                    {
                        obj.Top += playerSpeed;
                    }
                    break;

                case 1:

                    if (goForward == true)
                    {
                        obj.Left += playerSpeed;
                    }
                    if (goBack == true)
                    {
                        obj.Left -= playerSpeed;
                    }
                    break;

                case 2:

                    if (goForward == true)
                    {
                        obj.Top += playerSpeed;
                    }
                    if (goBack == true)
                    {
                        obj.Top -= playerSpeed;
                    }
                    break;

                case 3:

                    if (goForward == true)
                    {
                        obj.Left -= playerSpeed;
                    }
                    if (goBack == true)
                    {
                        obj.Left += playerSpeed;
                    }
                    break;

            }
        }
    }
}
