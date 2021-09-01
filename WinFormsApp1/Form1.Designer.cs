
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
            this.seconds = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.playerBullet1 = new System.Windows.Forms.PictureBox();
            this.playerBullet2 = new System.Windows.Forms.PictureBox();
            this.playerBullet3 = new System.Windows.Forms.PictureBox();
            this.interfacePlayerBullet1 = new System.Windows.Forms.PictureBox();
            this.interfacePlayerBullet2 = new System.Windows.Forms.PictureBox();
            this.interfacePlayerBullet3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.relodeTimerPlayer1 = new System.Windows.Forms.Timer(this.components);
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player2Bullet1 = new System.Windows.Forms.PictureBox();
            this.player2Bullet3 = new System.Windows.Forms.PictureBox();
            this.player2Bullet2 = new System.Windows.Forms.PictureBox();
            this.relodeTimerPlayer2 = new System.Windows.Forms.Timer(this.components);
            this.spawner1 = new System.Windows.Forms.PictureBox();
            this.spawner4 = new System.Windows.Forms.PictureBox();
            this.spawner3 = new System.Windows.Forms.PictureBox();
            this.spawner2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interfacePlayerScore = new System.Windows.Forms.Label();
            this.interfacePlayer2Bullet1 = new System.Windows.Forms.PictureBox();
            this.interfacePlayer2Bullet2 = new System.Windows.Forms.PictureBox();
            this.interfacePlayer2Bullet3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interfacePlayer2Score = new System.Windows.Forms.Label();
            this.interfacePlayerReloading = new System.Windows.Forms.Label();
            this.interfacePlayer2Reloading = new System.Windows.Forms.Label();
            this.interfacePressR = new System.Windows.Forms.Label();
            this.interfacePress0 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.playerBullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayerBullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayerBullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayerBullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayer2Bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayer2Bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayer2Bullet3)).BeginInit();
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
            this.WallRight.Location = new System.Drawing.Point(645, 558);
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
            this.player.Location = new System.Drawing.Point(247, 880);
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
            // seconds
            // 
            this.seconds.Enabled = true;
            this.seconds.Interval = 1000;
            this.seconds.Tick += new System.EventHandler(this.seconds_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(259, 216);
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
            this.pictureBox3.Location = new System.Drawing.Point(345, 557);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 524);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox4.Location = new System.Drawing.Point(68, 292);
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
            // playerBullet1
            // 
            this.playerBullet1.BackColor = System.Drawing.Color.DodgerBlue;
            this.playerBullet1.Location = new System.Drawing.Point(0, 19);
            this.playerBullet1.Name = "playerBullet1";
            this.playerBullet1.Size = new System.Drawing.Size(25, 25);
            this.playerBullet1.TabIndex = 4;
            this.playerBullet1.TabStop = false;
            this.playerBullet1.Tag = "players1Bullet";
            this.playerBullet1.Visible = false;
            // 
            // playerBullet2
            // 
            this.playerBullet2.BackColor = System.Drawing.Color.DodgerBlue;
            this.playerBullet2.Location = new System.Drawing.Point(0, 50);
            this.playerBullet2.Name = "playerBullet2";
            this.playerBullet2.Size = new System.Drawing.Size(25, 25);
            this.playerBullet2.TabIndex = 5;
            this.playerBullet2.TabStop = false;
            this.playerBullet2.Tag = "players1Bullet";
            this.playerBullet2.Visible = false;
            // 
            // playerBullet3
            // 
            this.playerBullet3.BackColor = System.Drawing.Color.DodgerBlue;
            this.playerBullet3.Location = new System.Drawing.Point(0, 81);
            this.playerBullet3.Name = "playerBullet3";
            this.playerBullet3.Size = new System.Drawing.Size(25, 25);
            this.playerBullet3.TabIndex = 5;
            this.playerBullet3.TabStop = false;
            this.playerBullet3.Tag = "players1Bullet";
            this.playerBullet3.Visible = false;
            // 
            // interfacePlayerBullet1
            // 
            this.interfacePlayerBullet1.BackColor = System.Drawing.Color.DodgerBlue;
            this.interfacePlayerBullet1.Location = new System.Drawing.Point(1213, 283);
            this.interfacePlayerBullet1.Name = "interfacePlayerBullet1";
            this.interfacePlayerBullet1.Size = new System.Drawing.Size(25, 25);
            this.interfacePlayerBullet1.TabIndex = 5;
            this.interfacePlayerBullet1.TabStop = false;
            this.interfacePlayerBullet1.Tag = "playersBullet";
            // 
            // interfacePlayerBullet2
            // 
            this.interfacePlayerBullet2.BackColor = System.Drawing.Color.DodgerBlue;
            this.interfacePlayerBullet2.Location = new System.Drawing.Point(1213, 333);
            this.interfacePlayerBullet2.Name = "interfacePlayerBullet2";
            this.interfacePlayerBullet2.Size = new System.Drawing.Size(25, 25);
            this.interfacePlayerBullet2.TabIndex = 5;
            this.interfacePlayerBullet2.TabStop = false;
            this.interfacePlayerBullet2.Tag = "playersBullet";
            // 
            // interfacePlayerBullet3
            // 
            this.interfacePlayerBullet3.BackColor = System.Drawing.Color.DodgerBlue;
            this.interfacePlayerBullet3.Location = new System.Drawing.Point(1213, 383);
            this.interfacePlayerBullet3.Name = "interfacePlayerBullet3";
            this.interfacePlayerBullet3.Size = new System.Drawing.Size(25, 25);
            this.interfacePlayerBullet3.TabIndex = 5;
            this.interfacePlayerBullet3.TabStop = false;
            this.interfacePlayerBullet3.Tag = "playersBullet";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox6.Location = new System.Drawing.Point(68, 772);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(145, 25);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            // 
            // relodeTimerPlayer1
            // 
            this.relodeTimerPlayer1.Interval = 1000;
            this.relodeTimerPlayer1.Tick += new System.EventHandler(this.relodeTimerPlayer1_Tick);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Black;
            this.player2.BackgroundImage = global::WinFormsApp1.Properties.Resources.TankModel2_pos0;
            this.player2.Location = new System.Drawing.Point(247, 525);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(75, 75);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            this.player2.Tag = "player2";
            // 
            // player2Bullet1
            // 
            this.player2Bullet1.BackColor = System.Drawing.Color.DarkRed;
            this.player2Bullet1.Location = new System.Drawing.Point(0, 137);
            this.player2Bullet1.Name = "player2Bullet1";
            this.player2Bullet1.Size = new System.Drawing.Size(25, 25);
            this.player2Bullet1.TabIndex = 4;
            this.player2Bullet1.TabStop = false;
            this.player2Bullet1.Tag = "players2Bullet";
            this.player2Bullet1.Visible = false;
            // 
            // player2Bullet3
            // 
            this.player2Bullet3.BackColor = System.Drawing.Color.DarkRed;
            this.player2Bullet3.Location = new System.Drawing.Point(0, 199);
            this.player2Bullet3.Name = "player2Bullet3";
            this.player2Bullet3.Size = new System.Drawing.Size(25, 25);
            this.player2Bullet3.TabIndex = 5;
            this.player2Bullet3.TabStop = false;
            this.player2Bullet3.Tag = "players2Bullet";
            this.player2Bullet3.Visible = false;
            // 
            // player2Bullet2
            // 
            this.player2Bullet2.BackColor = System.Drawing.Color.DarkRed;
            this.player2Bullet2.Location = new System.Drawing.Point(0, 168);
            this.player2Bullet2.Name = "player2Bullet2";
            this.player2Bullet2.Size = new System.Drawing.Size(25, 25);
            this.player2Bullet2.TabIndex = 5;
            this.player2Bullet2.TabStop = false;
            this.player2Bullet2.Tag = "players2Bullet";
            this.player2Bullet2.Visible = false;
            // 
            // relodeTimerPlayer2
            // 
            this.relodeTimerPlayer2.Interval = 1000;
            this.relodeTimerPlayer2.Tick += new System.EventHandler(this.relodeTimerPlayer2_Tick);
            // 
            // spawner1
            // 
            this.spawner1.Location = new System.Drawing.Point(111, 106);
            this.spawner1.Name = "spawner1";
            this.spawner1.Size = new System.Drawing.Size(66, 66);
            this.spawner1.TabIndex = 6;
            this.spawner1.TabStop = false;
            this.spawner1.Tag = "spawner";
            this.spawner1.Visible = false;
            // 
            // spawner4
            // 
            this.spawner4.Location = new System.Drawing.Point(111, 964);
            this.spawner4.Name = "spawner4";
            this.spawner4.Size = new System.Drawing.Size(66, 66);
            this.spawner4.TabIndex = 6;
            this.spawner4.TabStop = false;
            this.spawner4.Tag = "spawner";
            this.spawner4.Visible = false;
            // 
            // spawner3
            // 
            this.spawner3.Location = new System.Drawing.Point(989, 964);
            this.spawner3.Name = "spawner3";
            this.spawner3.Size = new System.Drawing.Size(66, 66);
            this.spawner3.TabIndex = 6;
            this.spawner3.TabStop = false;
            this.spawner3.Tag = "spawner";
            this.spawner3.Visible = false;
            // 
            // spawner2
            // 
            this.spawner2.Location = new System.Drawing.Point(989, 106);
            this.spawner2.Name = "spawner2";
            this.spawner2.Size = new System.Drawing.Size(66, 66);
            this.spawner2.TabIndex = 6;
            this.spawner2.TabStop = false;
            this.spawner2.Tag = "spawner";
            this.spawner2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1166, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "PLAYER 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1178, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "SCORE:";
            // 
            // interfacePlayerScore
            // 
            this.interfacePlayerScore.AutoSize = true;
            this.interfacePlayerScore.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interfacePlayerScore.Location = new System.Drawing.Point(1249, 238);
            this.interfacePlayerScore.Name = "interfacePlayerScore";
            this.interfacePlayerScore.Size = new System.Drawing.Size(20, 21);
            this.interfacePlayerScore.TabIndex = 8;
            this.interfacePlayerScore.Text = "0";
            // 
            // interfacePlayer2Bullet1
            // 
            this.interfacePlayer2Bullet1.BackColor = System.Drawing.Color.DarkRed;
            this.interfacePlayer2Bullet1.Location = new System.Drawing.Point(1213, 674);
            this.interfacePlayer2Bullet1.Name = "interfacePlayer2Bullet1";
            this.interfacePlayer2Bullet1.Size = new System.Drawing.Size(25, 25);
            this.interfacePlayer2Bullet1.TabIndex = 5;
            this.interfacePlayer2Bullet1.TabStop = false;
            this.interfacePlayer2Bullet1.Tag = "playersBullet";
            // 
            // interfacePlayer2Bullet2
            // 
            this.interfacePlayer2Bullet2.BackColor = System.Drawing.Color.DarkRed;
            this.interfacePlayer2Bullet2.Location = new System.Drawing.Point(1213, 724);
            this.interfacePlayer2Bullet2.Name = "interfacePlayer2Bullet2";
            this.interfacePlayer2Bullet2.Size = new System.Drawing.Size(25, 25);
            this.interfacePlayer2Bullet2.TabIndex = 5;
            this.interfacePlayer2Bullet2.TabStop = false;
            this.interfacePlayer2Bullet2.Tag = "playersBullet";
            // 
            // interfacePlayer2Bullet3
            // 
            this.interfacePlayer2Bullet3.BackColor = System.Drawing.Color.DarkRed;
            this.interfacePlayer2Bullet3.Location = new System.Drawing.Point(1213, 774);
            this.interfacePlayer2Bullet3.Name = "interfacePlayer2Bullet3";
            this.interfacePlayer2Bullet3.Size = new System.Drawing.Size(25, 25);
            this.interfacePlayer2Bullet3.TabIndex = 5;
            this.interfacePlayer2Bullet3.TabStop = false;
            this.interfacePlayer2Bullet3.Tag = "playersBullet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1166, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "PLAYER 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1181, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "SCORE:";
            // 
            // interfacePlayer2Score
            // 
            this.interfacePlayer2Score.AutoSize = true;
            this.interfacePlayer2Score.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interfacePlayer2Score.Location = new System.Drawing.Point(1252, 629);
            this.interfacePlayer2Score.Name = "interfacePlayer2Score";
            this.interfacePlayer2Score.Size = new System.Drawing.Size(20, 21);
            this.interfacePlayer2Score.TabIndex = 8;
            this.interfacePlayer2Score.Text = "0";
            // 
            // interfacePlayerReloading
            // 
            this.interfacePlayerReloading.AutoSize = true;
            this.interfacePlayerReloading.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interfacePlayerReloading.Location = new System.Drawing.Point(1158, 333);
            this.interfacePlayerReloading.Name = "interfacePlayerReloading";
            this.interfacePlayerReloading.Size = new System.Drawing.Size(137, 30);
            this.interfacePlayerReloading.TabIndex = 7;
            this.interfacePlayerReloading.Text = "Reloading...";
            this.interfacePlayerReloading.Visible = false;
            // 
            // interfacePlayer2Reloading
            // 
            this.interfacePlayer2Reloading.AutoSize = true;
            this.interfacePlayer2Reloading.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interfacePlayer2Reloading.Location = new System.Drawing.Point(1158, 724);
            this.interfacePlayer2Reloading.Name = "interfacePlayer2Reloading";
            this.interfacePlayer2Reloading.Size = new System.Drawing.Size(137, 30);
            this.interfacePlayer2Reloading.TabIndex = 7;
            this.interfacePlayer2Reloading.Text = "Reloading...";
            this.interfacePlayer2Reloading.Visible = false;
            // 
            // interfacePressR
            // 
            this.interfacePressR.AutoSize = true;
            this.interfacePressR.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interfacePressR.Location = new System.Drawing.Point(1141, 338);
            this.interfacePressR.Name = "interfacePressR";
            this.interfacePressR.Size = new System.Drawing.Size(162, 25);
            this.interfacePressR.TabIndex = 7;
            this.interfacePressR.Text = "Press R to reload";
            this.interfacePressR.Visible = false;
            // 
            // interfacePress0
            // 
            this.interfacePress0.AutoSize = true;
            this.interfacePress0.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interfacePress0.Location = new System.Drawing.Point(1142, 728);
            this.interfacePress0.Name = "interfacePress0";
            this.interfacePress0.Size = new System.Drawing.Size(161, 25);
            this.interfacePress0.TabIndex = 7;
            this.interfacePress0.Text = "Press 1 to reload";
            this.interfacePress0.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1314, 1144);
            this.Controls.Add(this.interfacePlayer2Score);
            this.Controls.Add(this.interfacePlayerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interfacePlayer2Reloading);
            this.Controls.Add(this.interfacePress0);
            this.Controls.Add(this.interfacePressR);
            this.Controls.Add(this.interfacePlayerReloading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spawner2);
            this.Controls.Add(this.spawner3);
            this.Controls.Add(this.spawner4);
            this.Controls.Add(this.spawner1);
            this.Controls.Add(this.interfacePlayer2Bullet3);
            this.Controls.Add(this.interfacePlayer2Bullet2);
            this.Controls.Add(this.interfacePlayerBullet3);
            this.Controls.Add(this.interfacePlayer2Bullet1);
            this.Controls.Add(this.interfacePlayerBullet2);
            this.Controls.Add(this.interfacePlayerBullet1);
            this.Controls.Add(this.player2Bullet2);
            this.Controls.Add(this.playerBullet3);
            this.Controls.Add(this.player2Bullet3);
            this.Controls.Add(this.player2Bullet1);
            this.Controls.Add(this.playerBullet2);
            this.Controls.Add(this.playerBullet1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.WallRight);
            this.Controls.Add(this.wallLeft);
            this.Controls.Add(this.wallTop);
            this.Controls.Add(this.wallBottom);
            this.Name = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.playerBullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayerBullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayerBullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayerBullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawner2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayer2Bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayer2Bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacePlayer2Bullet3)).EndInit();
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
        private System.Windows.Forms.Timer seconds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox playerBullet1;
        private System.Windows.Forms.PictureBox playerBullet2;
        private System.Windows.Forms.PictureBox playerBullet3;
        private System.Windows.Forms.PictureBox interfacePlayerBullet1;
        private System.Windows.Forms.PictureBox interfacePlayerBullet2;
        private System.Windows.Forms.PictureBox interfacePlayerBullet3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer relodeTimerPlayer1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player2Bullet1;
        private System.Windows.Forms.PictureBox player2Bullet3;
        private System.Windows.Forms.PictureBox player2Bullet2;
        private System.Windows.Forms.Timer relodeTimerPlayer2;
        private System.Windows.Forms.PictureBox spawner1;
        private System.Windows.Forms.PictureBox spawner4;
        private System.Windows.Forms.PictureBox spawner3;
        private System.Windows.Forms.PictureBox spawner2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label interfacePlayerScore;
        private System.Windows.Forms.PictureBox interfacePlayer2Bullet1;
        private System.Windows.Forms.PictureBox interfacePlayer2Bullet2;
        private System.Windows.Forms.PictureBox interfacePlayer2Bullet3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label interfacePlayer2Score;
        private System.Windows.Forms.Label interfacePlayerReloading;
        private System.Windows.Forms.Label interfacePlayer2Reloading;
        private System.Windows.Forms.Label interfacePressR;
        private System.Windows.Forms.Label interfacePress0;
    }
}

