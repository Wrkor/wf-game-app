namespace GamesApp
{
    partial class Auth
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
            this.LinkReg = new System.Windows.Forms.LinkLabel();
            this.AuthButton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.LabelMainAuth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkReg
            // 
            this.LinkReg.AutoSize = true;
            this.LinkReg.Font = new System.Drawing.Font("Panton ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkReg.Location = new System.Drawing.Point(178, 426);
            this.LinkReg.Name = "LinkReg";
            this.LinkReg.Size = new System.Drawing.Size(213, 19);
            this.LinkReg.TabIndex = 11;
            this.LinkReg.TabStop = true;
            this.LinkReg.Text = "Еще не зарегистрированы?";
            this.LinkReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkReg_LinkClicked);
            // 
            // AuthButton
            // 
            this.AuthButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.Location = new System.Drawing.Point(145, 322);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(294, 54);
            this.AuthButton.TabIndex = 10;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordField.Location = new System.Drawing.Point(172, 219);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(250, 31);
            this.PasswordField.TabIndex = 9;
            this.PasswordField.Text = "Введите пароль:";
            this.PasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LoginField.Location = new System.Drawing.Point(172, 151);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(250, 31);
            this.LoginField.TabIndex = 8;
            this.LoginField.Text = "Введите логин:";
            this.LoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.LoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LabelMainAuth
            // 
            this.LabelMainAuth.AutoSize = true;
            this.LabelMainAuth.Font = new System.Drawing.Font("Panton ExtraBold", 30F);
            this.LabelMainAuth.Location = new System.Drawing.Point(157, 41);
            this.LabelMainAuth.Name = "LabelMainAuth";
            this.LabelMainAuth.Size = new System.Drawing.Size(265, 48);
            this.LabelMainAuth.TabIndex = 7;
            this.LabelMainAuth.Text = "Авторизация";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.LinkReg);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.LabelMainAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkReg;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label LabelMainAuth;
    }
}