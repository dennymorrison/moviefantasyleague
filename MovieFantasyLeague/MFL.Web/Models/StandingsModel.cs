using System;
using System.Collections.Generic;

namespace MFL.Web.Models
{
    public class StandingsModel
    {
        public StandingsModel()
        {
            Standings = new List<StandingsEntry>();            
        }

        public Guid SeasonId { get; set; }

        public string SeasonName { get; set; }

        public IList<StandingsEntry> Standings { get; set; }
    }
}