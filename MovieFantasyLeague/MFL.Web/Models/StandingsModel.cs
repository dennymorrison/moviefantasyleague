using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class StandingsModel
    {
        public StandingsModel()
        {
            Standings = new List<StandingsEntry>();            
        }

        public string Title { get; set; }

        public IList<StandingsEntry> Standings { get; set; }
    }
}