using System;
using System.Collections.Generic;
using MFL.Data;

namespace MFL.Web.Models
{
    public class MovieDetailsModel
    {
        public MovieDetailsModel() { }

        public MovieDetailsModel(Movie m)
        {
            Id = m.MovieId;
            Title = m.Name;
            ReleaseDate = m.ReleaseDate;
            BoxOfficeMojoLink = m.BoxOfficeMojoLink;
            PosterLink = m.PosterLink;
            DomesticGross = m.DomesticGross;
            DraftCost = m.DraftCost;
            IsReplacement = m.IsReplacement;
            Notes = m.Note;
            SeasonId = m.Season.SeasonId;
            SeasonName = m.Season.Name;

            Efficiency = DomesticGross / DraftCost;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string BoxOfficeMojoLink { get; set; }

        public string PosterLink { get; set; }

        public decimal DomesticGross { get; set; }

        public decimal Efficiency { get; set; }

        public int DraftCost { get; set; }

        public bool IsReplacement { get; set; }

        public string Notes { get; set; }

        public string SeasonName { get; set; }

        public Guid SeasonId { get; set; }
    }
}