namespace GamesApp
{
    partial class ChangeData
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
            this.LinkUserProfile = new System.Windows.Forms.LinkLabel();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.NewField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.LabelMainChangeData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkUserProfile
            // 
            this.LinkUserProfile.AutoSize = true;
            this.LinkUserProfile.Font = new System.Drawing.Font("Panton ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkUserProfile.Location = new System.Drawing.Point(227, 412);
            this.LinkUserProfile.Name = "LinkUserProfile";
            this.LinkUserProfile.Size = new System.Drawing.Size(111, 19);
            this.LinkUserProfile.TabIndex = 12;
            this.LinkUserProfile.TabStop = true;
            this.LinkUserProfile.Text = "Передумали?";
            this.LinkUserProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUserProfile_LinkClicked);
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Font = new System.Drawing.Font("Panton ExtraBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeDataButton.Location = new System.Drawing.Point(145, 332);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(294, 54);
            this.ChangeDataButton.TabIndex = 11;
            this.ChangeDataButton.Text = "Изменить";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordField.Location = new System.Drawing.Point(172, 181);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(250, 31);
            this.PasswordField.TabIndex = 10;
            this.PasswordField.Text = "Введите пароль:";
            this.PasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // NewField
            // 
            this.NewField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NewField.Location = new System.Drawing.Point(172, 265);
            this.NewField.Name = "NewField";
            this.NewField.Size = new System.Drawing.Size(250, 31);
            this.NewField.TabIndex = 9;
            this.NewField.Text = "Введите email:";
            this.NewField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.NewField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Panton ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LoginField.Location = new System.Drawing.Point(172, 122);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(250, 31);
            this.LoginField.TabIndex = 8;
            this.LoginField.Text = "Введите логин:";
            this.LoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.LoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LabelMainChangeData
            // 
            this.LabelMainChangeData.AutoSize = true;
            this.LabelMainChangeData.Font = new System.Drawing.Font("Panton ExtraBold", 30F);
            this.LabelMainChangeData.Location = new System.Drawing.Point(99, 29);
            this.LabelMainChangeData.Name = "LabelMainChangeData";
            this.LabelMainChangeData.Size = new System.Drawing.Size(376, 48);
            this.LabelMainChangeData.TabIndex = 7;
            this.LabelMainChangeData.Text = "Изменение данных";
            // 
            // ChangeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.LinkUserProfile);
            this.Controls.Add(this.ChangeDataButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.NewField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.LabelMainChangeData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение данных";
            this.Load += new System.EventHandler(this.ChangeData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkUserProfile;
        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox NewField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label LabelMainChangeData;
    }
}