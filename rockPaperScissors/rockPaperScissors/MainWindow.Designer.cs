namespace rockPaperScissors
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.lblComputerResult = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.BackColor = System.Drawing.Color.Transparent;
            this.PLAYER_PIC.Image = global::rockPaperScissors.Properties.Resources.rock_blue_final_top;
            this.PLAYER_PIC.Location = new System.Drawing.Point(96, 36);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(441, 341);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 0;
            this.PLAYER_PIC.TabStop = false;
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.BackColor = System.Drawing.Color.Transparent;
            this.CPU_PIC.Image = global::rockPaperScissors.Properties.Resources.rock_red_final_top;
            this.CPU_PIC.Location = new System.Drawing.Point(396, 36);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(441, 341);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 1;
            this.CPU_PIC.TabStop = false;
            this.CPU_PIC.Click += new System.EventHandler(this.CPU_PIC_Click);
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerResult.Location = new System.Drawing.Point(42, 117);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(73, 13);
            this.lblPlayerResult.TabIndex = 7;
            this.lblPlayerResult.Text = "Player Score: ";
            this.lblPlayerResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblComputerResult
            // 
            this.lblComputerResult.AutoSize = true;
            this.lblComputerResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComputerResult.Location = new System.Drawing.Point(790, 117);
            this.lblComputerResult.Name = "lblComputerResult";
            this.lblComputerResult.Size = new System.Drawing.Size(89, 13);
            this.lblComputerResult.TabIndex = 8;
            this.lblComputerResult.Text = "Computer Score: ";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.Transparent;
            this.lblDraw.Location = new System.Drawing.Point(429, 188);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(0, 25);
            this.lblDraw.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "P";
            this.pictureBox1.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "R";
            this.pictureBox2.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(581, 394);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "S";
            this.pictureBox3.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = global::rockPaperScissors.Properties.Resources.menu_button;
            this.btnMenu.Location = new System.Drawing.Point(793, -3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(148, 82);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 15;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(929, 522);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblComputerResult);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.PLAYER_PIC);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PLAYER_PIC;
        private System.Windows.Forms.PictureBox CPU_PIC;
        private System.Windows.Forms.Label lblPlayerResult;
        private System.Windows.Forms.Label lblComputerResult;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnMenu;
    }
}