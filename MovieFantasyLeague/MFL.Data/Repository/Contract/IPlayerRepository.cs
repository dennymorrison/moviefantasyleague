using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data.Repository.Contract
{
    public interface IPlayerRepository: IRepository<User>
    {
        IList<Team> GetPlayerTeams(Guid playerId);
    }
}
