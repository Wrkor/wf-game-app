using System;
using System.Windows.Forms;

namespace GamesApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void PingPongButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PingPong pingPong = new PingPong();
            pingPong.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelMainMenu;
        }

        private void UserProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile userProfile = new UserProfile();
            userProfile.ShowDialog();
            this.Close();
        }

        private void MarioButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке :D");
        }
    }
}
