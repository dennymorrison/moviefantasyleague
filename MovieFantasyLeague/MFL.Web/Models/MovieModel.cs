using System;
using System.Collections.Generic;

namespace MFL.Web.Models
{
    public class MovieModel
    {
        public MovieModel() { }

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
    }
}