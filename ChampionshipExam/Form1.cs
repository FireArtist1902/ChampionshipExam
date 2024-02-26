using ChampionshipExam.DAL;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ChampionshipExam
{
    public partial class StartForm : Form
    {
        Service _service = new Service();
        private bool AddTeam = false;
        private bool RemoveTeam = false;
        private bool TeamName = false;
        private bool IsShow = false;
        private bool NameByTown = false;
        private bool TeamByNameAndTown = false;
        private bool MatchInfo = false;

        public StartForm()
        {
            InitializeComponent();
            NameTB.Enabled = false;
            TownTB.Enabled = false;
            WinsTB.Enabled = false;
            DefeatsTB.Enabled = false;
            DrawsTB.Enabled = false;
            GoalsConcededTB.Enabled = false;
            GoalsScoredTB.Enabled = false;
            SubmitBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InfoAboutTeamsBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddTeamBtn_Click(object sender, EventArgs e)
        {
            AddTeam = true;
            Enable();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AddTeam)
            {
                Team team = new Team()
                {
                    Name = NameTB.Text,
                    Defeats = Convert.ToInt32(DefeatsTB.Text),
                    Town = TownTB.Text,
                    Draws = Convert.ToInt32(DrawsTB.Text),
                    GoalsConceded = Convert.ToInt32(GoalsConcededTB.Text),
                    GoalsScored = Convert.ToInt32(GoalsScoredTB.Text),
                    Wins = Convert.ToInt32(WinsTB.Text)
                };
                _service.AddTeam(team);
                AddTeam = false;
                DisableAll();
                _service.Refresh();
            }
            else if (RemoveTeam)
            {
                _service.DeleteTeam(NameTB.Text);
                RemoveTeam = false;
                DisableAll();
            }
            else if (TeamName)
            {
                IsShow = true;
                ShowElements(_service.TeamByName(NameTB.Text));
                TeamName = false;
            }
            else if (IsShow)
            {
                QuickShow();
            }
            else if (NameByTown)
            {
                IsShow = true;
                TownTB.Enabled = false;
                ShowElements(_service.TeamByTownName(TownTB.Text));
                NameByTown = false;
            }
            else if (TeamByNameAndTown)
            {
                IsShow = true;
                TownTB.Enabled = false;
                NameTB.Enabled = false;
                ShowElements(_service.TeamByNameAndTown(TownTB.Text, NameTB.Text));
                TeamByNameAndTown = false;
            }
            else if (MatchInfo)
            {

            }

        }

        private void ShowElements(Team team)
        {
            NameTB.Enabled = false;
            NameTB.Text = team.Name;
            TownTB.Text = team.Town;
            WinsTB.Text = Convert.ToString(team.Wins);
            DefeatsTB.Text = Convert.ToString(team.Defeats);
            DrawsTB.Text = Convert.ToString(team.Draws);
            GoalsConcededTB.Text = Convert.ToString(team.GoalsConceded);
            GoalsScoredTB.Text = Convert.ToString(team.GoalsScored);
        }

        private void Enable()
        {
            AddTeam = true;
            NameTB.Enabled = true;
            TownTB.Enabled = true;
            WinsTB.Enabled = true;
            DefeatsTB.Enabled = true;
            DrawsTB.Enabled = true;
            GoalsConcededTB.Enabled = true;
            GoalsScoredTB.Enabled = true;
            SubmitBtn.Enabled = true;
        }

        private void DeleteTeamBtn_Click(object sender, EventArgs e)
        {
            RemoveTeam = true;
            NameTB.Enabled = true;
            SubmitBtn.Enabled = true;
        }

        private void DisableAll()
        {
            NameTB.Enabled = false;
            NameTB.Text = null;
            TownTB.Enabled = false;
            TownTB.Text = null;
            WinsTB.Enabled = false;
            WinsTB.Text = null;
            DefeatsTB.Enabled = false;
            DefeatsTB.Text = null;
            DrawsTB.Enabled = false;
            DrawsTB.Text = null;
            GoalsConcededTB.Enabled = false;
            GoalsConcededTB.Text = null;
            GoalsScoredTB.Enabled = false;
            GoalsScoredTB.Text = null;
            SubmitBtn.Enabled = false;
        }

        private void InfoByTeamNameBtn_Click(object sender, EventArgs e)
        {
            TeamName = true;
            NameTB.Enabled = true;
            SubmitBtn.Enabled = true;
        }

        private void QuickShow()
        {
            Enable();
            NameTB.Text = null;
            TownTB.Text = null;
            WinsTB.Text = null;
            DefeatsTB.Text = null;
            DrawsTB.Text = null;
            GoalsConcededTB.Text = null;
            GoalsScoredTB.Text = null;
            DisableAll();
            IsShow = false;
        }

        private void TeamByTownNameBtn_Click(object sender, EventArgs e)
        {
            NameByTown = true;
            TownTB.Enabled = true;
            SubmitBtn.Enabled = true;
        }

        private void TeamByNameAndTownBtn_Click(object sender, EventArgs e)
        {
            TeamByNameAndTown = true;
            TownTB.Enabled = true;
            SubmitBtn.Enabled = true;
            NameTB.Enabled = true;
        }

        private void TeamWithMostWinsBtn_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.BestTeam());
        }

        private void TeamByMostDefeatsBtn_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.WorstTeam());
        }

        private void TeamByMostDrawsBtn_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.TeamWithMostDraws());
        }

        private void TEamByMostGoalsBtn_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.BeastTeamByGoals());
        }

        private void TEamByMoreGoalsConcededBtn_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.WorstTeamByLoosingGoals());
        }

    }
}