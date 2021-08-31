
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
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // wallBottom
            // 
            this.wallBottom.BackColor = System.Drawing.Color.DimGray;
            this.wallBottom.Location = new System.Drawing.Point(28, 1081);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(1100, 40);
            this.wallBottom.TabIndex = 0;
            this.wallBottom.TabStop = false;
            this.wallBottom.Tag = "wall";
            // 
            // wallTop
            // 
            this.wallTop.BackColor = System.Drawing.Color.DimGray;
            this.wallTop.Location = new System.Drawing.Point(29, 19);
            this.wallTop.Name = "wallTop";
            this.wallTop.Size = new System.Drawing.Size(1100, 40);
            this.wallTop.TabIndex = 0;
            this.wallTop.TabStop = false;
            this.wallTop.Tag = "wall";
            // 
            // wallLeft
            // 
            this.wallLeft.BackColor = System.Drawing.Color.DimGray;
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
            this.WallRight.Location = new System.Drawing.Point(1088, 21);
            this.WallRight.Name = "WallRight";
            this.WallRight.Size = new System.Drawing.Size(40, 1100);
            this.WallRight.TabIndex = 0;
            this.WallRight.TabStop = false;
            this.WallRight.Tag = "wall";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
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
            this.fpsCounter_Debug.Location = new System.Drawing.Point(1023, 62);
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
            this.position_Debug.Location = new System.Drawing.Point(1023, 87);
            this.position_Debug.Name = "position_Debug";
            this.position_Debug.Size = new System.Drawing.Size(59, 25);
            this.position_Debug.TabIndex = 3;
            this.position_Debug.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1178, 1144);
            this.Controls.Add(this.position_Debug);
            this.Controls.Add(this.fpsCounter_Debug);
            this.Controls.Add(this.player);
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
    }
}

