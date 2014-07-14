using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class SeasonDetailsModel
    {
        public SeasonDetailsModel() 
        {
            Standings = new StandingsModel();
            PlayerSummaries = new List<PlayerTeamSummaryModel>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartEditDate { get; set; }

        public DateTime EndEditDate { get; set; }

        public DateTime EndTotalUpdateDate { get; set; }

        public string Champion { get; set; }

        public Guid ChampionId { get; set; }

        public int Budget { get; set; }

        public string Notes { get; set; }

        public StandingsModel Standings { get; set; }

        public SeasonStatus Status { get; set; }

        public IList<PlayerTeamSummaryModel> PlayerSummaries { get; set; }
    }
}