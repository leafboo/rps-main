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
    public partial class PickBestOf : Form
    {
        string gameMode = "bestOf";
        public PickBestOf()
        {
            InitializeComponent();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            int bestOf = 5;
            MainWindow mainWindow = new MainWindow(gameMode, bestOf);
            mainWindow.Show();
            Visible = false; 
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            int bestOf = 10;
            MainWindow mainWindow = new MainWindow(gameMode, bestOf);
            mainWindow.Show();
            Visible = false;
        }

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            int bestOf = 20;
            MainWindow mainWindow = new MainWindow(gameMode, bestOf);
            mainWindow.Show();
            Visible = false;
        }
    }
}
