namespace ChampionshipExam.DAL
{
    public class Matches
    {
        public int Id { get; set; }

        public Team? Team1 { get; set; }

        public Team? Team2 { get; set; }

        public int GoalsScoredByTeam1 { get; set; }

        public int GoalsScoredByTeam2 { get; set; }

        public DateTime Date { get; set; }
    }
}
