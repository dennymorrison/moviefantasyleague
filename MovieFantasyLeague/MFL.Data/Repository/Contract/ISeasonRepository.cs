using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data.Repository.Contract
{
    public interface ISeasonRepository: IRepository<Season>
    {
        //GetStandingsForSeason(Guid seasonId);

        IList<Team> GetLeagueTeamsForSeason(Guid leagueId, Guid seasonId);
    }
}
