using System;
using System.Collections.Generic;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository.Mock
{
    public class MockSeasonRepository: ISeasonRepository
    {
        private readonly Guid _plannedSeasonId = new Guid("327d0143-899e-4555-a545-11ebbf8ec6f5");
        private readonly Guid _onGoingSeasonId = new Guid("dee5444d-d1ac-4ccc-9572-045371f75fb9");
        private readonly Guid _draftingSeasonId = new Guid("762b8a08-34cd-421f-94e9-0a58603160ca");
        private readonly Guid _completedSeasonId = new Guid("cea72e9e-ec1d-41f6-98a7-c99c718e12a0");

        public Season GetById(Guid id)
        {
            Season result = new Season();

            if (id == _plannedSeasonId)
                result = _plannedSeason;
            else if (id == _onGoingSeasonId)
                result = _onGoingSeason;
            else if (id == _draftingSeasonId)
                result = _draftingSeason;
            else if (id == _completedSeasonId)
                result = _completedSeason;

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

            results.Add(_plannedSeason);
            results.Add(_onGoingSeason);
            results.Add(_draftingSeason);
            results.Add(_completedSeason);

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
            if (seasonId == _completedSeasonId)
            {
                t.Season = new Season() { SeasonId = _completedSeason.SeasonId, Name = _completedSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = _completedSeason.EndDate.AddDays(-20), DomesticGross = 41225 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = _completedSeason.EndDate.AddDays(-23), DomesticGross = 5454514 });
            }
            else if (seasonId == _draftingSeasonId)
            {
                t.Season = new Season() { SeasonId = _draftingSeason.SeasonId, Name = _draftingSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = _draftingSeason.EndDate.AddDays(-20), DomesticGross = 41225 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = _draftingSeason.EndDate.AddDays(-20), DomesticGross = 5454514 });
            }
            else if(seasonId == _onGoingSeasonId)
            {
                t.Season = new Season() { SeasonId = _onGoingSeason.SeasonId, Name = _onGoingSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = _onGoingSeason.EndDate.AddDays(-20), DomesticGross = 41225 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = _onGoingSeason.EndDate.AddDays(-20), DomesticGross = 5454514 });
            }
            else
            {
                t.Season = new Season() { SeasonId = _plannedSeason.SeasonId, Name = _plannedSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = _plannedSeason.EndDate.AddDays(-20), DomesticGross = 41225 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = _plannedSeason.EndDate.AddDays(-20), DomesticGross = 5454514 });
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

        private Season _plannedSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = _plannedSeasonId;
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

        private Season _onGoingSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = _onGoingSeasonId;
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

        private Season _draftingSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = _onGoingSeasonId;
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

        private Season _completedSeason
        {
            get
            {
                Season result = new Season();
                result.SeasonId = _onGoingSeasonId;
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

        private Team _mockTeam1
        {
            get
            {
                Team result = new Team();

                return result;
            }
        }

        private Team _mockTeam2
        {
            get
            {
                Team result = new Team();

                return result;
            }
        }
    }
}
