using System;
using MFL.Data;

namespace MFL.Web.Models
{
    public class MovieTeamListModel
    {
        public MovieTeamListModel() { }

        public MovieTeamListModel(Movie m)
        {
            Id = m.MovieId;
            Title = m.Name;
            ReleaseDate = m.ReleaseDate;
            DomesticGross = m.DomesticGross;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal DomesticGross { get; set; }
    }
}