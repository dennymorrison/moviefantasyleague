using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFL.Web.Models
{
    public class MoviesListModel
    {
        public MoviesListModel()
        {
            Movies = new List<MovieListItemModel>();
        }

        public IList<MovieListItemModel> Movies { get; set; }
    }
}