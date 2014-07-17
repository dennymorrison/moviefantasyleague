using MFL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class MovieListItemModel
    {
        public MovieListItemModel() { }

        public MovieListItemModel(Movie m)
        {
            Id = m.MovieId;
            Title = m.Name;
            SeasonId = m.Season.SeasonId;
            SeasonName = m.Season.Name;
            DraftCost = m.DraftCost;
            IsReplacement = m.IsReplacement;
            BoxOfficeMojoLink = m.BoxOfficeMojoLink;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public Guid SeasonId { get; set; }

        public string SeasonName { get; set; }

        public int DraftCost { get; set; }

        public bool IsReplacement { get; set; }

        public string BoxOfficeMojoLink { get; set; }
    }
}