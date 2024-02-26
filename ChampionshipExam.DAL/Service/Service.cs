using ChampionshipExam.DAL;
using ChampionshipExam.DAL.Service;

namespace ChampionshipExam
{
    public class Service : IService
    {
        public Repository _repository = new Repository(new TeamContext());

        private List<Matches> matches = new List<Matches>();

        private List<Team> teams = new List<Team>();

        public Service()
        {
            matches = _repository.GetMatches().ToList();
            teams = _repository.GetTeams().ToList();
        }

        public List<Matches> Matches { get => matches; set => matches = value; }

        public Matches AllMatchesByTeam(string name)
        {
            foreach (var item in matches)
            {
                if (name == item.Team1.Name || name == item.Team2.Name)
                {
                    return item;
                }
            }
            return new Matches();
        }

        public   Matches InfoAboutMatchByDate(DateTime date)
        {
            foreach (var item in matches)
            {
                if (item.Date == date)
                {
                    return item;
                }
            }
            return new Matches();
        }

        public int[] DifferenceOfGoals(Matches matches)
        {
            int[] team = { matches.GoalsScoredByTeam1 - matches.Team1.GoalsConceded, matches.GoalsScoredByTeam2 - matches.Team2.GoalsConceded };
            return team;
        }

        public   void DeleteTeam(string name)
        {
            foreach(var team in teams)
            {
                if (team.Name == name)
                {
                    _repository.Remove(team);
                    _repository.Save();
                    break;
                }
            }
        }

        public void Refresh()
        {
            teams.Clear();
            matches.Clear();
            teams = _repository.GetTeams().ToList();
            matches = _repository.GetMatches().ToList();
        }

        public   void AddTeam(Team team)
        {
            _repository.Add(team);
            _repository.Save();
        }

        public Team WorstTeamByLoosingGoals()
        {
            
            int max = 0;
            foreach (var item in teams)
            {
                if (item.GoalsConceded > max)
                {
                    max = item.Wins;
                }
            }
            foreach (var item in teams)
            {
                if (item.GoalsConceded == max)
                {
                    Team team = TeamByName(item.Name);
                    
                    return team;
                }
            }
            return new Team();
        }

        public Team BeastTeamByGoals()
        {
            
            int max = 0;
            foreach (var item in teams)
            {
                if (item.GoalsScored > max)
                {
                    max = item.Wins;
                }
            }
            foreach (var item in teams)
            {
                if (item.GoalsScored == max)
                {
                    Team team = TeamByName(item.Name);
                    
                    return team;
                }
            }
            return new Team();
        }

        public Team TeamWithMostDraws()
        {
            
            int max = 0;
            foreach (var item in teams)
            {
                if (item.Draws > max)
                {
                    max = item.Wins;
                }
            }
            foreach(var item in teams)
            {
                if (item.Draws == max)
                {
                    Team team = TeamByName(item.Name);
                    
                    return team;
                }
            }
            return new Team();
        }

        public Team WorstTeam()
        {
            
            int max = 0;
            foreach (var item in teams)
            {
                if (item.Defeats > max)
                {
                    max = item.Wins;
                }
            }
            foreach (var item in teams)
            {
                if (item.Defeats == max)
                {
                    Team team =  TeamByName(item.Name);

                    return team;
                }
            }
            return new Team();
        }

        public Team BestTeam()
        {
            int max = 0;
            foreach (var item in teams)
            {
                if (item.Wins > max)
                {
                    max = item.Wins;
                }
            }
            foreach (var item in teams)
            {
                if (item.Wins == max)
                {
                    Team team = TeamByName(item.Name);
                    return team;
                }
            }
            return new Team();
        }

        public Team TeamByNameAndTown(string TownName, string TeamName)
        {
            foreach (var team in teams)
            {
                if (team.Town == TownName && team.Name == TeamName)
                {
                    return team;
                }
            }
            return new Team();
        }

        public Team TeamByTownName(string townName)
        {
            foreach (var team in teams)
            {
                if (team.Town == townName)
                {
                    return team;
                }
            }
            return new Team();
        }

        public Team TeamByName(string? name)
        {
            foreach (var team in teams)
            {
                if (team.Name == name)
                {
                    return team;
                }
            }
            return new Team();
        }
    }
}
