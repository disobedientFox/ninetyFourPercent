namespace ninetyFourPercent
{
    partial class MainForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.top_panel = new System.Windows.Forms.Panel();
            this.key_panel = new System.Windows.Forms.Panel();
            this.game_panel = new System.Windows.Forms.Panel();
            this.words_panel = new System.Windows.Forms.Panel();
            this.chooselvl_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(120, 470);
            this.treeView1.TabIndex = 0;
            // 
            // top_panel
            // 
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(700, 30);
            this.top_panel.TabIndex = 1;
            // 
            // key_panel
            // 
            this.key_panel.Location = new System.Drawing.Point(120, 30);
            this.key_panel.Name = "key_panel";
            this.key_panel.Size = new System.Drawing.Size(250, 250);
            this.key_panel.TabIndex = 2;
            // 
            // game_panel
            // 
            this.game_panel.Location = new System.Drawing.Point(120, 280);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(250, 220);
            this.game_panel.TabIndex = 3;
            // 
            // words_panel
            // 
            this.words_panel.Location = new System.Drawing.Point(370, 30);
            this.words_panel.Name = "words_panel";
            this.words_panel.Size = new System.Drawing.Size(330, 470);
            this.words_panel.TabIndex = 4;
            // 
            // chooselvl_panel
            // 
            this.chooselvl_panel.Location = new System.Drawing.Point(120, 30);
            this.chooselvl_panel.Name = "chooselvl_panel";
            this.chooselvl_panel.Size = new System.Drawing.Size(580, 470);
            this.chooselvl_panel.TabIndex = 0;
            this.chooselvl_panel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.words_panel);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.key_panel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chooselvl_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel key_panel;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.Panel words_panel;
        private System.Windows.Forms.Panel chooselvl_panel;
    }
}