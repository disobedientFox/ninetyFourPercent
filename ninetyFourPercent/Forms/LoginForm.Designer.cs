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
            this.top_panel = new System.Windows.Forms.Panel();
            this.start_panel = new System.Windows.Forms.Panel();
            this.login_tbox = new System.Windows.Forms.TextBox();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.create_acc_label = new System.Windows.Forms.Label();
            this.start_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(700, 30);
            this.top_panel.TabIndex = 0;
            // 
            // start_panel
            // 
            this.start_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.start_panel.Controls.Add(this.create_acc_label);
            this.start_panel.Controls.Add(this.login_btn);
            this.start_panel.Controls.Add(this.password_tbox);
            this.start_panel.Controls.Add(this.login_tbox);
            this.start_panel.Location = new System.Drawing.Point(0, 0);
            this.start_panel.Name = "start_panel";
            this.start_panel.Size = new System.Drawing.Size(700, 500);
            this.start_panel.TabIndex = 1;
            // 
            // login_tbox
            // 
            this.login_tbox.Location = new System.Drawing.Point(279, 153);
            this.login_tbox.Name = "login_tbox";
            this.login_tbox.Size = new System.Drawing.Size(100, 20);
            this.login_tbox.TabIndex = 0;
            // 
            // password_tbox
            // 
            this.password_tbox.Location = new System.Drawing.Point(279, 180);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(100, 20);
            this.password_tbox.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(279, 231);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "button1";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // create_acc_label
            // 
            this.create_acc_label.AutoSize = true;
            this.create_acc_label.Location = new System.Drawing.Point(279, 273);
            this.create_acc_label.Name = "create_acc_label";
            this.create_acc_label.Size = new System.Drawing.Size(35, 13);
            this.create_acc_label.TabIndex = 3;
            this.create_acc_label.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.start_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.start_panel.ResumeLayout(false);
            this.start_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel start_panel;
        private System.Windows.Forms.Label create_acc_label;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.TextBox login_tbox;
    }
}

