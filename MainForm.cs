using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace IMLab10
{
    public partial class MainForm : Form
    {
        static Random _rnd = new Random();
        static Team[] _participantsQuarterFinals = new Team[8];
        static Team[] _participantsSemiFinals = new Team[4];
        static Team[] _participantsFinals = new Team[2];
        static Team _winner;
        static int[] _resultsQuarterFinals = new int[8];
        static int[] _resultsSemiFinals = new int[4];
        static int[] _resultsFinals = new int[2];
        Graphics g;
        Pen _pen;
        public MainForm()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(Handle);
            _pen = new Pen(Brushes.Black);
            _pen.Width = 2;
        }
        void DrawCharts()
        {
            g.DrawLine(_pen, new Point(270, 230), new Point(310, 230));
            g.DrawLine(_pen, new Point(270, 430), new Point(310, 430));

            g.DrawLine(_pen, new Point(310, 230), new Point(310, 330));
            g.DrawLine(_pen, new Point(310, 430), new Point(310, 330));

            g.DrawLine(_pen, new Point(310, 330), new Point(350, 330));

            g.DrawLine(_pen, new Point(470, 330), new Point(525, 330));
            g.DrawLine(_pen, new Point(525, 330), new Point(525, 315));
            g.DrawLine(_pen, new Point(525, 315), new Point(580, 315));

            g.DrawLine(_pen, new Point(1010, 230), new Point(970, 230));
            g.DrawLine(_pen, new Point(1010, 430), new Point(970, 430));

            g.DrawLine(_pen, new Point(970, 230), new Point(970, 330));
            g.DrawLine(_pen, new Point(970, 430), new Point(970, 330));

            g.DrawLine(_pen, new Point(970, 330), new Point(930, 330));

            g.DrawLine(_pen, new Point(810, 330), new Point(755, 330));
            g.DrawLine(_pen, new Point(755, 330), new Point(755, 345));
            g.DrawLine(_pen, new Point(755, 345), new Point(700, 345));
        }
        class Team
        {
            public string Name { get; set; }
            public List<Player> PlayerList { get; set; } = new List<Player>();
            public double Skill { get; set; } = 0;
            public Team(string name, List<Player> playerList)
            {
                Name = name;
                PlayerList = playerList;
                foreach (Player p in PlayerList)
                {
                    Skill += p.Skill;
                }
            }
            public Team(List<Player> playerList)
            {
                Name = GenerateName();
                PlayerList = playerList;
                foreach (Player p in PlayerList)
                {
                    Skill += p.Skill;
                }
            }
            public Team()
            {
                Name = GenerateName();
                for (int i = 0; i < 5; i++)
                {
                    PlayerList.Add(new Player(Name + " " + i + 1));
                    Skill += PlayerList.ElementAt(i).Skill;
                }
            }
            public static string GenerateName()
            {
                string name = "";
                for (int i = 0; i < 3; i++)
                {
                    name += ((char)_rnd.Next('A', 'Z' + 1)).ToString();
                }
                return name;
            }
        }
        class Player
        {
            public string Name { get; set; }
            public double Skill { get; set; }
            public Player(string name, double skill)
            {
                Name = name;
                Skill = skill;
            }
            public Player(string name)
            {
                Name = name;
                Skill = _rnd.NextDouble() * 2;
            }
        }
        static void GenerateTeams()
        {
            for (int i = 0; i < 8; i++)
            {
                _participantsQuarterFinals[i] = new Team();
            }
        }
        int Poisson(double lam)
        {
            int m = 0;
            double S = 0;
            while (S >= -1*lam)
            {
                S += Math.Log(_rnd.NextDouble());
                m++;
            }
            return m;
        }
        Label GenerateLabel(string text)
        {
            Label l = new Label();
            l.Text = text;
            l.BackColor = Color.White;
            l.Font = new Font("Segoe UI", 12);
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Dock = DockStyle.Fill;
            l.Margin = new System.Windows.Forms.Padding(0);
            return l;
        }
        void GenerateTeamsButton_Click(object sender, EventArgs e)
        {
            TableQuarters1.Show();
            TableQuarters2.Show();
            TableQuarters3.Show();
            TableQuarters4.Show();
            TableSemis1.Show();
            TableSemis2.Show();
            TableFinals.Show();
            GenerateTeamsButton.Hide();
            DrawCharts();
            GenerateTeams();
            WriteQuarterFinals();
            CalculateQuarterFinals();
            
            DraftSemiFinals();
            WriteSemiFinals();
            CalculateSemiFinals();
            
            DraftFinals();
            WriteFinals();
            CalculateFinals();
            DecideWinner();

            SetTooltips();
        }
        void WriteQuarterFinals()
        {
            TableQuarters1.Controls.Add(GenerateLabel(_participantsQuarterFinals[0].Name), 0, 0);
            TableQuarters1.Controls.Add(GenerateLabel(_participantsQuarterFinals[1].Name), 0, 1);
            TableQuarters2.Controls.Add(GenerateLabel(_participantsQuarterFinals[2].Name), 0, 0);
            TableQuarters2.Controls.Add(GenerateLabel(_participantsQuarterFinals[3].Name), 0, 1);
            TableQuarters3.Controls.Add(GenerateLabel(_participantsQuarterFinals[4].Name), 0, 0);
            TableQuarters3.Controls.Add(GenerateLabel(_participantsQuarterFinals[5].Name), 0, 1);
            TableQuarters4.Controls.Add(GenerateLabel(_participantsQuarterFinals[6].Name), 0, 0);
            TableQuarters4.Controls.Add(GenerateLabel(_participantsQuarterFinals[7].Name), 0, 1);
        }
        void CalculateQuarterFinals()
        {
            for (int i = 0; i < 8; i++)
            {
                _resultsQuarterFinals[i] = Poisson(_participantsQuarterFinals[i].Skill);
            }
            TableQuarters1.Controls.Add(GenerateLabel(_resultsQuarterFinals[0].ToString()), 1, 0);
            TableQuarters1.Controls.Add(GenerateLabel(_resultsQuarterFinals[1].ToString()), 1, 1);
            if (_resultsQuarterFinals[0] >= _resultsQuarterFinals[1])
            {
                TableQuarters1.GetControlFromPosition(0, 0).BackColor = Color.Green;
                TableQuarters1.GetControlFromPosition(0, 1).BackColor = Color.Red;
            }
            else
            {
                TableQuarters1.GetControlFromPosition(0, 0).BackColor = Color.Red;
                TableQuarters1.GetControlFromPosition(0, 1).BackColor = Color.Green;
            }
            TableQuarters2.Controls.Add(GenerateLabel(_resultsQuarterFinals[2].ToString()), 1, 0);
            TableQuarters2.Controls.Add(GenerateLabel(_resultsQuarterFinals[3].ToString()), 1, 1);
            if (_resultsQuarterFinals[2] >= _resultsQuarterFinals[3])
            {
                TableQuarters2.GetControlFromPosition(0, 0).BackColor = Color.Green;
                TableQuarters2.GetControlFromPosition(0, 1).BackColor = Color.Red;
            }
            else
            {
                TableQuarters2.GetControlFromPosition(0, 0).BackColor = Color.Red;
                TableQuarters2.GetControlFromPosition(0, 1).BackColor = Color.Green;
            }
            TableQuarters3.Controls.Add(GenerateLabel(_resultsQuarterFinals[4].ToString()), 1, 0);
            TableQuarters3.Controls.Add(GenerateLabel(_resultsQuarterFinals[5].ToString()), 1, 1);
            if (_resultsQuarterFinals[4] >= _resultsQuarterFinals[5])
            {
                TableQuarters3.GetControlFromPosition(0, 0).BackColor = Color.Green;
                TableQuarters3.GetControlFromPosition(0, 1).BackColor = Color.Red;
            }
            else
            {
                TableQuarters3.GetControlFromPosition(0, 0).BackColor = Color.Red;
                TableQuarters3.GetControlFromPosition(0, 1).BackColor = Color.Green;
            }
            TableQuarters4.Controls.Add(GenerateLabel(_resultsQuarterFinals[6].ToString()), 1, 0);
            TableQuarters4.Controls.Add(GenerateLabel(_resultsQuarterFinals[7].ToString()), 1, 1);
            if (_resultsQuarterFinals[6] >= _resultsQuarterFinals[7])
            {
                TableQuarters4.GetControlFromPosition(0, 0).BackColor = Color.Green;
                TableQuarters4.GetControlFromPosition(0, 1).BackColor = Color.Red;
            }
            else
            {
                TableQuarters4.GetControlFromPosition(0, 0).BackColor = Color.Red;
                TableQuarters4.GetControlFromPosition(0, 1).BackColor = Color.Green;
            }
        }
        void DraftSemiFinals()
        {
            for (int i = 0; i < 4; i++)
            {
                if (_resultsQuarterFinals[2*i] >= _resultsQuarterFinals[2*i+1])
                {
                    _participantsSemiFinals[i] = _participantsQuarterFinals[2*i];
                }
                else
                {
                    _participantsSemiFinals[i] = _participantsQuarterFinals[2*i+1];
                }
            }
        }
        void WriteSemiFinals()
        {
            TableSemis1.Controls.Add(GenerateLabel(_participantsSemiFinals[0].Name), 0, 0);
            TableSemis1.Controls.Add(GenerateLabel(_participantsSemiFinals[1].Name), 0, 1);
            TableSemis2.Controls.Add(GenerateLabel(_participantsSemiFinals[2].Name), 0, 0);
            TableSemis2.Controls.Add(GenerateLabel(_participantsSemiFinals[3].Name), 0, 1);
        }
        void CalculateSemiFinals()
        {
            for (int i = 0; i < 4; i++)
            {
                _resultsSemiFinals[i] = Poisson(_participantsSemiFinals[i].Skill);
            }
            TableSemis1.Controls.Add(GenerateLabel(_resultsSemiFinals[0].ToString()), 1, 0);
            TableSemis1.Controls.Add(GenerateLabel(_resultsSemiFinals[1].ToString()), 1, 1);
            if (_resultsSemiFinals[0] >= _resultsSemiFinals[1])
            {
                TableSemis1.GetControlFromPosition(0, 0).BackColor = Color.Green;
                TableSemis1.GetControlFromPosition(0, 1).BackColor = Color.Red;
            }
            else
            {
                TableSemis1.GetControlFromPosition(0, 0).BackColor = Color.Red;
                TableSemis1.GetControlFromPosition(0, 1).BackColor = Color.Green;
            }
            TableSemis2.Controls.Add(GenerateLabel(_resultsSemiFinals[2].ToString()), 1, 0);
            TableSemis2.Controls.Add(GenerateLabel(_resultsSemiFinals[3].ToString()), 1, 1);
            if (_resultsSemiFinals[2] >= _resultsSemiFinals[3])
            {
                TableSemis2.GetControlFromPosition(0, 0).BackColor = Color.Green;
                TableSemis2.GetControlFromPosition(0, 1).BackColor = Color.Red;
            }
            else
            {
                TableSemis2.GetControlFromPosition(0, 0).BackColor = Color.Red;
                TableSemis2.GetControlFromPosition(0, 1).BackColor = Color.Green;
            }
        }
        void DraftFinals()
        {
            for (int i = 0; i < 2; i++)
            {
                if (_resultsSemiFinals[2 * i] >= _resultsSemiFinals[2 * i + 1])
                {
                    _participantsFinals[i] = _participantsSemiFinals[2 * i];
                }
                else
                {
                    _participantsFinals[i] = _participantsSemiFinals[2 * i + 1];
                }
            }
        }
        void WriteFinals()
        {
            TableFinals.Controls.Add(GenerateLabel(_participantsFinals[0].Name), 0, 0);
            TableFinals.Controls.Add(GenerateLabel(_participantsFinals[1].Name), 0, 1);
        }
        void CalculateFinals()
        {
            for (int i = 0; i < 2; i++)
            {
                _resultsFinals[i] = Poisson(_participantsFinals[i].Skill);
            }
            while (_resultsFinals[0] == _resultsFinals[1])
            {
                for (int i = 0; i < 2; i++)
                {
                    _resultsFinals[i] = Poisson(_participantsFinals[i].Skill);
                }
            }
            TableFinals.Controls.Add(GenerateLabel(_resultsFinals[0].ToString()), 1, 0);
            TableFinals.Controls.Add(GenerateLabel(_resultsFinals[1].ToString()), 1, 1);
            if (_resultsFinals[0] >= _resultsFinals[1])
            {
                TableFinals.GetControlFromPosition(0, 0).BackColor = Color.Green;
                TableFinals.GetControlFromPosition(0, 1).BackColor = Color.Red;
            }
            else
            {
                TableFinals.GetControlFromPosition(0, 0).BackColor = Color.Red;
                TableFinals.GetControlFromPosition(0, 1).BackColor = Color.Green;
            }
        }
        void DecideWinner()
        {
            if (_resultsFinals[0] >= _resultsFinals[1])
            {
                _winner = _participantsFinals[0];
            }
            else
            {
                _winner = _participantsFinals[1];
            }
            WinnerNameLabel.Text = _winner.Name;
            WinnerCaptionLabel.Show();
            WinnerNameLabel.Show();
        }
        void SetTooltips()
        {
            ToolTip tt1 = new ToolTip();
            tt1.ShowAlways = true;
            tt1.SetToolTip(this.TableQuarters1.GetControlFromPosition(0, 0), Math.Round(_participantsQuarterFinals[0].Skill,3).ToString());
            tt1.SetToolTip(this.TableQuarters1.GetControlFromPosition(0, 1), Math.Round(_participantsQuarterFinals[1].Skill,3).ToString());
            tt1.SetToolTip(this.TableQuarters2.GetControlFromPosition(0, 0), Math.Round(_participantsQuarterFinals[2].Skill,3).ToString());
            tt1.SetToolTip(this.TableQuarters2.GetControlFromPosition(0, 1), Math.Round(_participantsQuarterFinals[3].Skill,3).ToString());
            tt1.SetToolTip(this.TableQuarters3.GetControlFromPosition(0, 0), Math.Round(_participantsQuarterFinals[4].Skill,3).ToString());
            tt1.SetToolTip(this.TableQuarters3.GetControlFromPosition(0, 1), Math.Round(_participantsQuarterFinals[5].Skill,3).ToString());
            tt1.SetToolTip(this.TableQuarters4.GetControlFromPosition(0, 0), Math.Round(_participantsQuarterFinals[6].Skill,3).ToString());
            tt1.SetToolTip(this.TableQuarters4.GetControlFromPosition(0, 1), Math.Round(_participantsQuarterFinals[7].Skill,3).ToString());

            tt1.SetToolTip(this.TableSemis1.GetControlFromPosition(0, 0), Math.Round(_participantsSemiFinals[0].Skill, 3).ToString());
            tt1.SetToolTip(this.TableSemis1.GetControlFromPosition(0, 1), Math.Round(_participantsSemiFinals[1].Skill, 3).ToString());
            tt1.SetToolTip(this.TableSemis2.GetControlFromPosition(0, 0), Math.Round(_participantsSemiFinals[2].Skill, 3).ToString());
            tt1.SetToolTip(this.TableSemis2.GetControlFromPosition(0, 1), Math.Round(_participantsSemiFinals[3].Skill, 3).ToString());

            tt1.SetToolTip(this.TableFinals.GetControlFromPosition(0, 0), Math.Round(_participantsFinals[0].Skill, 3).ToString());
            tt1.SetToolTip(this.TableFinals.GetControlFromPosition(0, 1), Math.Round(_participantsFinals[1].Skill, 3).ToString());
        }
    }
}
