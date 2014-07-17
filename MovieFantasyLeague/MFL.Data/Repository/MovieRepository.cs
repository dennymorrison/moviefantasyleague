using System;
using System.Collections.Generic;
using System.Linq;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository
{
    public class MovieRepository: IMovieRepository
    {
        public bool Delete(Guid id)
        {
            bool result = true;

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    var entity = db.Movies.SingleOrDefault(m => m.MovieId == id);
                    if (entity != null)
                    {
                        db.Movies.Remove(entity);
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

        public bool Create(Movie entity)
        {
            bool result = true;

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    db.Movies.Add(entity);
                    db.SaveChanges();
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public Movie GetById(Guid id)
        {
            Movie result = new Movie();

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    var entity = db.Movies.SingleOrDefault(m => m.MovieId == id);
                    if (entity != null)
                    {
                        result = entity;
                    }
                }
            }
            catch
            {

            }

            return result;
        }

        public IList<Movie> List(int skip, int take)
        {
            List<Movie> results = new List<Movie>();

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    if (skip != -1 && take != -1)
                    {
                        var movies = db.Movies.Skip(skip).Take(take);
                        foreach (var m in movies)
                        {
                            results.Add(new Movie() { MovieId = m.MovieId, Name = m.Name, Season = new Season() { SeasonId = m.Season.SeasonId, Name = m.Season.Name } });
                        }
                    }
                    else
                    {
                        foreach (var m in db.Movies)
                        {
                            results.Add(new Movie() { MovieId = m.MovieId, Name = m.Name, Season = new Season() { SeasonId = m.Season.SeasonId, Name = m.Season.Name } });
                        }
                    }
                }
            }
            catch
            {

            }

            return results;
        }

        public bool Update(Movie entity)
        {
            bool result = true;

            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    var existing = db.Movies.SingleOrDefault(m => m.MovieId == entity.MovieId);
                    if(existing !=null)
                    {
                        existing.Name = entity.Name;
                        existing.ReleaseDate = entity.ReleaseDate;
                        existing.DraftCost = entity.DraftCost;
                        existing.IsReplacement = entity.IsReplacement;
                        existing.Note = entity.Note;
                        existing.PosterLink = entity.PosterLink;
                        existing.BoxOfficeMojoLink = entity.BoxOfficeMojoLink;
                        existing.Season.SeasonId = entity.Season.SeasonId;

                        db.SaveChanges();
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public void UpdateDomesticGross(Guid id, decimal domesticGross)
        {
            try
            {
                using (var db = new MovieFantasyLeagueEntities())
                {
                    var existing = db.Movies.SingleOrDefault(m => m.MovieId == id);
                    if(existing!=null)
                    {
                        existing.DomesticGross = domesticGross;
                        db.SaveChanges();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
