using System;
using MFL.Data;

namespace MFL.Web.Models
{
    public class MovieDraftListModel
    {
        public MovieDraftListModel(Movie m)
        {
            Id = m.MovieId;
            Title = m.Name;
            DraftCost = m.DraftCost;
            ReleaseDate = m.ReleaseDate;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public int DraftCost { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsSelected { get; set; }
    }
}