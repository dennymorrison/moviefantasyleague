using MFL.Data.Repository.Contract;
using System;
using System.Collections.Generic;

namespace MFL.Data.Repository.Mock
{
    public class MockMovieRepository: IMovieRepository
    {
        public bool Delete(Movie entity)
        {
            return true;
        }

        public bool Create(Movie entity)
        {
            return true;
        }

        public int SaveChanges()
        {
            return 0;
        }

        public IList<Movie> List(int skip, int take)
        {
            List<Movie> results = new List<Movie>();

            Movie m = new Movie();
            m.MovieID = Guid.NewGuid();
            m.Title = "Harry Potter";
            m.ReleaseDate = new DateTime(2014, 5, 10);
            m.IsReplacement = false;
            m.BoxOfficeMojoLink = "http://www.boxofficemojo.com";
            m.PosterLink = "";
            m.DraftCost = 20;

            Movie m1 = new Movie();
            m1.MovieID = Guid.NewGuid();
            m1.Title = "The Expendables";
            m1.ReleaseDate = new DateTime(2013, 5, 21);
            m1.IsReplacement = true;
            m1.Notes = "I was a replacement movie.";
            m1.BoxOfficeMojoLink = "";
            m1.PosterLink = "";
            m1.DraftCost = 10;

            Season s = new Season() { SeasonID = Guid.NewGuid(), Name = "Summer 2014" };

            m.Season = s;
            m1.Season = s;

            results.Add(m);
            results.Add(m1);

            return results;
        }

        public Movie GetById(Guid id)
        {
            Movie result = new Movie();
            result.MovieID = id;
            result.Title = "Harry Potter";
            result.ReleaseDate = new DateTime(2014, 5, 10);
            result.IsReplacement = false;
            result.BoxOfficeMojoLink = "http://www.boxofficemojo.com";
            result.PosterLink = "";
            result.DraftCost = 20;

            return result;
        }
    }
}
