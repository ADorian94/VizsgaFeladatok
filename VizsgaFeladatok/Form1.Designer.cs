namespace VizsgaFeladatok
{
    partial class Szamkitalalo
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
            this.CommandLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommandLabel.Location = new System.Drawing.Point(71, 28);
            this.CommandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(370, 24);
            this.CommandLabel.TabIndex = 1;
            this.CommandLabel.Text = "Gondoltam egy 7-jegyű számra. Mi az?";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(230, 102);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(43, 17);
            this.NumberLabel.TabIndex = 2;
            this.NumberLabel.Text = "-------";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Location = new System.Drawing.Point(12, 170);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(479, 100);
            this.ButtonPanel.TabIndex = 5;
            // 
            // Szamkitalalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 282);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.CommandLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Szamkitalalo";
            this.Text = "Számkitaláló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
    }
}

