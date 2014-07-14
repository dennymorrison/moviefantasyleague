using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class SeasonListItemModel
    {
        public SeasonListItemModel() { }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DateRange { get; set; }

        public string Champion { get; set; }

        public Guid ChampionId { get; set; }

        public decimal ChampionTotal { get; set; }
    }
}