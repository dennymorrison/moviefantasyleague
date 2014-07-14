using System;

namespace MFL.Web.Models
{
    public class MovieTeamListModel
    {
        public MovieTeamListModel() { }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal DomesticGross { get; set; }
    }
}