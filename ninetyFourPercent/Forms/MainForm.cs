using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ninetyFourPercent
{
    public partial class MainForm : Form
    {
        private LevelControl levelControl1 = new LevelControl();

        GameContext context = new GameContext();
        public List<Level> levels { get; set; } = null;
        public List<Word> words { get; set; } = null;

        public string selectedLevel = "";

        List<Level> themes;

        public MainForm()
        {
            InitializeComponent();

            treeView1.ShowPlusMinus = false;
            treeView1.LabelEdit = false;
            treeView1.Nodes.Add("First");
            treeView1.Nodes.Add("Second");
            treeView1.Nodes.Add("Third");
            treeView1.Nodes.Add("Fourth");
            treeView1.Nodes.Add("Fifth");

            try
            {
                words = context.Words.ToList();
            }
            catch { }

            try
            {
                levels = context.Levels.ToList();
            }
            catch { }
            levelControl1.Size = new System.Drawing.Size(570, 470);
            mainpanellevel.Controls.Add(levelControl1);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string tmp = treeView1.SelectedNode.Text;
            mainpanellevel.BringToFront();
            levelControl1.Visible = false;
            switch (tmp)
            {
                case "First":
                    themes = null;
                    themes = levels.Where(l => l.Module.Equals(1)).ToList();
                    button1.Text = themes[0].Key.ToString();
                    button2.Text = themes[1].Key.ToString();
                    break;
                case "Second":
                    themes = null;
                    themes = levels.Where(l => l.Module.Equals(2)).ToList();
                    button1.Text = themes[0].Key.ToString();
                    button2.Text = themes[1].Key.ToString();
                    break;
                case "Third":
                    themes = null;
                    themes = levels.Where(l => l.Module.Equals(3)).ToList();
                    button1.Text = themes[0].Key.ToString();
                    button2.Text = themes[1].Key.ToString();
                    break;
                case "Fourth":
                    themes = null;
                    themes = levels.Where(l => l.Module.Equals(4)).ToList();
                    button1.Text = themes[0].Key.ToString();
                    button2.Text = themes[1].Key.ToString();
                    break;
                case "Fifth":
                    themes = null;
                    themes = levels.Where(l => l.Module.Equals(5)).ToList();
                    button1.Text = themes[0].Key.ToString();
                    button2.Text = themes[1].Key.ToString();
                    break;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            levelControl1.deleteData();
            levelControl1.Visible = true;
            levelControl1.BringToFront();
            levelControl1.setWords(words.Where(w => w.Level.Id == themes[0].Id).ToList());
            levelControl1.setLevelTitle(themes[0].Key.ToString());
            levelControl1.createBoard(words.Count(w => w.Level.Id == themes[0].Id));
            levelControl1.update();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            levelControl1.deleteData();
            levelControl1.Visible = true;
            levelControl1.BringToFront();
            levelControl1.setWords(words.Where(w => w.Level.Id == themes[1].Id).ToList());
            levelControl1.setLevelTitle(themes[1].Key.ToString());
            levelControl1.createBoard(words.Count(w => w.Level.Id == themes[1].Id));
            levelControl1.update();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            levelControl1.deleteData();
            levelControl1.Visible = true;
            levelControl1.BringToFront();
            levelControl1.setWords(words.Where(w => w.Level.Id == themes[2].Id).ToList());
            levelControl1.setLevelTitle(themes[2].Key.ToString());
            levelControl1.createBoard(words.Count(w => w.Level.Id == themes[2].Id));
            levelControl1.update();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1_AfterSelect(treeView1, new TreeViewEventArgs(treeView1.SelectedNode));
        }
    }
}
