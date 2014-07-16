using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data
{
    public class Season
    {
        public Season() { }

        public Guid SeasonID { get; set; }

        public string Name { get; set; }

        public int Budget { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartEditDate { get; set; }

        public DateTime EndEditDate { get; set; }

        public DateTime LastTotalUpdateDate { get; set; }

        public virtual IList<Movie> Movies { get; set; }

        public virtual IList<Team> Teams { get; set; }

        public virtual Player Champion { get; set; }       
    }
}
