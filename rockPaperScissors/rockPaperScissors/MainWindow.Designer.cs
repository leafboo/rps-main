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
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.lblComputerResult = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.btnChangeGameMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.Location = new System.Drawing.Point(166, 137);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(100, 100);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 0;
            this.PLAYER_PIC.TabStop = false;
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.Location = new System.Drawing.Point(527, 137);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(100, 100);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 1;
            this.CPU_PIC.TabStop = false;
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(82, 320);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(111, 35);
            this.btnRock.TabIndex = 2;
            this.btnRock.Tag = "R";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(313, 320);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(111, 35);
            this.btnPaper.TabIndex = 3;
            this.btnPaper.Tag = "P";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(545, 320);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(111, 35);
            this.btnScissors.TabIndex = 4;
            this.btnScissors.Tag = "S";
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer";
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.Location = new System.Drawing.Point(176, 252);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(73, 13);
            this.lblPlayerResult.TabIndex = 7;
            this.lblPlayerResult.Text = "Player Score: ";
            this.lblPlayerResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblComputerResult
            // 
            this.lblComputerResult.AutoSize = true;
            this.lblComputerResult.Location = new System.Drawing.Point(542, 261);
            this.lblComputerResult.Name = "lblComputerResult";
            this.lblComputerResult.Size = new System.Drawing.Size(89, 13);
            this.lblComputerResult.TabIndex = 8;
            this.lblComputerResult.Text = "Computer Score: ";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Location = new System.Drawing.Point(383, 183);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(16, 13);
            this.lblDraw.TabIndex = 9;
            this.lblDraw.Text = "---";
            // 
            // btnChangeGameMode
            // 
            this.btnChangeGameMode.Location = new System.Drawing.Point(645, 415);
            this.btnChangeGameMode.Name = "btnChangeGameMode";
            this.btnChangeGameMode.Size = new System.Drawing.Size(127, 23);
            this.btnChangeGameMode.TabIndex = 10;
            this.btnChangeGameMode.Text = "Change Game mode";
            this.btnChangeGameMode.UseVisualStyleBackColor = true;
            this.btnChangeGameMode.Click += new System.EventHandler(this.btnChangeGameMode_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeGameMode);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblComputerResult);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.PLAYER_PIC);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PLAYER_PIC;
        private System.Windows.Forms.PictureBox CPU_PIC;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerResult;
        private System.Windows.Forms.Label lblComputerResult;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Button btnChangeGameMode;
    }
}