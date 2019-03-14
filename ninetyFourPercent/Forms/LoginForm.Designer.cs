namespace ninetyFourPercent
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.top_panel = new System.Windows.Forms.Panel();
            this.start_panel = new System.Windows.Forms.Panel();
            this.create_acc_label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_tbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_tbox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.start_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(85)))));
            this.top_panel.Controls.Add(this.button1);
            this.top_panel.Controls.Add(this.button2);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(5);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(700, 31);
            this.top_panel.TabIndex = 0;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // start_panel
            // 
            this.start_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.start_panel.Controls.Add(this.panel1);
            this.start_panel.Controls.Add(this.password_tbox);
            this.start_panel.Controls.Add(this.label1);
            this.start_panel.Controls.Add(this.login_tbox);
            this.start_panel.Controls.Add(this.pictureBox1);
            this.start_panel.Controls.Add(this.create_acc_label);
            this.start_panel.Controls.Add(this.login_btn);
            this.start_panel.Location = new System.Drawing.Point(0, 31);
            this.start_panel.Margin = new System.Windows.Forms.Padding(5);
            this.start_panel.Name = "start_panel";
            this.start_panel.Size = new System.Drawing.Size(700, 490);
            this.start_panel.TabIndex = 1;
            // 
            // create_acc_label
            // 
            this.create_acc_label.AutoSize = true;
            this.create_acc_label.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.create_acc_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(85)))));
            this.create_acc_label.Location = new System.Drawing.Point(525, 453);
            this.create_acc_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.create_acc_label.Name = "create_acc_label";
            this.create_acc_label.Size = new System.Drawing.Size(158, 21);
            this.create_acc_label.TabIndex = 3;
            this.create_acc_label.Text = "Create a new account";
            this.create_acc_label.Click += new System.EventHandler(this.create_acc_label_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(85)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.login_btn.Location = new System.Drawing.Point(280, 370);
            this.login_btn.Margin = new System.Windows.Forms.Padding(5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(149, 33);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Let\'s play";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_tbox
            // 
            this.login_tbox.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.login_tbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(85)))));
            this.login_tbox.Location = new System.Drawing.Point(280, 292);
            this.login_tbox.Margin = new System.Windows.Forms.Padding(5);
            this.login_tbox.Name = "login_tbox";
            this.login_tbox.Size = new System.Drawing.Size(149, 29);
            this.login_tbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(249)))), ((int)(((byte)(206)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 12);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(326, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log in ";
            // 
            // password_tbox
            // 
            this.password_tbox.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.password_tbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(85)))));
            this.password_tbox.Location = new System.Drawing.Point(280, 329);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.PasswordChar = 'o';
            this.password_tbox.PromptChar = '.';
            this.password_tbox.Size = new System.Drawing.Size(149, 29);
            this.password_tbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(670, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.button2.Location = new System.Drawing.Point(640, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 521);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.start_panel);
            this.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "94 percent";
            this.top_panel.ResumeLayout(false);
            this.start_panel.ResumeLayout(false);
            this.start_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel start_panel;
        private System.Windows.Forms.Label create_acc_label;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_tbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox password_tbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

