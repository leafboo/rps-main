using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace rockPaperScissors
{
    public partial class Start : Form
    {
        int continueMusic = 0;
        SoundPlayer player = new SoundPlayer();
        public Start()
        {
            InitializeComponent();
            player.SoundLocation = @"C:\Users\Desktop\Desktop\rps-school-main\rockPaperScissors\rockPaperScissors\bin\Debug\videoplayback1.wav";

        }
        public Start(int continueMusic)
        {
            this.continueMusic = continueMusic;
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PickGameMode pickGameMode = new PickGameMode();
            pickGameMode.Show();
            Visible = false;
        }

        private void picStart_Click(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PickGameMode pickGameMode = new PickGameMode();
            pickGameMode.Show();
            Visible = false;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            if(continueMusic == 0)
            {
                player.Play();
                player.PlayLooping();
            }
            
        }
    }
}
