using System;
using System.Collections.Generic;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository.Mock
{
    public class MockMovieRepository: IMovieRepository
    {
        private readonly Guid _harryPotterId = new Guid("5435a792-9af0-4bd5-b323-b6623afb0d80");
        private readonly Guid _expendablesId = new Guid("04c41a9e-ae24-4d34-8cd2-45bd0e773e41");
        private readonly Guid _indyId = new Guid("8c0f46da-696f-4dc1-b272-00553e29d223");
        private readonly Guid _pulpId = new Guid("cfbfac9d-bf46-4ad8-b9f0-fdcf2ed83a23");

        public bool Delete(Guid id)
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

            results.Add(_harryPotter);
            results.Add(_expendables);
            results.Add(_indy);
            results.Add(_pulp);

            return results;
        }

        public Movie GetById(Guid id)
        {
            Movie result = new Movie();

            if (id == _harryPotterId)
                result = _harryPotter;
            else if (id == _expendablesId)
                result = _expendables;
            else if (id == _indyId)
                result = _indy;
            else if (id == _pulpId)
                result = _pulp;

            return result;
        }

        public void UpdateDomesticGross(Guid id, decimal domesticGross)
        {
            return;
        }

        public bool Update(Movie entity)
        {
            return true;
        }

        private Movie _harryPotter
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = _harryPotterId;
                result.Name = "Harry Potter and the Prisoner of Azkaban";
                result.ReleaseDate = new DateTime(2004, 6, 4);
                result.IsReplacement = false;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=harrypotter3.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BMTY4NTIwODg0N15BMl5BanBnXkFtZTcwOTc0MjEzMw@@._V1_SY317_CR0,0,214,317_AL_.jpg";
                result.DraftCost = 42;
                result.DomesticGross = 547845574;

                return result;
            }
        }

        private Movie _expendables
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = _expendablesId;
                result.Name = "The Expendables";
                result.ReleaseDate = new DateTime(2010, 8, 13);
                result.IsReplacement = true;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=expendables.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BNTUwODQyNjM0NF5BMl5BanBnXkFtZTcwNDMwMTU1Mw@@._V1_SX214_AL_.jpg";
                result.DraftCost = 10;
                result.Note = "Note on the movie.";
                result.DomesticGross = 41411313;

                return result;
            }
        }

        private Movie _indy
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = _indyId;
                result.Name = "Raiders of the Lost Ark";
                result.ReleaseDate = new DateTime(1981, 6, 12);
                result.IsReplacement = false;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=raidersofthelostark.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BMjA0ODEzMTc1Nl5BMl5BanBnXkFtZTcwODM2MjAxNA@@._V1_SX214_AL_.jpg";
                result.DraftCost = 12;
                result.DomesticGross = 1577981;

                return result;
            }
        }

        private Movie _pulp
        {
            get
            {
                Movie result = new Movie();
                result.MovieId = _pulpId;
                result.Name = "Pulp Fiction";
                result.ReleaseDate = new DateTime(1994, 10, 14);
                result.IsReplacement = false;
                result.BoxOfficeMojoLink = "http://boxofficemojo.com/movies/?id=pulpfiction.htm";
                result.PosterLink = "http://ia.media-imdb.com/images/M/MV5BMjE0ODk2NjczOV5BMl5BanBnXkFtZTYwNDQ0NDg4._V1_SY317_CR4,0,214,317_AL_.jpg";
                result.DraftCost = 8;
                result.DomesticGross = 649849848;

                return result;
            }
        }
    }
}
