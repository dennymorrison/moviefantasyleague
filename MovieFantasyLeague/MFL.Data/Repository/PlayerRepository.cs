using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFL.Data.Repository.Contract;

namespace MFL.Data.Repository
{
    public class PlayerRepository: IPlayerRepository
    {
        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Create(User entity)
        {
            throw new NotImplementedException();
        }

        public IList<User> List(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }

        public IList<Team> GetPlayerTeams(Guid playerId)
        {
            throw new NotImplementedException();
        }
    }
}
