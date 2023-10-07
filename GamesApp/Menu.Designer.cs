namespace GamesApp
{
    partial class Menu
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
            this.LabelMainMenu = new System.Windows.Forms.Label();
            this.PingPongButton = new System.Windows.Forms.Button();
            this.MarioButton = new System.Windows.Forms.Button();
            this.UserProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelMainMenu
            // 
            this.LabelMainMenu.AutoSize = true;
            this.LabelMainMenu.Font = new System.Drawing.Font("Panton ExtraBold", 35F);
            this.LabelMainMenu.Location = new System.Drawing.Point(212, 48);
            this.LabelMainMenu.Name = "LabelMainMenu";
            this.LabelMainMenu.Size = new System.Drawing.Size(485, 56);
            this.LabelMainMenu.TabIndex = 0;
            this.LabelMainMenu.Text = "Welcome to GameApp";
            // 
            // PingPongButton
            // 
            this.PingPongButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingPongButton.Location = new System.Drawing.Point(80, 180);
            this.PingPongButton.Name = "PingPongButton";
            this.PingPongButton.Size = new System.Drawing.Size(300, 100);
            this.PingPongButton.TabIndex = 1;
            this.PingPongButton.Text = "Ping Pong";
            this.PingPongButton.UseVisualStyleBackColor = true;
            this.PingPongButton.Click += new System.EventHandler(this.PingPongButton_Click);
            // 
            // MarioButton
            // 
            this.MarioButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarioButton.Location = new System.Drawing.Point(520, 180);
            this.MarioButton.Name = "MarioButton";
            this.MarioButton.Size = new System.Drawing.Size(300, 100);
            this.MarioButton.TabIndex = 2;
            this.MarioButton.Text = "Mario";
            this.MarioButton.UseVisualStyleBackColor = true;
            this.MarioButton.Click += new System.EventHandler(this.MarioButton_Click);
            // 
            // UserProfileButton
            // 
            this.UserProfileButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserProfileButton.Location = new System.Drawing.Point(300, 350);
            this.UserProfileButton.Name = "UserProfileButton";
            this.UserProfileButton.Size = new System.Drawing.Size(300, 100);
            this.UserProfileButton.TabIndex = 3;
            this.UserProfileButton.Text = "User Profile";
            this.UserProfileButton.UseVisualStyleBackColor = true;
            this.UserProfileButton.Click += new System.EventHandler(this.UserProfileButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.UserProfileButton);
            this.Controls.Add(this.MarioButton);
            this.Controls.Add(this.PingPongButton);
            this.Controls.Add(this.LabelMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMainMenu;
        private System.Windows.Forms.Button PingPongButton;
        private System.Windows.Forms.Button MarioButton;
        private System.Windows.Forms.Button UserProfileButton;
    }
}