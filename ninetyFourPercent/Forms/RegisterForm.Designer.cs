namespace ninetyFourPercent
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_tbox = new System.Windows.Forms.TextBox();
            this.password_tbox = new System.Windows.Forms.TextBox();
            this.passwordConfirm_tbox = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_tbox
            // 
            this.login_tbox.Location = new System.Drawing.Point(410, 120);
            this.login_tbox.Name = "login_tbox";
            this.login_tbox.Size = new System.Drawing.Size(100, 20);
            this.login_tbox.TabIndex = 0;
            // 
            // password_tbox
            // 
            this.password_tbox.Location = new System.Drawing.Point(410, 147);
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.Size = new System.Drawing.Size(100, 20);
            this.password_tbox.TabIndex = 1;
            // 
            // passwordConfirm_tbox
            // 
            this.passwordConfirm_tbox.Location = new System.Drawing.Point(410, 174);
            this.passwordConfirm_tbox.Name = "passwordConfirm_tbox";
            this.passwordConfirm_tbox.Size = new System.Drawing.Size(100, 20);
            this.passwordConfirm_tbox.TabIndex = 2;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(410, 201);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 3;
            this.register_btn.Text = "button1";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(410, 241);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(35, 13);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "label1";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.passwordConfirm_tbox);
            this.Controls.Add(this.password_tbox);
            this.Controls.Add(this.login_tbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tbox;
        private System.Windows.Forms.TextBox password_tbox;
        private System.Windows.Forms.TextBox passwordConfirm_tbox;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label login_label;
    }
}