using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace GamesApp
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            LoginField.Text = "Введите логин:";
            PasswordField.Text = "Введите пароль:";
        }
        public void TextBox_Enter(object sender, EventArgs e)
        {
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

        private void Auth_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelMainAuth;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин:")
            {
                MessageBox.Show("Вы не ввели логин!");
                return;
            }
            if (PasswordField.Text == "Введите пароль:")
            {
                MessageBox.Show("Вы не ввели пароль!");
                return;
            }

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM users WHERE login=@login AND password=@password", db.GetConnection());
            command.Parameters.AddWithValue("login", LoginField.Text);
            command.Parameters.AddWithValue("password", Hash(PasswordField.Text));
            db.OpenConnection();
            int countUser = Convert.ToInt32(command.ExecuteScalar());
            if (countUser>0)
            {
                Program.PasswordUser = Hash(PasswordField.Text);
                Program.loginUser = LoginField.Text;
                MySqlCommand commandScore = new MySqlCommand("SELECT * FROM users WHERE login=@login AND password=@password", db.GetConnection());
                commandScore.Parameters.AddWithValue("login", Program.loginUser);
                commandScore.Parameters.AddWithValue("password", Hash(PasswordField.Text));
                MySqlDataReader reader = commandScore.ExecuteReader();
                reader.Read();
                object scoreBest = reader["scorePingPong"];
                Program.scoreBest = Convert.ToUInt16(scoreBest);
                reader.Close();
                MessageBox.Show($"С возвращением {LoginField.Text}! :D");
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("К сожалению, пользователь не найден, перепроверьте введенные данные!");
            }
            db.CloseConnection();
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
        private void LinkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.ShowDialog();
            this.Close();
        }
    }
}
