namespace rockPaperScissors
{
    partial class PickBestOf
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnTwenty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Best of:";
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(83, 178);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 23);
            this.btnFive.TabIndex = 1;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(208, 178);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 2;
            this.btnTen.Text = "10";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnTwenty
            // 
            this.btnTwenty.Location = new System.Drawing.Point(342, 178);
            this.btnTwenty.Name = "btnTwenty";
            this.btnTwenty.Size = new System.Drawing.Size(75, 23);
            this.btnTwenty.TabIndex = 3;
            this.btnTwenty.Text = "20";
            this.btnTwenty.UseVisualStyleBackColor = true;
            this.btnTwenty.Click += new System.EventHandler(this.btnTwenty_Click);
            // 
            // PickBestOf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.Controls.Add(this.btnTwenty);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.label1);
            this.Name = "PickBestOf";
            this.Text = "PickBestOf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnTwenty;
    }
}