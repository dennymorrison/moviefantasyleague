using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Data
{
    public class MFLContext: DbContext
    {
        public MFLContext() : base() { }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<League> Leagues { get; set; }
    }
}
