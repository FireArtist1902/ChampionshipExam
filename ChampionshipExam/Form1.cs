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
        public StartForm()
        {
            InitializeComponent();
            FieldsGB.Enabled = false;
            RefreshTeams();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                RefreshTeams();
                MessageBox.Show($"Команда {team.Name} додана до бази", "Додавання команди", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void DisableAll()
        {
            FieldsGB.Enabled = false;
            NameTB.Text = null;
            TownTB.Text = null;
            WinsTB.Text = null;
            DefeatsTB.Text = null;
            DrawsTB.Text = null;
            GoalsConcededTB.Text = null;
            GoalsScoredTB.Text = null;
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

        private void RefreshTeams()
        {
            _service.Refresh();
            TeamCB.Items.Clear();
            foreach (var team in _service.GetTeams())
            {
                TeamCB.Items.Add(team.Name);
            }
        }

        private void TeamCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TeamCB.SelectedIndex != -1)
            {
                ShowElements(_service.TeamByName(TeamCB.Items[TeamCB.SelectedIndex].ToString()));
            }
        }

        private void StartForm_Click(object sender, EventArgs e)
        {
            TeamCB.SelectedIndex = -1;
            DisableAll();
        }

        private void DeleteTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TeamCB.SelectedIndex != -1)
            {
                _service.DeleteTeam(TeamCB.Items[TeamCB.SelectedIndex].ToString());
                MessageBox.Show($"Команда {TeamCB.Items[TeamCB.SelectedIndex]} видалена з бази", "Видалення команди", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TeamCB.SelectedIndex = -1;
                RefreshTeams();
            }
        }

        private void AddTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeam = true;
            FieldsGB.Enabled = true;
        }

        private void TeamWithTheMostWinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamMessage(_service.BestTeam());
        }

        private void TeamMessage(Team team)
        {
            MessageBox.Show($"Назва команди: {team.Name}\n" +
                            $"Місто з якого команда: {team.Town}\n" +
                            $"Кількість перемог: {team.Wins}\n" +
                            $"Кількість поразок: {team.Defeats}\n" +
                            $"Кількість ігор зіграних в нічию: {team.Draws}\n" +
                            $"Кількість забитих голів: {team.GoalsScored}\n" +
                            $"Кількість пропущених голів: {team.GoalsConceded}",
                            "Інформація про команду",
                            MessageBoxButtons.OK);
        }

        private void InfoAboutTeamNAmeAndTownNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamByNameAndTown = true;
            TownTB.Enabled = true;
            SubmitBtn.Enabled = true;
            NameTB.Enabled = true;
        }

        private void TeamWithTheMostLossesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.WorstTeam());
        }

        private void TeamWithTheMostDrawsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.TeamWithMostDraws());
        }

        private void TeamWithTheMostScoredGoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.BeastTeamByGoals());
        }

        private void TeamWithTheMostConcededGoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsShow = true;
            SubmitBtn.Enabled = true;
            ShowElements(_service.WorstTeamByLoosingGoals());
        }
    }
}