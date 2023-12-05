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

        private void button1_Click(object sender, EventArgs e)
        {
            string gameMode = "endless";
            MainWindow mainWindow = new MainWindow(gameMode);   
            mainWindow.Show();
            Visible = false;
        }

        private void btnBestOf_Click(object sender, EventArgs e)
        {
            PickBestOf pickBestOf = new PickBestOf();
            pickBestOf.Show();
            Visible = false;
        }
    }
}
