using System;
using System.Collections.Generic;

namespace MFL.Data.Repository.Mock
{
    public static class MockDataSource
    {
        public static readonly Guid PlannedSeasonId = new Guid("327d0143-899e-4555-a545-11ebbf8ec6f5");
        public static readonly Guid OnGoingSeasonId = new Guid("dee5444d-d1ac-4ccc-9572-045371f75fb9");
        public static readonly Guid DraftingSeasonId = new Guid("762b8a08-34cd-421f-94e9-0a58603160ca");
        public static readonly Guid CompletedSeasonId = new Guid("cea72e9e-ec1d-41f6-98a7-c99c718e12a0");

        public static readonly Guid DennyId = new Guid("7e1009d6-d456-45bd-a0a5-1ad3f4c36560");
        public static readonly Guid HeatherId = new Guid("d9df67e7-99e7-4884-b356-01b48a7297e2");
        public static readonly Guid RobertId = new Guid("32eae10e-dc73-4787-8f44-75e1fbd0ffb0");

        public static readonly Guid HarryPotterId = new Guid("5435a792-9af0-4bd5-b323-b6623afb0d80");
        public static readonly Guid ExpendablesId = new Guid("04c41a9e-ae24-4d34-8cd2-45bd0e773e41");
        public static readonly Guid IndyId = new Guid("8c0f46da-696f-4dc1-b272-00553e29d223");
        public static readonly Guid PulpId = new Guid("cfbfac9d-bf46-4ad8-b9f0-fdcf2ed83a23");

        public static readonly Guid LeagueId = new Guid("8518119b-c381-4199-9933-90a61bbee037");
        public static readonly Guid ChampionTeamId = new Guid("e3bde346-484c-4e8a-87c4-bc37df6dfed5");

        public static Team GetTeamForPlayerAndSeason(Guid playerId, Guid seasonId)
        {
            Team result = new Team();

            result.LeagueId = LeagueId;
            result.TeamId = Guid.NewGuid();

            if (playerId == DennyId)
            {
                result.User = new User() { UserId = DennyId, Name = Denny.Name };
            }
            else if(playerId == HeatherId)
            {
                result.User = new User() { UserId = HeatherId, Name = Heather.Name };
            }
            else if(playerId == RobertId)
            {
                result.User = new User() { UserId = RobertId, Name = Robert.Name };
            }

            List<Movie> movies = new List<Movie>();
            if (seasonId == MockDataSource.CompletedSeasonId)
            {
                result.Season = new Season() { SeasonId = MockDataSource.CompletedSeason.SeasonId, Name = MockDataSource.CompletedSeason.Name, Team = ChampionTeam };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = MockDataSource.CompletedSeason.EndDate.AddDays(-20), DomesticGross = 412254445 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = MockDataSource.CompletedSeason.EndDate.AddDays(-23), DomesticGross = 545444514 });
            }
            else if (seasonId == MockDataSource.DraftingSeasonId)
            {
                result.Season = new Season() { SeasonId = MockDataSource.DraftingSeason.SeasonId, Name = MockDataSource.DraftingSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = MockDataSource.DraftingSeason.EndDate.AddDays(-20), DomesticGross = 0 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = MockDataSource.DraftingSeason.EndDate.AddDays(-20), DomesticGross = 0 });
            }
            else if (seasonId == MockDataSource.OnGoingSeasonId)
            {
                result.Season = new Season() { SeasonId = MockDataSource.OnGoingSeason.SeasonId, Name = MockDataSource.OnGoingSeason.Name };
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "Harry Potter", ReleaseDate = MockDataSource.OnGoingSeason.EndDate.AddDays(-20), DomesticGross = 41225 });
                movies.Add(new Movie() { MovieId = Guid.NewGuid(), Name = "James Bond", ReleaseDate = MockDataSource.OnGoingSeason.EndDate.AddDays(-20), DomesticGross = 5454514 });
            }
            else
            {
                result.Season = new Season() { SeasonId = MockDataSource.PlannedSeason.SeasonId, Name = MockDataSource.PlannedSeason.Name };
            }

            result.Movies = movies;

            return result;
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

        public static User Denny
        {
            get
            {
                User result = new User();
                result.UserId = DennyId;
                result.Name = "Denny";
                result.IsAdmin = true;
                result.EmailAddress = "email@email.com";

                return result;
            }
        }

        public static User Heather
        {
            get
            {
                User result = new User();
                result.UserId = HeatherId;
                result.Name = "Heather";
                result.IsAdmin = false;
                result.EmailAddress = "email@email.com";

                return result;
            }
        }

        public static User Robert
        {
            get
            {
                User result = new User();
                result.UserId = RobertId;
                result.Name = "Robert";
                result.IsAdmin = false;
                result.EmailAddress = "email@email.com";

                return result;
            }
        }

        public static Movie HarryPotter
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = HarryPotterId;
                result.Name = "Harry Potter and the Prisoner of Azkaban";
                result.ReleaseDate = new DateTime(2004, 6, 4);
                result.IsReplacement = false;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=harrypotter3.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BMTY4NTIwODg0N15BMl5BanBnXkFtZTcwOTc0MjEzMw@@._V1_SY317_CR0,0,214,317_AL_.jpg";
                result.DraftCost = 42;
                result.DomesticGross = 547845574;
                result.Season = new Season() { SeasonId = MockDataSource.OnGoingSeasonId, Name = MockDataSource.OnGoingSeason.Name };

                return result;
            }
        }

        public static Movie Expendables
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = ExpendablesId;
                result.Name = "The Expendables";
                result.ReleaseDate = new DateTime(2010, 8, 13);
                result.IsReplacement = true;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=expendables.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BNTUwODQyNjM0NF5BMl5BanBnXkFtZTcwNDMwMTU1Mw@@._V1_SX214_AL_.jpg";
                result.DraftCost = 10;
                result.Note = "Note on the movie.";
                result.DomesticGross = 41411313;
                result.Season = new Season() { SeasonId = MockDataSource.OnGoingSeasonId, Name = MockDataSource.OnGoingSeason.Name };

                return result;
            }
        }

        public static Movie Indy
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = IndyId;
                result.Name = "Raiders of the Lost Ark";
                result.ReleaseDate = new DateTime(1981, 6, 12);
                result.IsReplacement = false;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=raidersofthelostark.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BMjA0ODEzMTc1Nl5BMl5BanBnXkFtZTcwODM2MjAxNA@@._V1_SX214_AL_.jpg";
                result.DraftCost = 12;
                result.DomesticGross = 1577981;
                result.Season = new Season() { SeasonId = MockDataSource.OnGoingSeasonId, Name = MockDataSource.OnGoingSeason.Name };

                return result;
            }
        }

        public static Movie Pulp
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = PulpId;
                result.Name = "Pulp Fiction";
                result.ReleaseDate = new DateTime(1994, 10, 14);
                result.IsReplacement = false;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=pulpfiction.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BMjE0ODk2NjczOV5BMl5BanBnXkFtZTYwNDQ0NDg4._V1_SY317_CR4,0,214,317_AL_.jpg";
                result.DraftCost = 8;
                result.DomesticGross = 649849848;
                result.Season = new Season() { SeasonId = MockDataSource.OnGoingSeasonId, Name = MockDataSource.OnGoingSeason.Name };

                return result;
            }
        }

        public static Team ChampionTeam
        {
            get
            {
                Team result = new Team();

                result.TeamId = ChampionTeamId;
                result.User = new User() { UserId = DennyId, Name = Denny.Name };                

                return result;
            }
        }
    }
}
