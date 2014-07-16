using MFL.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data.Repository
{
    public class MovieRepository: IMovieRepository
    {
        public bool Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public bool Create(Movie entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IList<Movie> List(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Movie GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
