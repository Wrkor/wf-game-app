using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace GamesApp
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            EmailField.Text = "Введите email:";
            LoginField.Text = "Введите логин:";
            PasswordField.Text = "Введите пароль:";
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelMainReg;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин:")
            {
                MessageBox.Show("Вы не введи логин!");
                return;
            }
            if (EmailField.Text == "Введите email:")
            {
                MessageBox.Show("Вы не введи email!");
                return;
            }
            if (PasswordField.Text == "Введите пароль:")
            {
                MessageBox.Show("Вы не введи пароль!");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (login, email, password) VALUES(@login, @email, @password)", db.GetConnection());
            command.Parameters.AddWithValue("login",LoginField.Text);
            command.Parameters.AddWithValue("email", EmailField.Text);
            command.Parameters.AddWithValue("password", Hash(PasswordField.Text));

            db.OpenConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт создан! Добро пожаловать " + LoginField.Text);
                    Program.loginUser = LoginField.Text;
                    Program.PasswordUser = Hash(PasswordField.Text);
                    Program.scoreBest = 0;
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Ошибка при выполнении!");
            } catch (MySqlException ex)
            {
                if (ex.Message.Contains("duplicate entry")) MessageBox.Show("К сожалению, такой логин уже существует!");
                else MessageBox.Show(ex.Message);
            }
            db.CloseConnection();
        }

        private void LinkAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.ShowDialog();
            this.Close();
        }

        public void TextBox_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name == "EmailField" && EmailField.Text.Trim() == "Введите email:")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
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
            if (((TextBox)sender).Name == "EmailField" && EmailField.Text.Trim() == "")
            {
                EmailField.Text = "Введите email:";
                EmailField.ForeColor = Color.Gray;
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
            using(SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp); 
                return Convert.ToBase64String(hash);
            }
        }
    }
}
