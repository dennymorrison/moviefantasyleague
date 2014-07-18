using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data.Repository.Contract
{
    public interface ISeasonRepository: IRepository<Season>
    {
        Season GetSeasonForHomepage();

        Season GetPlannedSeason();

        IList<Team> GetLeagueTeamsForSeason(Guid leagueId, Guid seasonId);
    }
}
