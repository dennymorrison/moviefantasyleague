using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MFL.Web.Models;

namespace MFL.Web.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            MoviesListModel model = new MoviesListModel();

            List<MovieListItemModel> movies = new List<MovieListItemModel>();

            movies.Add(new MovieListItemModel() { Title = "Harry Potter", DraftCost = 13, SeasonName = "Summer 2011", SeasonId = Guid.NewGuid() });            

            model.Movies = movies;

            return View(model);
        }
    }
}
