using System;
using System.Collections.Generic;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository.Mock
{
    public class MockMovieRepository: IMovieRepository
    {
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

            results.Add(MockDataSource.HarryPotter);
            results.Add(MockDataSource.Expendables);
            results.Add(MockDataSource.Indy);
            results.Add(MockDataSource.Pulp);

            return results;
        }

        public Movie GetById(Guid id)
        {
            Movie result = new Movie();

            if (id == MockDataSource.HarryPotterId)
                result = MockDataSource.HarryPotter;
            else if (id == MockDataSource.ExpendablesId)
                result = MockDataSource.Expendables;
            else if (id == MockDataSource.IndyId)
                result = MockDataSource.Indy;
            else if (id == MockDataSource.PulpId)
                result = MockDataSource.Pulp;

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
    }
}
