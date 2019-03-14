using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ninetyFourPercent
{
    public partial class LoginForm : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        GameContext context = new GameContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var player = context.Players.ToList().Single(r => r.Login == login_tbox.Text);
                if (PasswordManager.VerifyHashedPassword(player.Password, password_tbox.Text))
                {
                    PlayerInfo.LOGIN = player.Login;
                    PlayerInfo.MONEY = player.Money;
                    PlayerInfo.ID = player.Id;

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password", "Something went wrong :c");
                }
            }
            catch
            {
                MessageBox.Show("User with login " + login_tbox.Text + " doesn't exist", "Something went wrong :c");
            }
        }

        private void create_acc_label_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }

        private void close_panel_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void minimize_panel_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
    }
}
