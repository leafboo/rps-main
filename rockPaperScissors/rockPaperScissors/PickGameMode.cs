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
    public partial class PickGameMode : Form
    {
        public PickGameMode()
        {
            InitializeComponent();
        }

        private void btnEndless_Click(object sender, EventArgs e)
        {
            string gameMode = "endless";
            MainWindow mainWindow = new MainWindow(gameMode);
            mainWindow.Show();
            Visible = false;
        }


        private void btnBestOf_Click_1(object sender, EventArgs e)
        {
            bestOfFive pickBestOf = new bestOfFive();
            pickBestOf.Show();
            Visible = false;
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
