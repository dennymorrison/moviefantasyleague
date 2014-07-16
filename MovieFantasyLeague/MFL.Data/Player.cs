using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data
{
    public class Player
    {
        public Player() { }

        public Guid PlayerID { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public virtual IList<Team> Teams { get; set; }

        public virtual IList<League> Leagues { get; set; }
    }
}
