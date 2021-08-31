
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.wallBottom = new System.Windows.Forms.PictureBox();
            this.wallTop = new System.Windows.Forms.PictureBox();
            this.wallLeft = new System.Windows.Forms.PictureBox();
            this.WallRight = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.gameFramerate = new System.Windows.Forms.Timer(this.components);
            this.fpsCounter_Debug = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Timer(this.components);
            this.position_Debug = new System.Windows.Forms.Label();
            this.allert_Debug = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // wallBottom
            // 
            this.wallBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wallBottom.Location = new System.Drawing.Point(28, 1081);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(1100, 40);
            this.wallBottom.TabIndex = 0;
            this.wallBottom.TabStop = false;
            this.wallBottom.Tag = "wall";
            // 
            // wallTop
            // 
            this.wallTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wallTop.Location = new System.Drawing.Point(29, 19);
            this.wallTop.Name = "wallTop";
            this.wallTop.Size = new System.Drawing.Size(1100, 40);
            this.wallTop.TabIndex = 0;
            this.wallTop.TabStop = false;
            this.wallTop.Tag = "wall";
            // 
            // wallLeft
            // 
            this.wallLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wallLeft.Location = new System.Drawing.Point(28, 21);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(40, 1100);
            this.wallLeft.TabIndex = 0;
            this.wallLeft.TabStop = false;
            this.wallLeft.Tag = "wall";
            // 
            // WallRight
            // 
            this.WallRight.BackColor = System.Drawing.Color.DimGray;
            this.WallRight.Location = new System.Drawing.Point(650, 564);
            this.WallRight.Name = "WallRight";
            this.WallRight.Size = new System.Drawing.Size(40, 524);
            this.WallRight.TabIndex = 0;
            this.WallRight.TabStop = false;
            this.WallRight.Tag = "wall";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.BackgroundImage = global::WinFormsApp1.Properties.Resources.TankModel_pos0;
            this.player.Location = new System.Drawing.Point(138, 935);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(75, 75);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // gameFramerate
            // 
            this.gameFramerate.Enabled = true;
            this.gameFramerate.Interval = 8;
            this.gameFramerate.Tick += new System.EventHandler(this.gameFramerate_Tick);
            // 
            // fpsCounter_Debug
            // 
            this.fpsCounter_Debug.AutoSize = true;
            this.fpsCounter_Debug.Location = new System.Drawing.Point(1173, 56);
            this.fpsCounter_Debug.Name = "fpsCounter_Debug";
            this.fpsCounter_Debug.Size = new System.Drawing.Size(37, 25);
            this.fpsCounter_Debug.TabIndex = 2;
            this.fpsCounter_Debug.Text = "fps";
            // 
            // Seconds
            // 
            this.Seconds.Enabled = true;
            this.Seconds.Interval = 1000;
            this.Seconds.Tick += new System.EventHandler(this.Seconds_Tick);
            // 
            // position_Debug
            // 
            this.position_Debug.AutoSize = true;
            this.position_Debug.Location = new System.Drawing.Point(1173, 81);
            this.position_Debug.Name = "position_Debug";
            this.position_Debug.Size = new System.Drawing.Size(59, 25);
            this.position_Debug.TabIndex = 3;
            this.position_Debug.Text = "label1";
            // 
            // allert_Debug
            // 
            this.allert_Debug.AutoSize = true;
            this.allert_Debug.BackColor = System.Drawing.Color.DarkRed;
            this.allert_Debug.ForeColor = System.Drawing.Color.Red;
            this.allert_Debug.Location = new System.Drawing.Point(1173, 31);
            this.allert_Debug.Name = "allert_Debug";
            this.allert_Debug.Size = new System.Drawing.Size(83, 25);
            this.allert_Debug.TabIndex = 2;
            this.allert_Debug.Text = "ALLERT!!!";
            this.allert_Debug.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(262, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(1089, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 1102);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox3.Location = new System.Drawing.Point(349, 573);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 524);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox4.Location = new System.Drawing.Point(54, 272);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(846, 22);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox5.Location = new System.Drawing.Point(898, 431);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 524);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "wall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1314, 1144);
            this.Controls.Add(this.position_Debug);
            this.Controls.Add(this.allert_Debug);
            this.Controls.Add(this.fpsCounter_Debug);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.WallRight);
            this.Controls.Add(this.wallLeft);
            this.Controls.Add(this.wallTop);
            this.Controls.Add(this.wallBottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KayIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wallBottom;
        private System.Windows.Forms.PictureBox wallTop;
        private System.Windows.Forms.PictureBox wallLeft;
        private System.Windows.Forms.PictureBox WallRight;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameFramerate;
        private System.Windows.Forms.Label fpsCounter_Debug;
        private System.Windows.Forms.Timer Seconds;
        private System.Windows.Forms.Label position_Debug;
        private System.Windows.Forms.Label allert_Debug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

