namespace GamesApp
{
    partial class Reg
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
            this.LabelMainReg = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.LinkAuth = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // LabelMainReg
            // 
            this.LabelMainReg.AutoSize = true;
            this.LabelMainReg.Font = new System.Drawing.Font("Panton ExtraBold", 30F);
            this.LabelMainReg.Location = new System.Drawing.Point(155, 43);
            this.LabelMainReg.Name = "LabelMainReg";
            this.LabelMainReg.Size = new System.Drawing.Size(259, 48);
            this.LabelMainReg.TabIndex = 1;
            this.LabelMainReg.Text = "Регистрация";
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LoginField.Location = new System.Drawing.Point(161, 147);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(250, 31);
            this.LoginField.TabIndex = 2;
            this.LoginField.Text = "Введите логин:";
            this.LoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.LoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailField.Location = new System.Drawing.Point(161, 208);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(250, 31);
            this.EmailField.TabIndex = 3;
            this.EmailField.Text = "Введите email:";
            this.EmailField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.EmailField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordField.Location = new System.Drawing.Point(161, 270);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(250, 31);
            this.PasswordField.TabIndex = 4;
            this.PasswordField.Text = "Введите пароль:";
            this.PasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // RegButton
            // 
            this.RegButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(134, 346);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(294, 54);
            this.RegButton.TabIndex = 5;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // LinkAuth
            // 
            this.LinkAuth.AutoSize = true;
            this.LinkAuth.Font = new System.Drawing.Font("Panton ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkAuth.Location = new System.Drawing.Point(173, 427);
            this.LinkAuth.Name = "LinkAuth";
            this.LinkAuth.Size = new System.Drawing.Size(208, 19);
            this.LinkAuth.TabIndex = 6;
            this.LinkAuth.TabStop = true;
            this.LinkAuth.Text = "Зарегистрированы? Войти";
            this.LinkAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAuth_LinkClicked);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.LinkAuth);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.LabelMainReg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelMainReg;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.LinkLabel LinkAuth;
    }
}