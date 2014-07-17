using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MFL.Web.Models;
using MFL.Data.Repository.Contract;

namespace MFL.Web.Controllers
{
    [RequireHttps]
    public class MovieController : BaseController
    {
        public ActionResult Index()
        {
            MoviesListModel model = new MoviesListModel();

            List<MovieListItemModel> movies = new List<MovieListItemModel>();

            IMovieRepository repository = GetMovieRepository();
            var entities = repository.List(-1, -1);

            foreach(var m in entities)
            {
                movies.Add(new MovieListItemModel(m));
            }

            model.Movies = movies;

            return View(model);
        }

        public ActionResult Details(Guid id)
        {
            IMovieRepository repository = GetMovieRepository();
            var entity = repository.GetById(id);

            MovieDetailsModel model = new MovieDetailsModel(entity);

            return View(model);
        }
        
        [Authorize(Roles="Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(FormCollection collection)
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(FormCollection collection)
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            return View();
        }
    }
}
