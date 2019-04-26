namespace ArrayListsStructuresEx
{
    partial class Form1
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
            this.btnFindGrade = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindGrade
            // 
            this.btnFindGrade.Location = new System.Drawing.Point(185, 116);
            this.btnFindGrade.Name = "btnFindGrade";
            this.btnFindGrade.Size = new System.Drawing.Size(75, 23);
            this.btnFindGrade.TabIndex = 0;
            this.btnFindGrade.Text = "&Find grade";
            this.btnFindGrade.UseVisualStyleBackColor = true;
            this.btnFindGrade.Click += new System.EventHandler(this.btnFindGrade_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(175, 59);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(80, 62);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 196);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnFindGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindGrade;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
    }
}

