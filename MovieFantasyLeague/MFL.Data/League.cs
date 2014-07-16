using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data
{
    public class League
    {
        public League() { }

        public Guid LeagueID { get; set; }

        public string Name { get; set; }

        public virtual IList<Player> Players { get; set; }

        public virtual IList<Team> Teams { get; set; }
    }
}
