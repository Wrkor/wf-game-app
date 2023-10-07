namespace GamesApp
{
    partial class UserProfile
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
            this.LabelMainUserProfile = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.ExiteButton = new System.Windows.Forms.Button();
            this.NewLoginButton = new System.Windows.Forms.Button();
            this.NewEmailButton = new System.Windows.Forms.Button();
            this.NewPasswordButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScorePingPong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelMainUserProfile
            // 
            this.LabelMainUserProfile.AutoSize = true;
            this.LabelMainUserProfile.Font = new System.Drawing.Font("Panton ExtraBold", 30F);
            this.LabelMainUserProfile.Location = new System.Drawing.Point(225, 29);
            this.LabelMainUserProfile.Name = "LabelMainUserProfile";
            this.LabelMainUserProfile.Size = new System.Drawing.Size(322, 48);
            this.LabelMainUserProfile.TabIndex = 1;
            this.LabelMainUserProfile.Text = "Как настроение,";
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.Location = new System.Drawing.Point(21, 26);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(145, 64);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ExiteButton
            // 
            this.ExiteButton.Font = new System.Drawing.Font("Panton ExtraBold", 15F);
            this.ExiteButton.Location = new System.Drawing.Point(664, 462);
            this.ExiteButton.Name = "ExiteButton";
            this.ExiteButton.Size = new System.Drawing.Size(208, 37);
            this.ExiteButton.TabIndex = 3;
            this.ExiteButton.Text = "Выйти из профиля";
            this.ExiteButton.UseVisualStyleBackColor = true;
            this.ExiteButton.Click += new System.EventHandler(this.ExiteButton_Click);
            // 
            // NewLoginButton
            // 
            this.NewLoginButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLoginButton.Location = new System.Drawing.Point(21, 268);
            this.NewLoginButton.Name = "NewLoginButton";
            this.NewLoginButton.Size = new System.Drawing.Size(220, 50);
            this.NewLoginButton.TabIndex = 4;
            this.NewLoginButton.Text = "Логин";
            this.NewLoginButton.UseVisualStyleBackColor = true;
            this.NewLoginButton.Click += new System.EventHandler(this.NewLoginButton_Click);
            // 
            // NewEmailButton
            // 
            this.NewEmailButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewEmailButton.Location = new System.Drawing.Point(21, 350);
            this.NewEmailButton.Name = "NewEmailButton";
            this.NewEmailButton.Size = new System.Drawing.Size(220, 50);
            this.NewEmailButton.TabIndex = 5;
            this.NewEmailButton.Text = "Email";
            this.NewEmailButton.UseVisualStyleBackColor = true;
            this.NewEmailButton.Click += new System.EventHandler(this.NewEmailButton_Click);
            // 
            // NewPasswordButton
            // 
            this.NewPasswordButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordButton.Location = new System.Drawing.Point(21, 433);
            this.NewPasswordButton.Name = "NewPasswordButton";
            this.NewPasswordButton.Size = new System.Drawing.Size(220, 50);
            this.NewPasswordButton.TabIndex = 6;
            this.NewPasswordButton.Text = "Пароль";
            this.NewPasswordButton.UseVisualStyleBackColor = true;
            this.NewPasswordButton.Click += new System.EventHandler(this.NewPasswordButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Panton ExtraBold", 20F);
            this.ChangeLabel.Location = new System.Drawing.Point(62, 214);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(144, 32);
            this.ChangeLabel.TabIndex = 7;
            this.ChangeLabel.Text = "Изменить:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Panton ExtraBold", 20F);
            this.ScoreLabel.Location = new System.Drawing.Point(533, 124);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(195, 32);
            this.ScoreLabel.TabIndex = 8;
            this.ScoreLabel.Text = "Таблица очков";
            // 
            // ScorePingPong
            // 
            this.ScorePingPong.AutoSize = true;
            this.ScorePingPong.Font = new System.Drawing.Font("Panton ExtraBold", 22F);
            this.ScorePingPong.Location = new System.Drawing.Point(398, 188);
            this.ScorePingPong.Name = "ScorePingPong";
            this.ScorePingPong.Size = new System.Drawing.Size(420, 36);
            this.ScorePingPong.TabIndex = 9;
            this.ScorePingPong.Text = "Ping Pong....................................0";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.ScorePingPong);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.NewPasswordButton);
            this.Controls.Add(this.NewEmailButton);
            this.Controls.Add(this.NewLoginButton);
            this.Controls.Add(this.ExiteButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.LabelMainUserProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Профиль пользователя";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMainUserProfile;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button ExiteButton;
        private System.Windows.Forms.Button NewLoginButton;
        private System.Windows.Forms.Button NewEmailButton;
        private System.Windows.Forms.Button NewPasswordButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScorePingPong;
    }
}