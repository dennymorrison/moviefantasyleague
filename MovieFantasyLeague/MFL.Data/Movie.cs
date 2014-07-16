using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data
{
    public class Movie
    {
        public Movie() { }

        public Guid MovieID { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int DraftCost { get; set; }

        public decimal DomesticGross { get; set; }

        public bool IsReplacement { get; set; }

        public string Notes { get; set; }

        public string BoxOfficeMojoLink { get; set; }

        public string PosterLink { get; set; }

        public virtual IList<Team> Teams { get; set; }

        public virtual Season Season { get; set; }
    }
}
