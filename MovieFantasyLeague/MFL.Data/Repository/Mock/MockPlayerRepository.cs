using MFL.Data.Repository.Contract;
using System;
using System.Collections.Generic;

namespace MFL.Data.Repository.Mock
{
    public class MockPlayerRepository: IPlayerRepository
    {
        public bool Delete(Guid id)
        {
            return true;
        }

        public bool Create(User entity)
        {
            return true;
        }

        public IList<User> List(int skip, int take)
        {
            List<User> results = new List<User>();

            results.Add(MockDataSource.Denny);
            results.Add(MockDataSource.Heather);
            results.Add(MockDataSource.Robert);

            return results;
        }

        public User GetById(Guid id)
        {
            User result = new User();

            if (id == MockDataSource.DennyId)
                result = MockDataSource.Denny;
            else if (id == MockDataSource.HeatherId)
                result = MockDataSource.Heather;
            else if (id == MockDataSource.RobertId)
                result = MockDataSource.Robert;

            return result;
        }

        public bool Update(User entity)
        {
            return true;
        }

        public IList<Team> GetPlayerTeams(Guid playerId)
        {
            List<Team> results = new List<Team>();

            results.Add(MockDataSource.GetTeamForPlayerAndSeason(playerId, MockDataSource.CompletedSeasonId));
            results.Add(MockDataSource.GetTeamForPlayerAndSeason(playerId, MockDataSource.DraftingSeasonId));
            results.Add(MockDataSource.GetTeamForPlayerAndSeason(playerId, MockDataSource.ExpendablesId));
            results.Add(MockDataSource.GetTeamForPlayerAndSeason(playerId, MockDataSource.OnGoingSeasonId));

            return results;
        }
    }
}
