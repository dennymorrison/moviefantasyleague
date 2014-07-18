using System;
using System.Collections.Generic;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository.Mock
{
    public class MockSeasonRepository: ISeasonRepository
    {
        public static readonly Guid PlannedSeasonId = new Guid("327d0143-899e-4555-a545-11ebbf8ec6f5");
        public static readonly Guid OnGoingSeasonId = new Guid("dee5444d-d1ac-4ccc-9572-045371f75fb9");
        public static readonly Guid DraftingSeasonId = new Guid("762b8a08-34cd-421f-94e9-0a58603160ca");
        public static readonly Guid CompletedSeasonId = new Guid("cea72e9e-ec1d-41f6-98a7-c99c718e12a0");

        public Season GetById(Guid id)
        {
            Season result = new Season();

            if (id == PlannedSeasonId)
                result = PlannedSeason;
            else if (id == OnGoingSeasonId)
                result = OnGoingSeason;
            else if (id == DraftingSeasonId)
                result = DraftingSeason;
            else if (id == CompletedSeasonId)
                result = CompletedSeason;

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

            results.Add(PlannedSeason);
            results.Add(OnGoingSeason);
            results.Add(DraftingSeason);
            results.Add(CompletedSeason);

            return results;
        }

        public IList<Team> GetLeagueTeamsForSeason(Guid leagueId, Guid seasonId)
        {
            List<Team> results = new List<Team>();

            Team t = new Team();
            t.LeagueId = leagueId;
            t.TeamId = Guid.NewGuid();
            t.User = new User() { UserId = Guid.NewGuid(), Name = "Denny" };

            List<Movie> movies = new List<Movie>();
            if (seasonId == CompletedSeasonId)
            {
                t.Season = new Season() { SeasonId = CompletedSeason.SeasonId, Name = CompletedSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = CompletedSeason.EndDate.AddDays(-20), DomesticGross = 412254445 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = CompletedSeason.EndDate.AddDays(-23), DomesticGross = 545444514 });
            }
            else if (seasonId == DraftingSeasonId)
            {
                t.Season = new Season() { SeasonId = DraftingSeason.SeasonId, Name = DraftingSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = DraftingSeason.EndDate.AddDays(-20), DomesticGross = 0 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = DraftingSeason.EndDate.AddDays(-20), DomesticGross = 0 });
            }
            else if(seasonId == OnGoingSeasonId)
            {
                t.Season = new Season() { SeasonId = OnGoingSeason.SeasonId, Name = OnGoingSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = OnGoingSeason.EndDate.AddDays(-20), DomesticGross = 41225 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = OnGoingSeason.EndDate.AddDays(-20), DomesticGross = 5454514 });
            }
            else
            {
                t.Season = new Season() { SeasonId = PlannedSeason.SeasonId, Name = PlannedSeason.Name };
            }                       

            t.Movies = movies;

            Team t1 = new Team();
            t1.LeagueId = leagueId;            
            t1.TeamId = Guid.NewGuid();
            t1.User = new User() { UserId = Guid.NewGuid(), Name = "Heather" };

            t1.Season = t.Season;
            t1.Movies = t.Movies;

            results.Add(t);
            results.Add(t1);

            return results;
        }

        public static Season PlannedSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = PlannedSeasonId;
                result.Name = "Planned Season";
                result.StartDate = DateTime.Now.AddMonths(2);
                result.EndDate = DateTime.Now.AddMonths(6);
                result.StartEdits = DateTime.Now.AddDays(5);
                result.EndEdits = DateTime.Now.AddDays(10);
                result.LastUpdateDate = result.EndDate.AddDays(1);
                result.Budget = 100;

                return result;
            }
        }

        public static Season OnGoingSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = OnGoingSeasonId;
                result.Name = "Currently Active Season";
                result.StartDate = DateTime.Now.AddMonths(-2);
                result.EndDate = DateTime.Now.AddMonths(4);
                result.StartEdits = DateTime.Now.AddDays(-15);
                result.EndEdits = DateTime.Now.AddDays(-10);
                result.LastUpdateDate = result.EndDate.AddDays(1);
                result.Budget = 100;

                return result;
            }
        }

        public static Season DraftingSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = DraftingSeasonId;
                result.Name = "Season with Active Draft";
                result.StartDate = DateTime.Now.AddMonths(1);
                result.EndDate = DateTime.Now.AddMonths(6);
                result.StartEdits = DateTime.Now.AddDays(-5);
                result.EndEdits = DateTime.Now.AddDays(10);
                result.LastUpdateDate = result.EndDate.AddDays(1);
                result.Budget = 100;

                return result;
            }
        }

        public static Season CompletedSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = CompletedSeasonId;
                result.Name = "Completed Season";
                result.StartDate = DateTime.Now.AddMonths(-12);
                result.EndDate = DateTime.Now.AddMonths(-6);
                result.StartEdits = DateTime.Now.AddMonths(-13);
                result.EndEdits = DateTime.Now.AddMonths(-13);
                result.LastUpdateDate = result.EndDate.AddDays(1);
                result.Budget = 100;
                result.ChampionTeamId = Guid.NewGuid();
                result.Team = new Team() { User = new User() { UserId = Guid.NewGuid(), Name = "Denny" } };

                return result;
            }
        }
    }
}
