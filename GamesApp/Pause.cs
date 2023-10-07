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

namespace GamesApp
{
    public partial class Pause : Form
    {
        ushort score; bool lose, exite;

        public Pause(ushort score, bool lose)
        {
            InitializeComponent();
            Cursor.Show();
            this.score = score;
            this.lose = lose;
            ScoreLabel.Text = "Счет: " + this.score;
            if (this.lose)
            {
                RestartButton.Visible = true;
            }
            else
            {
                ContinueButton.Visible = true;
            }
            if (lose && score > Program.scoreBest)
            {
                NewScoreLabel.Visible = true;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE users SET scorePingPong = @scorePingPong WHERE login = @login AND password=@password", db.GetConnection());
                command.Parameters.AddWithValue("login", Program.loginUser);
                command.Parameters.AddWithValue("password", Program.PasswordUser);
                command.Parameters.AddWithValue("scorePingPong", score);
                db.OpenConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
                Program.scoreBest = score;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            exite = false;
            Choice();
            this.Close();
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Cursor.Hide();
            exite = false;
            Choice();
            this.Close();
        }
        private void ExiteButton_Click(object sender, EventArgs e)
        {
            exite = true;
            Choice();
            this.Close();

        }
        public byte Choice()
        {
            if(!lose && !exite)
                return 1;
            if (lose && !exite)
                return 2;
            else
                return 0;
        }

        
    }
}
