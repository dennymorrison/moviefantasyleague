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
            result.Name = "Summer 2013";
            result.ChampionTeamId = Guid.NewGuid();
            result.StartDate = new DateTime(2013, 5, 1);
            result.EndDate = new DateTime(2013, 9, 20);
            result.Budget = 100;


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

            Season s = new Season();
            s.Name = "Summer 2013";
            s.ChampionTeamId = Guid.NewGuid();
            s.StartDate = new DateTime(2013, 5, 1);
            s.EndDate = new DateTime(2013, 9, 20);

            Season s1 = new Season();
            s1.Name = "Summer 2014";
            s1.StartDate = new DateTime(2014, 4, 20);
            s1.EndDate = new DateTime(2014, 9, 6);
            s1.ChampionTeamId = Guid.NewGuid();

            results.Add(s);
            results.Add(s1);

            return results;
        }

        public IList<Team> GetLeagueTeamsForSeason(Guid leagueId, Guid seasonId)
        {
            List<Team> results = new List<Team>();

            Team t = new Team();
            t.LeagueId = leagueId;
            t.Season = new Season() { SeasonId = seasonId, Name = "Summer 2014" };
            t.TeamId = Guid.NewGuid();
            t.User = new User() { UserId = Guid.NewGuid(), Name = "Denny" };

            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = new DateTime(2014, 5, 10), DomesticGross = 41225 });
            movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = new DateTime(2014, 7, 10), DomesticGross = 5454514 });

            t.Movies = movies;

            Team t1 = new Team();
            t1.LeagueId = leagueId;
            t1.SeasonId = seasonId;
            t1.TeamId = Guid.NewGuid();
            t1.User = new User() { UserId = Guid.NewGuid(), Name = "Heather" };

            t1.Movies = movies;

            results.Add(t);
            results.Add(t1);

            return results;
        }
    }
}
