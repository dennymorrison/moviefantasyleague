using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class PlayerTeamSummaryModel
    {
        public PlayerTeamSummaryModel() { }

        public Guid PlayerId { get; set; }

        public string Player { get; set; }

        public SeasonListItemModel Season { get; set; }

        public List<MovieTeamListModel> Movies { get; set; }

        public decimal Total { get; set; }

        public decimal TeamEfficiency { get; set; }
    }
}