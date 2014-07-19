using System;
using System.Collections.Generic;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository.Mock
{
    public class MockSeasonRepository: ISeasonRepository
    {
        public Season GetById(Guid id)
        {
            Season result = new Season();

            if (id == MockDataSource.PlannedSeasonId)
                result = MockDataSource.PlannedSeason;
            else if (id == MockDataSource.OnGoingSeasonId)
                result = MockDataSource.OnGoingSeason;
            else if (id == MockDataSource.DraftingSeasonId)
                result = MockDataSource.DraftingSeason;
            else if (id == MockDataSource.CompletedSeasonId)
                result = MockDataSource.CompletedSeason;

            return result;
        }

        public bool Update(Season entity)
        {
            return true;
        }

        public bool Delete(Guid id)
        {
            return true;
        }

        public bool Create(Season entity)
        {
            return true;
        }

        public IList<Season> List(int skip, int take)
        {
            List<Season> results = new List<Season>();

            results.Add(MockDataSource.PlannedSeason);
            results.Add(MockDataSource.OnGoingSeason);
            results.Add(MockDataSource.DraftingSeason);
            results.Add(MockDataSource.CompletedSeason);

            return results;
        }

        public IList<Team> GetLeagueTeamsForSeason(Guid leagueId, Guid seasonId)
        {
            List<Team> results = new List<Team>();

            results.Add(MockDataSource.GetTeamForPlayerAndSeason(MockDataSource.DennyId, seasonId));
            results.Add(MockDataSource.GetTeamForPlayerAndSeason(MockDataSource.HeatherId, seasonId));
            results.Add(MockDataSource.GetTeamForPlayerAndSeason(MockDataSource.RobertId, seasonId));

            return results;
        }

        public Season GetSeasonForHomepage()
        {
            return MockDataSource.OnGoingSeason;
        }

        public Season GetPlannedSeason()
        {
            return MockDataSource.PlannedSeason;
        }
    }
}
