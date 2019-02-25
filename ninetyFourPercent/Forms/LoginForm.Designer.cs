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
            this.close_panel = new System.Windows.Forms.Panel();
            this.start_panel = new System.Windows.Forms.Panel();
            this.create_acc_label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.login_tbox = new System.Windows.Forms.TextBox();
            this.minimize_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.top_panel.SuspendLayout();
            this.start_panel.SuspendLayout();
            this.minimize_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.top_panel.Controls.Add(this.minimize_panel);
            this.top_panel.Controls.Add(this.close_panel);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(5);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(700, 30);
            this.top_panel.TabIndex = 0;
            // 
            // close_panel
            // 
            this.close_panel.Location = new System.Drawing.Point(670, 0);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(30, 30);
            this.close_panel.TabIndex = 0;
            this.close_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_panel_MouseClick);
            // 
            // start_panel
            // 
            this.start_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.start_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start_panel.BackgroundImage")));
            this.start_panel.Controls.Add(this.create_acc_label);
            this.start_panel.Controls.Add(this.login_btn);
            this.start_panel.Controls.Add(this.password_tbox);
            this.start_panel.Controls.Add(this.login_tbox);
            this.start_panel.Location = new System.Drawing.Point(0, 30);
            this.start_panel.Margin = new System.Windows.Forms.Padding(5);
            this.start_panel.Name = "start_panel";
            this.start_panel.Size = new System.Drawing.Size(700, 470);
            this.start_panel.TabIndex = 1;
            // 
            // create_acc_label
            // 
            this.create_acc_label.AutoSize = true;
            this.create_acc_label.Location = new System.Drawing.Point(321, 414);
            this.create_acc_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.create_acc_label.Name = "create_acc_label";
            this.create_acc_label.Size = new System.Drawing.Size(59, 23);
            this.create_acc_label.TabIndex = 3;
            this.create_acc_label.Text = "label1";
            this.create_acc_label.Click += new System.EventHandler(this.create_acc_label_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(267, 269);
            this.login_btn.Margin = new System.Windows.Forms.Padding(5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(180, 41);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "button1";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_tbox
            // 
            this.password_tbox.Location = new System.Drawing.Point(267, 216);
            this.password_tbox.Margin = new System.Windows.Forms.Padding(5);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(180, 30);
            this.password_tbox.TabIndex = 1;
            // 
            // login_tbox
            // 
            this.login_tbox.Location = new System.Drawing.Point(267, 165);
            this.login_tbox.Margin = new System.Windows.Forms.Padding(5);
            this.login_tbox.Name = "login_tbox";
            this.login_tbox.Size = new System.Drawing.Size(180, 30);
            this.login_tbox.TabIndex = 0;
            // 
            // minimize_panel
            // 
            this.minimize_panel.Controls.Add(this.label1);
            this.minimize_panel.Location = new System.Drawing.Point(640, 0);
            this.minimize_panel.Name = "minimize_panel";
            this.minimize_panel.Size = new System.Drawing.Size(30, 30);
            this.minimize_panel.TabIndex = 1;
            this.minimize_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimize_panel_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "_";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.start_panel);
            this.Font = new System.Drawing.Font("Lato", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "94 percent";
            this.top_panel.ResumeLayout(false);
            this.start_panel.ResumeLayout(false);
            this.start_panel.PerformLayout();
            this.minimize_panel.ResumeLayout(false);
            this.minimize_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel start_panel;
        private System.Windows.Forms.Label create_acc_label;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.TextBox login_tbox;
        private System.Windows.Forms.Panel close_panel;
        private System.Windows.Forms.Panel minimize_panel;
        private System.Windows.Forms.Label label1;
    }
}

