namespace RussianRouletteAssignment1
{
    partial class GameStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStart));
            this.Label_EnName = new System.Windows.Forms.Label();
            this.Btn_enter = new System.Windows.Forms.Button();
            this.Textbox_Player = new System.Windows.Forms.TextBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_EnName
            // 
            this.Label_EnName.AutoSize = true;
            this.Label_EnName.BackColor = System.Drawing.Color.Transparent;
            this.Label_EnName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EnName.ForeColor = System.Drawing.Color.White;
            this.Label_EnName.Location = new System.Drawing.Point(53, 87);
            this.Label_EnName.Name = "Label_EnName";
            this.Label_EnName.Size = new System.Drawing.Size(193, 21);
            this.Label_EnName.TabIndex = 36;
            this.Label_EnName.Text = "Enter player name:";
            // 
            // Btn_enter
            // 
            this.Btn_enter.BackColor = System.Drawing.Color.Brown;
            this.Btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_enter.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_enter.ForeColor = System.Drawing.Color.White;
            this.Btn_enter.Location = new System.Drawing.Point(57, 175);
            this.Btn_enter.Name = "Btn_enter";
            this.Btn_enter.Size = new System.Drawing.Size(267, 42);
            this.Btn_enter.TabIndex = 35;
            this.Btn_enter.Text = "Enter";
            this.Btn_enter.UseVisualStyleBackColor = false;
            this.Btn_enter.Click += new System.EventHandler(this.Btn_enter_Click);
            // 
            // Textbox_Player
            // 
            this.Textbox_Player.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Player.Location = new System.Drawing.Point(57, 121);
            this.Textbox_Player.Multiline = true;
            this.Textbox_Player.Name = "Textbox_Player";
            this.Textbox_Player.Size = new System.Drawing.Size(267, 36);
            this.Textbox_Player.TabIndex = 34;
            this.Textbox_Player.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Title.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(179, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(262, 45);
            this.Label_Title.TabIndex = 32;
            this.Label_Title.Text = "Russian Roulette";
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 319);
            this.Controls.Add(this.Label_EnName);
            this.Controls.Add(this.Btn_enter);
            this.Controls.Add(this.Textbox_Player);
            this.Controls.Add(this.Label_Title);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "GameStart";
            this.Text = "Russian Roulette";
            this.Load += new System.EventHandler(this.GameStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_EnName;
        private System.Windows.Forms.Button Btn_enter;
        private System.Windows.Forms.TextBox Textbox_Player;
        private System.Windows.Forms.Label Label_Title;
    }
}

