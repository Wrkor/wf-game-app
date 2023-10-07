using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
namespace GamesApp
{
    public partial class ChangeData : Form
    {
        private byte choice;
        public ChangeData(byte choice)
        {
            InitializeComponent();
            this.choice = choice;
            LoginField.Text = "Введите логин:";
            PasswordField.Text = "Введите пароль:";
            NewField.Text = "Введите новый " + Choice() + ":";
        }
        private string Choice()
        {
            switch (choice)
            {
                case 0:
                    return "логин";
                case 1:
                    return "email";
                default:
                    return "пароль";
            }
        }
        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин:")
            {
                MessageBox.Show("Вы не ввели логин!");
                return;
            }
            if (NewField.Text == "Введите новый " + Choice() + ":")
            {
                MessageBox.Show("Вы не ввели новый " + Choice());
                return;
            }
            if (PasswordField.Text == "Введите пароль:")
            {
                MessageBox.Show("Вы не ввели пароль!");
                return;
            }

            DB db = new DB();
            string sql;
            switch (choice)
            {
                case 0:
                    sql = "UPDATE users SET login = @newlogin WHERE login = @login AND password = @password";
                    break;
                case 1:
                    sql = "UPDATE users SET email = @newemail WHERE login = @login AND password = @password";
                    break;
                default:
                    sql = "UPDATE users SET password = @newpassword WHERE login = @login AND password = @password";
                break;
            }
            MySqlCommand commandUpdate = new MySqlCommand(sql, db.GetConnection());
            switch (choice)
            {
                case 0:
                    commandUpdate.Parameters.AddWithValue("newlogin", NewField.Text);
                    break;
                case 1:
                    commandUpdate.Parameters.AddWithValue("newemail", NewField.Text);
                    break;
                default:
                    commandUpdate.Parameters.AddWithValue("newpassword", Hash(NewField.Text));
                    break;
            }
            commandUpdate.Parameters.AddWithValue("login", LoginField.Text);
            commandUpdate.Parameters.AddWithValue("password", Hash(PasswordField.Text));
            
            db.OpenConnection();

            try
            {
                if (commandUpdate.ExecuteNonQuery() == 1)
                {
                    if (choice == 0)
                        Program.loginUser = NewField.Text;
                    if (choice == 2)
                        Program.PasswordUser = Hash(NewField.Text);
                    MessageBox.Show($"Изменение прошло успешно, {LoginField.Text}! :D");
                    this.Hide();
                    UserProfile userProfile = new UserProfile();
                    userProfile.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Пользователь не найден! Перепроверьте введенные значения!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            db.CloseConnection();
        }

        public void TextBox_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name == "NewField" && NewField.Text.Trim() == "Введите новый " + Choice() + ":")
            {
                NewField.Text = "";
                if(choice == 2)
                    NewField.UseSystemPasswordChar = true;
                NewField.ForeColor = Color.Black;
            }
            if (((TextBox)sender).Name == "LoginField" && LoginField.Text.Trim() == "Введите логин:")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
            if (((TextBox)sender).Name == "PasswordField" && PasswordField.Text.Trim() == "Введите пароль:")
            {
                PasswordField.Text = "";
                PasswordField.UseSystemPasswordChar = true;
                PasswordField.ForeColor = Color.Black;
            }
        }
        public void TextBox_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name == "NewField" && NewField.Text.Trim() == "")
            {
                NewField.Text = "Введите новый " + Choice() + ":";
                if (choice == 2)
                    NewField.UseSystemPasswordChar = false;
                NewField.ForeColor = Color.Gray;
            }
            if (((TextBox)sender).Name == "LoginField" && LoginField.Text.Trim() == "")
            {
                LoginField.Text = "Введите логин:";
                LoginField.ForeColor = Color.Gray;
            }
            if (((TextBox)sender).Name == "PasswordField" && PasswordField.Text.Trim() == "")
            {
                PasswordField.Text = "Введите пароль:";
                PasswordField.UseSystemPasswordChar = false;
                PasswordField.ForeColor = Color.Gray;
            }
        }
        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void LinkUserProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserProfile userProfile = new UserProfile();
            userProfile.ShowDialog();
            this.Close();
        }

        private void ChangeData_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelMainChangeData;
        }
    }
}
