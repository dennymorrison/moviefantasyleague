using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data
{
    public class Team
    {
        public Team() { }

        public Guid TeamID { get; set; }

        public virtual Player Owner { get; set; }

        public virtual Season Season { get; set; }

        public virtual IList<Movie> Movies { get; set; }

        public virtual League League { get; set; }
    }
}
