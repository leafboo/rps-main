﻿using System;
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
    public partial class bestOfFive : Form
    {
        string gameMode = "bestOf";
        public bestOfFive()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void PickBestOf_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            int continueMusic = 1;
            Start start = new Start(continueMusic);
            start.Show();
            Visible = false;
        }
    }
}
