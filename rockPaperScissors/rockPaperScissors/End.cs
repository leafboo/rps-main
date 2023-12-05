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
        public End()
        {
            InitializeComponent();
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
