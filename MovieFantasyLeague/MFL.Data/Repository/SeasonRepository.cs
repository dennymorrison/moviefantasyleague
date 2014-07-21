using System;
using System.Collections.Generic;
using System.Linq;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository
{
    public class SeasonRepository: ISeasonRepository
    {
        public bool Delete(Guid id)
        {
            bool result = true;

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    var existing = db.Seasons.SingleOrDefault(s => s.SeasonId == id);
                    if (existing != null)
                    {
                        db.Seasons.Remove(existing);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Create(Season entity)
        {
            bool result = true;

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    db.Seasons.Add(entity);
                    db.SaveChanges();
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public IList<Season> List(int skip, int take)
        {
            List<Season> results = new List<Season>();

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    if (skip != -1 && take != -1)
                    {
                        var seasons = db.Seasons.Skip(skip).Take(take);
                        foreach (var s in seasons)
                        {
                            results.Add(new Season() { SeasonId = s.SeasonId, Name = s.Name, ChampionTeamId = s.ChampionTeamId, StartDate = s.StartDate, EndDate = s.EndDate });
                        }
                    }
                    else
                    {
                        foreach (var s in db.Seasons)
                        {
                            results.Add(new Season() { SeasonId = s.SeasonId, Name = s.Name, ChampionTeamId = s.ChampionTeamId, StartDate = s.StartDate, EndDate = s.EndDate });
                        }
                    }
                }
            }
            catch
            {

            }

            return results;
        }

        public Season GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Season entity)
        {
            throw new NotImplementedException();
        }

        public IList<Team> GetLeagueTeamsForSeason(Guid leagueId, Guid seasonId)
        {
            List<Team> results = new List<Team>();

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    var teams = db.Teams.Where(t => t.LeagueId == leagueId && t.SeasonId == seasonId);
                    foreach (var t in teams)
                    {
                        Team team = new Team() { TeamId = t.TeamId, User = new User() { UserId = t.User.UserId, Name = t.User.Name }, LeagueId = t.LeagueId, Season = new Season() { SeasonId = t.SeasonId, Name = t.Season.Name } };

                        List<Movie> movies = new List<Movie>();
                        foreach (var m in t.Movies)
                        {
                            movies.Add(new Movie() { MovieId = m.MovieId, BoxOfficeMojoLink = m.BoxOfficeMojoLink, DomesticGross = m.DomesticGross, Name = m.Name, ReleaseDate = m.ReleaseDate });
                        }

                        team.Movies = movies;

                        results.Add(team);
                    }
                }
            }
            catch
            {

            }

            return results;
        }
        public Season GetSeasonForHomepage()
        {
            Season result = new Season();

            return result;
        }

        public Season GetPlannedSeason()
        {
            Season result = new Season();

            return result;
        }

        public Season GetDraftSeason()
        {
            throw new NotImplementedException();
        }
    }
}
