using System;
using System.Collections.Generic;

namespace MFL.Data.Repository.Contract
{
    public interface IMovieRepository: IRepository<Movie>
    {
        void UpdateDomesticGross(Guid id, decimal domesticGross);

        IList<Movie> GetDraftListForLeagueAndSeason(Guid leagueId, Guid seasonId);
    }
}
