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
            this.mainpanellevel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.levelControl1 = new ninetyFourPercent.LevelControl();
            this.mainpanellevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 30);
            this.treeView1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(130, 470);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // top_panel
            // 
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(700, 30);
            this.top_panel.TabIndex = 1;
            // 
            // mainpanellevel
            // 
            this.mainpanellevel.Controls.Add(this.button3);
            this.mainpanellevel.Controls.Add(this.button2);
            this.mainpanellevel.Controls.Add(this.button1);
            this.mainpanellevel.Controls.Add(this.levelControl1);
            this.mainpanellevel.Location = new System.Drawing.Point(130, 30);
            this.mainpanellevel.Name = "mainpanellevel";
            this.mainpanellevel.Size = new System.Drawing.Size(570, 470);
            this.mainpanellevel.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "Picture";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // levelControl1
            // 
            this.levelControl1.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelControl1.Location = new System.Drawing.Point(0, 0);
            this.levelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.levelControl1.Name = "levelControl1";
            this.levelControl1.Size = new System.Drawing.Size(570, 470);
            this.levelControl1.TabIndex = 3;
            this.levelControl1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.mainpanellevel);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainpanellevel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel mainpanellevel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LevelControl levelControl1;
    }
}