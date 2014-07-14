using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class MovieListItemModel
    {
        public MovieListItemModel() { }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public Guid SeasonId { get; set; }

        public string SeasonName { get; set; }

        public int DraftCost { get; set; }

        public bool IsReplacement { get; set; }

        public string BoxOfficeMojoLink { get; set; }
    }
}