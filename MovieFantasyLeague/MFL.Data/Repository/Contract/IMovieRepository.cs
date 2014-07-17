using System;

namespace MFL.Data.Repository.Contract
{
    public interface IMovieRepository: IRepository<Movie>
    {
        void UpdateDomesticGross(Guid id, decimal domesticGross);
    }
}
