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
    }
}
