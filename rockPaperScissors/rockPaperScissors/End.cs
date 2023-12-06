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
    public partial class End : Form
    {
        string result;

        public End(string result)
        {
            this.result = result;
            InitializeComponent();
            
            if (result == "win")
            {
                picResult.Image = Properties.Resources.you_win_1_;
            } 
            else if (result == "lose")
            {
                picResult.Image = Properties.Resources.you_lose;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            Visible = false;
        }
    }
}
