namespace RussianRouletteAssignment1
{
    partial class GameMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMain));
            this.Label_score = new System.Windows.Forms.Label();
            this.Label_player = new System.Windows.Forms.Label();
            this.Gun_PointHead = new System.Windows.Forms.PictureBox();
            this.Pic_smokeLeft = new System.Windows.Forms.PictureBox();
            this.Pic_bulletLeft = new System.Windows.Forms.PictureBox();
            this.Pic_blood = new System.Windows.Forms.PictureBox();
            this.Label_toPlay = new System.Windows.Forms.LinkLabel();
            this.Btn_restart = new System.Windows.Forms.Button();
            this.Gun_PointAway = new System.Windows.Forms.PictureBox();
            this.Label_round = new System.Windows.Forms.Label();
            this.Label_title2 = new System.Windows.Forms.Label();
            this.Btn_spin = new System.Windows.Forms.Button();
            this.Btn_load = new System.Windows.Forms.Button();
            this.Btn_shootAway = new System.Windows.Forms.Button();
            this.Btn_shootMe = new System.Windows.Forms.Button();
            this.timer_bullet = new System.Windows.Forms.Timer(this.components);
            this.timer_gun = new System.Windows.Forms.Timer(this.components);
            this.Pic_GunSpin = new System.Windows.Forms.PictureBox();
            this.timer_spin = new System.Windows.Forms.Timer(this.components);
            this.Pic_smokeRight = new System.Windows.Forms.PictureBox();
            this.Pic_Broken = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_smokeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_bulletLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_blood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GunSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_smokeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Broken)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_score
            // 
            this.Label_score.AutoSize = true;
            this.Label_score.BackColor = System.Drawing.Color.Transparent;
            this.Label_score.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_score.ForeColor = System.Drawing.Color.White;
            this.Label_score.Location = new System.Drawing.Point(518, 419);
            this.Label_score.Name = "Label_score";
            this.Label_score.Size = new System.Drawing.Size(112, 25);
            this.Label_score.TabIndex = 60;
            this.Label_score.Text = "Total Score:";
            // 
            // Label_player
            // 
            this.Label_player.AutoSize = true;
            this.Label_player.BackColor = System.Drawing.Color.Transparent;
            this.Label_player.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_player.ForeColor = System.Drawing.Color.White;
            this.Label_player.Location = new System.Drawing.Point(15, 48);
            this.Label_player.Name = "Label_player";
            this.Label_player.Size = new System.Drawing.Size(77, 25);
            this.Label_player.TabIndex = 59;
            this.Label_player.Text = "Player: ";
            // 
            // Gun_PointHead
            // 
            this.Gun_PointHead.BackColor = System.Drawing.Color.Transparent;
            this.Gun_PointHead.Image = ((System.Drawing.Image)(resources.GetObject("Gun_PointHead.Image")));
            this.Gun_PointHead.Location = new System.Drawing.Point(330, 114);
            this.Gun_PointHead.Name = "Gun_PointHead";
            this.Gun_PointHead.Size = new System.Drawing.Size(131, 92);
            this.Gun_PointHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gun_PointHead.TabIndex = 51;
            this.Gun_PointHead.TabStop = false;
            // 
            // Pic_smokeLeft
            // 
            this.Pic_smokeLeft.BackColor = System.Drawing.Color.Transparent;
            this.Pic_smokeLeft.Image = ((System.Drawing.Image)(resources.GetObject("Pic_smokeLeft.Image")));
            this.Pic_smokeLeft.Location = new System.Drawing.Point(220, 100);
            this.Pic_smokeLeft.Name = "Pic_smokeLeft";
            this.Pic_smokeLeft.Size = new System.Drawing.Size(100, 50);
            this.Pic_smokeLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_smokeLeft.TabIndex = 58;
            this.Pic_smokeLeft.TabStop = false;
            this.Pic_smokeLeft.Visible = false;
            // 
            // Pic_bulletLeft
            // 
            this.Pic_bulletLeft.BackColor = System.Drawing.Color.Transparent;
            this.Pic_bulletLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_bulletLeft.Image = ((System.Drawing.Image)(resources.GetObject("Pic_bulletLeft.Image")));
            this.Pic_bulletLeft.Location = new System.Drawing.Point(287, 126);
            this.Pic_bulletLeft.Name = "Pic_bulletLeft";
            this.Pic_bulletLeft.Size = new System.Drawing.Size(33, 15);
            this.Pic_bulletLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_bulletLeft.TabIndex = 54;
            this.Pic_bulletLeft.TabStop = false;
            // 
            // Pic_blood
            // 
            this.Pic_blood.BackColor = System.Drawing.Color.Transparent;
            this.Pic_blood.Image = ((System.Drawing.Image)(resources.GetObject("Pic_blood.Image")));
            this.Pic_blood.Location = new System.Drawing.Point(79, 76);
            this.Pic_blood.Name = "Pic_blood";
            this.Pic_blood.Size = new System.Drawing.Size(148, 115);
            this.Pic_blood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_blood.TabIndex = 57;
            this.Pic_blood.TabStop = false;
            this.Pic_blood.Visible = false;
            // 
            // Label_toPlay
            // 
            this.Label_toPlay.AutoSize = true;
            this.Label_toPlay.BackColor = System.Drawing.Color.Transparent;
            this.Label_toPlay.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_toPlay.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label_toPlay.Location = new System.Drawing.Point(771, 70);
            this.Label_toPlay.Name = "Label_toPlay";
            this.Label_toPlay.Size = new System.Drawing.Size(66, 16);
            this.Label_toPlay.TabIndex = 56;
            this.Label_toPlay.TabStop = true;
            this.Label_toPlay.Text = "How to play";
            this.Label_toPlay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_toPlay_LinkClicked);
            // 
            // Btn_restart
            // 
            this.Btn_restart.BackColor = System.Drawing.Color.Brown;
            this.Btn_restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_restart.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_restart.ForeColor = System.Drawing.Color.White;
            this.Btn_restart.Location = new System.Drawing.Point(751, 362);
            this.Btn_restart.Name = "Btn_restart";
            this.Btn_restart.Size = new System.Drawing.Size(102, 26);
            this.Btn_restart.TabIndex = 55;
            this.Btn_restart.Text = "Restart";
            this.Btn_restart.UseVisualStyleBackColor = false;
            this.Btn_restart.Click += new System.EventHandler(this.Btn_restart_Click);
            // 
            // Gun_PointAway
            // 
            this.Gun_PointAway.BackColor = System.Drawing.Color.Transparent;
            this.Gun_PointAway.Image = ((System.Drawing.Image)(resources.GetObject("Gun_PointAway.Image")));
            this.Gun_PointAway.Location = new System.Drawing.Point(342, 114);
            this.Gun_PointAway.Name = "Gun_PointAway";
            this.Gun_PointAway.Size = new System.Drawing.Size(131, 92);
            this.Gun_PointAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gun_PointAway.TabIndex = 53;
            this.Gun_PointAway.TabStop = false;
            this.Gun_PointAway.Visible = false;
            // 
            // Label_round
            // 
            this.Label_round.AutoSize = true;
            this.Label_round.BackColor = System.Drawing.Color.Transparent;
            this.Label_round.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_round.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label_round.Location = new System.Drawing.Point(336, 419);
            this.Label_round.Name = "Label_round";
            this.Label_round.Size = new System.Drawing.Size(89, 25);
            this.Label_round.TabIndex = 52;
            this.Label_round.Text = "Round: 0";
            // 
            // Label_title2
            // 
            this.Label_title2.AutoSize = true;
            this.Label_title2.BackColor = System.Drawing.Color.Transparent;
            this.Label_title2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_title2.ForeColor = System.Drawing.Color.White;
            this.Label_title2.Location = new System.Drawing.Point(310, 3);
            this.Label_title2.Name = "Label_title2";
            this.Label_title2.Size = new System.Drawing.Size(262, 45);
            this.Label_title2.TabIndex = 50;
            this.Label_title2.Text = "Russian Roulette";
            // 
            // Btn_spin
            // 
            this.Btn_spin.BackColor = System.Drawing.Color.Brown;
            this.Btn_spin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_spin.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_spin.ForeColor = System.Drawing.Color.White;
            this.Btn_spin.Location = new System.Drawing.Point(751, 146);
            this.Btn_spin.Name = "Btn_spin";
            this.Btn_spin.Size = new System.Drawing.Size(102, 26);
            this.Btn_spin.TabIndex = 49;
            this.Btn_spin.Text = "Spin";
            this.Btn_spin.UseVisualStyleBackColor = false;
            this.Btn_spin.Click += new System.EventHandler(this.Btn_spin_Click);
            // 
            // Btn_load
            // 
            this.Btn_load.BackColor = System.Drawing.Color.Brown;
            this.Btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_load.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_load.ForeColor = System.Drawing.Color.White;
            this.Btn_load.Location = new System.Drawing.Point(751, 113);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(102, 26);
            this.Btn_load.TabIndex = 48;
            this.Btn_load.Text = "Load";
            this.Btn_load.UseVisualStyleBackColor = false;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Btn_shootAway
            // 
            this.Btn_shootAway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_shootAway.BackgroundImage")));
            this.Btn_shootAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_shootAway.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_shootAway.Location = new System.Drawing.Point(751, 268);
            this.Btn_shootAway.Name = "Btn_shootAway";
            this.Btn_shootAway.Size = new System.Drawing.Size(102, 26);
            this.Btn_shootAway.TabIndex = 47;
            this.Btn_shootAway.Text = "Shoot Away";
            this.Btn_shootAway.UseVisualStyleBackColor = true;
            this.Btn_shootAway.Click += new System.EventHandler(this.Btn_shootAway_Click);
            // 
            // Btn_shootMe
            // 
            this.Btn_shootMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_shootMe.BackgroundImage")));
            this.Btn_shootMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_shootMe.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_shootMe.Location = new System.Drawing.Point(751, 236);
            this.Btn_shootMe.Name = "Btn_shootMe";
            this.Btn_shootMe.Size = new System.Drawing.Size(102, 26);
            this.Btn_shootMe.TabIndex = 46;
            this.Btn_shootMe.Text = "Shoot Me";
            this.Btn_shootMe.UseVisualStyleBackColor = true;
            this.Btn_shootMe.Click += new System.EventHandler(this.Btn_shootMe_Click);
            // 
            // timer_bullet
            // 
            this.timer_bullet.Enabled = true;
            this.timer_bullet.Interval = 30;
            this.timer_bullet.Tick += new System.EventHandler(this.timer_bullet_Tick);
            // 
            // timer_gun
            // 
            this.timer_gun.Enabled = true;
            this.timer_gun.Interval = 300;
            this.timer_gun.Tick += new System.EventHandler(this.timer_gun_Tick);
            // 
            // Pic_GunSpin
            // 
            this.Pic_GunSpin.Image = ((System.Drawing.Image)(resources.GetObject("Pic_GunSpin.Image")));
            this.Pic_GunSpin.Location = new System.Drawing.Point(324, 236);
            this.Pic_GunSpin.Name = "Pic_GunSpin";
            this.Pic_GunSpin.Size = new System.Drawing.Size(149, 80);
            this.Pic_GunSpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_GunSpin.TabIndex = 61;
            this.Pic_GunSpin.TabStop = false;
            // 
            // timer_spin
            // 
            this.timer_spin.Enabled = true;
            this.timer_spin.Interval = 6500;
            this.timer_spin.Tick += new System.EventHandler(this.timer_spin_Tick);
            // 
            // Pic_smokeRight
            // 
            this.Pic_smokeRight.BackColor = System.Drawing.Color.Transparent;
            this.Pic_smokeRight.Image = ((System.Drawing.Image)(resources.GetObject("Pic_smokeRight.Image")));
            this.Pic_smokeRight.Location = new System.Drawing.Point(472, 100);
            this.Pic_smokeRight.Name = "Pic_smokeRight";
            this.Pic_smokeRight.Size = new System.Drawing.Size(100, 51);
            this.Pic_smokeRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_smokeRight.TabIndex = 62;
            this.Pic_smokeRight.TabStop = false;
            // 
            // Pic_Broken
            // 
            this.Pic_Broken.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Broken.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Broken.Image")));
            this.Pic_Broken.Location = new System.Drawing.Point(578, 48);
            this.Pic_Broken.Name = "Pic_Broken";
            this.Pic_Broken.Size = new System.Drawing.Size(134, 132);
            this.Pic_Broken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Broken.TabIndex = 64;
            this.Pic_Broken.TabStop = false;
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 458);
            this.Controls.Add(this.Pic_smokeRight);
            this.Controls.Add(this.Pic_Broken);
            this.Controls.Add(this.Pic_GunSpin);
            this.Controls.Add(this.Label_score);
            this.Controls.Add(this.Label_player);
            this.Controls.Add(this.Gun_PointHead);
            this.Controls.Add(this.Pic_smokeLeft);
            this.Controls.Add(this.Pic_bulletLeft);
            this.Controls.Add(this.Pic_blood);
            this.Controls.Add(this.Label_toPlay);
            this.Controls.Add(this.Btn_restart);
            this.Controls.Add(this.Gun_PointAway);
            this.Controls.Add(this.Label_round);
            this.Controls.Add(this.Label_title2);
            this.Controls.Add(this.Btn_spin);
            this.Controls.Add(this.Btn_load);
            this.Controls.Add(this.Btn_shootAway);
            this.Controls.Add(this.Btn_shootMe);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "GameMain";
            this.Text = "Russian Roulette";
            this.Load += new System.EventHandler(this.GameMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_smokeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_bulletLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_blood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GunSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_smokeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Broken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_score;
        private System.Windows.Forms.Label Label_player;
        private System.Windows.Forms.PictureBox Gun_PointHead;
        private System.Windows.Forms.PictureBox Pic_smokeLeft;
        private System.Windows.Forms.PictureBox Pic_bulletLeft;
        private System.Windows.Forms.PictureBox Pic_blood;
        private System.Windows.Forms.LinkLabel Label_toPlay;
        private System.Windows.Forms.Button Btn_restart;
        private System.Windows.Forms.PictureBox Gun_PointAway;
        private System.Windows.Forms.Label Label_round;
        private System.Windows.Forms.Label Label_title2;
        private System.Windows.Forms.Button Btn_spin;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_shootAway;
        private System.Windows.Forms.Button Btn_shootMe;
        private System.Windows.Forms.Timer timer_bullet;
        private System.Windows.Forms.Timer timer_gun;
        private System.Windows.Forms.PictureBox Pic_GunSpin;
        private System.Windows.Forms.Timer timer_spin;
        private System.Windows.Forms.PictureBox Pic_smokeRight;
        private System.Windows.Forms.PictureBox Pic_Broken;
    }
}