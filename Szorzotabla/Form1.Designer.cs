namespace Szorzotabla
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
            this.AnswerButton4 = new System.Windows.Forms.Button();
            this.AnswerButton2 = new System.Windows.Forms.Button();
            this.AnswerButton1 = new System.Windows.Forms.Button();
            this.AnswerButton3 = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnswerButton4
            // 
            this.AnswerButton4.Location = new System.Drawing.Point(287, 12);
            this.AnswerButton4.Name = "AnswerButton4";
            this.AnswerButton4.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton4.TabIndex = 0;
            this.AnswerButton4.UseVisualStyleBackColor = true;
            this.AnswerButton4.Click += new System.EventHandler(this.ClickAnswerButton);
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.Location = new System.Drawing.Point(102, 12);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton2.TabIndex = 1;
            this.AnswerButton2.UseVisualStyleBackColor = true;
            this.AnswerButton2.Click += new System.EventHandler(this.ClickAnswerButton);
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.Location = new System.Drawing.Point(12, 12);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton1.TabIndex = 2;
            this.AnswerButton1.UseVisualStyleBackColor = true;
            this.AnswerButton1.Click += new System.EventHandler(this.ClickAnswerButton);
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.Location = new System.Drawing.Point(194, 12);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton3.TabIndex = 3;
            this.AnswerButton3.UseVisualStyleBackColor = true;
            this.AnswerButton3.Click += new System.EventHandler(this.ClickAnswerButton);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(410, 22);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(36, 13);
            this.MainLabel.TabIndex = 5;
            this.MainLabel.Text = "Empty";
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.Location = new System.Drawing.Point(12, 60);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(99, 13);
            this.CorrectLabel.TabIndex = 6;
            this.CorrectLabel.Text = "Helyes valaszok:  0";
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Location = new System.Drawing.Point(12, 87);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(108, 13);
            this.WrongLabel.TabIndex = 7;
            this.WrongLabel.Text = "Helytelen válaszok: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 769);
            this.Controls.Add(this.WrongLabel);
            this.Controls.Add(this.CorrectLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnswerButton4;
        private System.Windows.Forms.Button AnswerButton2;
        private System.Windows.Forms.Button AnswerButton1;
        private System.Windows.Forms.Button AnswerButton3;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label CorrectLabel;
        private System.Windows.Forms.Label WrongLabel;
    }
}

