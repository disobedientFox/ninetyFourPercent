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
    public partial class RegisterForm : Form
    {
        GameContext context = new GameContext();


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
    }
}
