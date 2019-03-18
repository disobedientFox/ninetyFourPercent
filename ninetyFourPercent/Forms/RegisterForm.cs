using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ninetyFourPercent
{
    public partial class RegisterForm : Form
    {
        GameContext context = new GameContext();

        private bool mouseIsDown = false;
        private Point firstPoint;


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (context.Players.ToList().Where(r => r.Login == login_tbox.Text).Count() == 0)
            {
                if (password_tbox.Text.Equals(passwordConfirm_tbox.Text))
                {
                    Player player = new Player();
                    player.Login = login_tbox.Text;
                    player.Password = PasswordManager.HashPassword(password_tbox.Text);
                    player.Money = 600;

                    using (var ctx = new GameContext())
                    {
                        ctx.Players.Add(player);
                        ctx.SaveChanges();
                    }
                    MessageBox.Show("User was successfully created", "Congrats");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "Pay attention");
                    password_tbox.Text = "";
                    passwordConfirm_tbox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("User already exists", "Something went wrong :c");
            }
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
