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
                    this.Close();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    Hide();
                }
            }
            catch
            {
                MessageBox.Show("Player with login " + login_tbox.Text + " doesn't exist", "Something went wrong :c");
            }
        }
    }
}
