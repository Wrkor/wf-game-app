namespace GamesApp
{
    partial class Pause
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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ExiteButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.NewScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueButton.Location = new System.Drawing.Point(62, 55);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(247, 54);
            this.ContinueButton.TabIndex = 6;
            this.ContinueButton.Text = "Продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Visible = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ExiteButton
            // 
            this.ExiteButton.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExiteButton.Location = new System.Drawing.Point(109, 117);
            this.ExiteButton.Name = "ExiteButton";
            this.ExiteButton.Size = new System.Drawing.Size(165, 32);
            this.ExiteButton.TabIndex = 7;
            this.ExiteButton.Text = "Выйти";
            this.ExiteButton.UseVisualStyleBackColor = true;
            this.ExiteButton.Click += new System.EventHandler(this.ExiteButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(134, 11);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(102, 32);
            this.ScoreLabel.TabIndex = 8;
            this.ScoreLabel.Text = "Счет: 0";
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(62, 56);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(247, 54);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Заново";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // NewScoreLabel
            // 
            this.NewScoreLabel.AutoSize = true;
            this.NewScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewScoreLabel.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewScoreLabel.Location = new System.Drawing.Point(258, 10);
            this.NewScoreLabel.Name = "NewScoreLabel";
            this.NewScoreLabel.Size = new System.Drawing.Size(114, 32);
            this.NewScoreLabel.TabIndex = 10;
            this.NewScoreLabel.Text = "Рекорд!";
            this.NewScoreLabel.Visible = false;
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.NewScoreLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ExiteButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ContinueButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пауза";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button ExiteButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label NewScoreLabel;
    }
}