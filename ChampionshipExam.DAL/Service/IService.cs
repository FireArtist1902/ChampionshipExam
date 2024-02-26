using ChampionshipExam.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionshipExam.DAL.Service
{
    public interface IService
    {
        Matches AllMatchesByTeam(string name);

        Matches InfoAboutMatchByDate(DateTime date);

        int[] DifferenceOfGoals(Matches matches);

        void Refresh();

        void DeleteTeam(string name);

        void AddTeam(Team team);

        Team WorstTeamByLoosingGoals();

        Team BeastTeamByGoals();

        Team TeamWithMostDraws();

        Team WorstTeam();

        Team BestTeam();

        Team TeamByNameAndTown(string TownName, string TeamName);

        Team TeamByTownName(string townName);

        Team TeamByName(string? name);
    }
}
