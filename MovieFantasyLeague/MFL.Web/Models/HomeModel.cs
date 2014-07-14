using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class HomeModel
    {
        public HomeModel() 
        {
            Standings = new StandingsModel();
        }

        public StandingsModel Standings { get; set; }
    }
}