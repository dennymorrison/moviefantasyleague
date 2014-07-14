using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class SeasonsListModel
    {
        public SeasonsListModel()
        {
            Seasons = new List<SeasonListItemModel>();
        }

        public IList<SeasonListItemModel> Seasons { get; set; }
    }
}