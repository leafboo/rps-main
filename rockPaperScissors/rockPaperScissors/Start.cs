using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rockPaperScissors
{
    public partial class Start : Form
    {
        
        public Start()
        {
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
          
        }
    }
}
