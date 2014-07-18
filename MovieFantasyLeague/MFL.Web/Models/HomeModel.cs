using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class HomeModel
    {
        public HomeModel() 
        {
            Standings = new StandingsModel();
            PlannedSeason = new SeasonDetailsModel();
        }

        public StandingsModel Standings { get; set; }

        public SeasonDetailsModel PlannedSeason { get; set; }

        public bool IsNewSeasonPlanned { get; set; }
    }
}