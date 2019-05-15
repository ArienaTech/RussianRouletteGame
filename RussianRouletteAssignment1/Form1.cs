using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteAssignment1
{
    public partial class GameStart : Form
    {
        public GameStart()
        {
            InitializeComponent();
        }

        private void Btn_enter_Click(object sender, EventArgs e)
        {
            if (Textbox_Player.Text != "")
            {
                this.Hide();
                GameMain fr = new GameMain(Textbox_Player.Text);
                fr.Closed += (s, args) => this.Close();
                fr.Show();
            }
            else
            {
                MessageBox.Show("You must enter the name first");
                Textbox_Player.Focus();
            }
        }
    private void GameStart_Load(object sender, EventArgs e)
        {
            GameSound music = new GameSound();
            music.background1_music();
        }
    }
}
