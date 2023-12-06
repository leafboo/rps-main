namespace rockPaperScissors
{
    partial class PickGameMode
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
            this.btnEndless = new System.Windows.Forms.Button();
            this.btnBestOf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEndless
            // 
            this.btnEndless.Location = new System.Drawing.Point(205, 259);
            this.btnEndless.Name = "btnEndless";
            this.btnEndless.Size = new System.Drawing.Size(75, 23);
            this.btnEndless.TabIndex = 1;
            this.btnEndless.Text = "Endless";
            this.btnEndless.UseVisualStyleBackColor = true;
            this.btnEndless.Click += new System.EventHandler(this.btnEndless_Click);
            // 
            // btnBestOf
            // 
            this.btnBestOf.Location = new System.Drawing.Point(400, 259);
            this.btnBestOf.Name = "btnBestOf";
            this.btnBestOf.Size = new System.Drawing.Size(75, 23);
            this.btnBestOf.TabIndex = 2;
            this.btnBestOf.Text = "Best of";
            this.btnBestOf.UseVisualStyleBackColor = true;
            this.btnBestOf.Click += new System.EventHandler(this.btnBestOf_Click_1);
            // 
            // PickGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::rockPaperScissors.Properties.Resources.gamemode_dark_mode;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(705, 409);
            this.Controls.Add(this.btnBestOf);
            this.Controls.Add(this.btnEndless);
            this.DoubleBuffered = true;
            this.Name = "PickGameMode";
            this.Text = "PickGameMode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEndless;
        private System.Windows.Forms.Button btnBestOf;
    }
}