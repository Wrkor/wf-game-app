using System;
using System.Drawing;
using System.Windows.Forms;

namespace GamesApp
{
    public partial class PingPong : Form
    {
        private int _speedVer = 4, _speedHor = 5, _speedPlatform = 15;
        public ushort score = 0;
        

        public PingPong()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private void PingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer.Enabled = false;
                Pause pause = new Pause(score, false);
                pause.ShowDialog();
                switch(pause.Choice())
                {
                    case 0:
                        this.Hide();
                        Menu menu = new Menu();
                        menu.ShowDialog();
                        this.Close();
                        break;
                    case 1:
                        timer.Enabled = true;
                        break;
                }
            }
            else if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && GamePlatform.Left >= GameArea.Left)
                GamePlatform.Left -= _speedPlatform;
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && GamePlatform.Right <= GameArea.Right)
                GamePlatform.Left += _speedPlatform;

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            GameBall.Left -= _speedHor;
            GameBall.Top -= _speedVer;
            if (GameBall.Top <= GameArea.Top)
                _speedVer *= -1;
            if (GameBall.Left <= GameArea.Left)
                _speedHor *= -1;
            if (GameBall.Right >= GameArea.Right)
                _speedHor *= -1;
            if (GameBall.Bottom >= GameArea.Bottom)
            {
                timer.Enabled = false;
                Pause pause = new Pause(score, true);
                pause.ShowDialog();
                switch (pause.Choice())
                {
                    case 0:
                        this.Hide();
                        Menu menu = new Menu();
                        menu.ShowDialog();
                        this.Close();
                        break;
                    case 2:
                        score = 0;
                        ScoreLabel.Text = $"Счет: {score}";
                        GameBall.Left = 430;
                        GameBall.Top = 330;
                        GamePlatform.Left = 340;
                        GamePlatform.Top = 450;
                        _speedVer = 4; _speedHor = 5;
                        timer.Enabled = true;
                        break;
                }
            }

            if (GameBall.Bottom >= GamePlatform.Top && GameBall.Bottom <= GamePlatform.Bottom && GameBall.Left >= GamePlatform.Left - 39 && GameBall.Right <= GamePlatform.Right + 39)
            {
                _speedVer *= -1;
                score++;
                if (score % 3 == 0 && score <= 100)
                {
                    _speedVer++;
                    _speedHor++;
                }
                ScoreLabel.Text = $"Счет: {score}";
                Random random = new Random();
                GameArea.BackColor = Color.FromArgb(random.Next(180, 230), random.Next(180, 230), random.Next(180, 230));
            }

        }
    }
}
