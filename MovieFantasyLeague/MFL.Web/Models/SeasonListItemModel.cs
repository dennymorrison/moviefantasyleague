using System;
using MFL.Data;

namespace MFL.Web.Models
{
    public class SeasonListItemModel
    {
        public SeasonListItemModel() { }

        public SeasonListItemModel(Season s)
        {
            Id = s.SeasonId;
            Name = s.Name;
            DateRange = s.StartDate.ToShortDateString() + " - " + s.EndDate.ToShortDateString();
            ChampionId = s.ChampionTeamId.Value;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DateRange { get; set; }

        public string Champion { get; set; }

        public Guid ChampionId { get; set; }

        public decimal ChampionTotal { get; set; }
    }
}