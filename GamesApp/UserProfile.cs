using System;
using System.Windows.Forms;

namespace GamesApp
{
    public partial class UserProfile : Form
    {
        private string userLogin = Program.loginUser;
        public UserProfile()
        {
            InitializeComponent();
            LabelMainUserProfile.Text = $"Как настроение, {userLogin}? :D";
            ScorePingPong.Text = "Ping Pong...................................." + Program.scoreBest;
        }

        private void ExiteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.ShowDialog();
            this.Close();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void NewLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeData changeData = new ChangeData(0);
            changeData.ShowDialog();
            this.Close();
        }

        private void NewEmailButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeData changeData = new ChangeData(1);
            changeData.ShowDialog();
            this.Close();
        }

        private void NewPasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeData changeData = new ChangeData(2);
            changeData.ShowDialog();
            this.Close();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelMainUserProfile;
        }
    }
}
