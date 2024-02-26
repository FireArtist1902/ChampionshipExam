namespace ChampionshipExam.DAL.Repository
{
    public interface IRepository
    {
        void Add(Team entity);

        void Remove(Team entity);

        void Update(Team entity);

        void Save();

        IEnumerable<Team> GetTeams();

        Team GetById(int id);
    }
}
