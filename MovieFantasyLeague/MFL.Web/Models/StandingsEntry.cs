using System;
using MFL.Data;

namespace MFL.Web.Models
{
    public class StandingsEntry
    {
        public StandingsEntry() { }

        public StandingsEntry(Team t)
        {
            UserId = t.User.UserId;
            Name = t.User.Name;

            int movieCount = t.Movies.Count;
            int openMovies = 0;
            decimal total = 0;

            foreach(var m in t.Movies)
            {
                if (m.ReleaseDate <= DateTime.Now)
                    openMovies++;

                total += m.DomesticGross;
            }

            Total = total;
            Progess = openMovies + "/" + movieCount;
        }

        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Progess { get; set; }

        public decimal Total { get; set; }
    }
}