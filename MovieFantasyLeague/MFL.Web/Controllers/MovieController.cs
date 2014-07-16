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
            MovieDetailsModel model = new MovieDetailsModel();

            model.Id = Guid.NewGuid();
            model.Title = "Harry Potter";
            model.ReleaseDate = new DateTime(2011, 5, 20);
            model.BoxOfficeMojoLink = "http://www.boxofficemojo.com";
            model.PosterLink = "http://ia.media-imdb.com/images/M/MV5BMTYwNTM5NDkzNV5BMl5BanBnXkFtZTYwODQ4MzY5._V1_SY317_CR8,0,214,317_AL_.jpg";
            model.DomesticGross = 43523535;
            model.DraftCost = 14;
            model.Efficiency = model.DomesticGross / model.DraftCost;
            model.IsReplacement = false;
            model.Notes = "Some notes";
            model.SeasonName = "Summer 2014";
            model.SeasonId = Guid.NewGuid();

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
