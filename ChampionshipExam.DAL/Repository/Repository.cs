using ChampionshipExam.DAL;
using ChampionshipExam.DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace ChampionshipExam
{
    public class Repository : IRepository
    {
        private readonly TeamContext context;

        public Repository(TeamContext dbcontext)
        {
            context = dbcontext;
        }

        public IEnumerable<Matches> GetMatches()
        {
            return context.Matches.ToList();
        }

        public IEnumerable<Team> GetTeams()
        {
            return context.Teams.ToList();
        }

        public Team GetById(int teamId) 
        {
            return context.Teams.Find(teamId);
        }


        public void Add(Team entity)
        {
            context.Teams.Add(entity);
        }

        public void Update(Team entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(Team entity)
        {
            Team team = context.Teams.Find(entity.Id);
            context.Teams.Remove(team);
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
