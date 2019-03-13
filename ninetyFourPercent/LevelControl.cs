using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ninetyFourPercent
{
    public partial class LevelControl : UserControl
    {
        GameContext context = new GameContext();

        public List<Word> words { get; set; } = null;
        public List<PlayerProgress> playerprogress { get; set; } = null;

        public List<Word> progress { get; set; } = null;

        Button[] buttons;

        //List<Button> buttons = new List<Button>();

        public LevelControl()
        {
            InitializeComponent();

            playerprogress = context.PlayersProgresses.ToList();
        }

        public void setLevelTitle(string levelTitle)
        {
            button1.Text = levelTitle;
        }

        public void createBoard(int wordCount)
        {
            textBox1.Text = wordCount.ToString();

            buttons = new Button[wordCount];
            for (int i = 0; i < wordCount; i++)
                buttons[i] = new Button();

            switch (wordCount)
            {
                case 5:

                    buttons[0].Size = new Size(290, 100);
                    buttons[0].Location = new Point(30, 30);

                    buttons[1].Size = new Size(130, 130);
                    buttons[1].Location = new Point(30, 150);

                    buttons[2].Size = new Size(130, 130);
                    buttons[2].Location = new Point(190, 150);

                    buttons[3].Size = new Size(130, 130);
                    buttons[3].Location = new Point(30, 305);

                    buttons[4].Size = new Size(130, 130);
                    buttons[4].Location = new Point(190, 305);
                    break;
                case 6:

                    buttons[0].Size = new Size(130, 130);
                    buttons[0].Location = new Point(35, 30);

                    buttons[1].Size = new Size(130, 130);
                    buttons[1].Location = new Point(185, 30);

                    buttons[2].Size = new Size(130, 130);
                    buttons[2].Location = new Point(35, 175);

                    buttons[3].Size = new Size(130, 130);
                    buttons[3].Location = new Point(185, 175);

                    buttons[4].Size = new Size(130, 130);
                    buttons[4].Location = new Point(35, 320);

                    buttons[5].Size = new Size(130, 130);
                    buttons[5].Location = new Point(185, 320);
                    break;
                case 7:

                    buttons[0].Size = new Size(130, 130);
                    buttons[0].Location = new Point(35, 30);

                    buttons[1].Size = new Size(130, 130);
                    buttons[1].Location = new Point(185, 30);

                    buttons[2].Size = new Size(130, 130);
                    buttons[2].Location = new Point(35, 175);

                    buttons[3].Size = new Size(130, 130);
                    buttons[3].Location = new Point(185, 175);

                    buttons[4].Size = new Size(88, 88);
                    buttons[4].Location = new Point(35, 325);

                    buttons[5].Size = new Size(88, 88);
                    buttons[5].Location = new Point(131, 325);

                    buttons[6].Size = new Size(88, 88);
                    buttons[6].Location = new Point(227, 325);
                    break;

                case 8:

                    buttons[0].Size = new Size(130, 90);
                    buttons[1].Size = new Size(130, 90);
                    buttons[2].Size = new Size(130, 90);
                    buttons[3].Size = new Size(130, 90);
                    buttons[4].Size = new Size(130, 90);
                    buttons[5].Size = new Size(130, 90);
                    buttons[6].Size = new Size(130, 90);
                    buttons[7].Size = new Size(130, 90);

                    buttons[0].Location = new Point(35, 30);
                    buttons[1].Location = new Point(185, 30);
                    buttons[2].Location = new Point(35, 133);
                    buttons[3].Location = new Point(185, 133);
                    buttons[4].Location = new Point(35, 236);
                    buttons[5].Location = new Point(185, 236);
                    buttons[6].Location = new Point(35, 339);
                    buttons[7].Location = new Point(185, 339);
                    break;
            }

            for (int i = 0; i < wordCount; i++)
            {
                buttons[i].Text = words[i].SecretWord;
                panel1.Controls.Add(buttons[i]);
                for (int j = 0; j < playerprogress.Count; j++)
                    if (buttons[i].Text == playerprogress[j].Word.SecretWord)
                        buttons[i].ForeColor = Color.Red;
            }
        }

        public void deleteData()
        {
            panel1.Controls.Clear();
        }

        public void setWords(List<Word> tmp_words)
        {
            if (words != null)
                words.Clear();
            words = tmp_words;

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
                if (textBox1.Text == buttons[i].Text)
                {
                    if (buttons[i].ForeColor != Color.Red)
                    {
                        buttons[i].ForeColor = Color.Red;

                        PlayerProgress tmp = new PlayerProgress
                        {
                            Level_Id = words[0].Level.Id,
                            Player_Id = context.Players.First(p => p.Id == PlayerInfo.ID).Id,
                            Word_Id = words.First(w => w.SecretWord.Equals(textBox1.Text)).Id
                        };

                        context.PlayersProgresses.Add(tmp);
                        context.SaveChanges();
                    }
                }
        }
        public void update()
        {
            playerprogress = context.PlayersProgresses.ToList();
            for (int j = 0; j < playerprogress.Count; j++)
            {
                context.Entry(playerprogress[j]).Reference(pp => pp.Word).Load();
                for (int i = 0; i < words.Count; i++)
                {
                    if (buttons[i].Text == playerprogress[j].Word.SecretWord)
                        buttons[i].ForeColor = Color.Red;
                }

            }
        }
    }
}
