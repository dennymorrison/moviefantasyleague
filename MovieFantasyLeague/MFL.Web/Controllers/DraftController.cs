using MFL.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFL.Web.Controllers
{
    [RequireHttps]
    public class DraftController : BaseController
    {
        [Authorize()]
        public ActionResult Index(Guid id)
        {
            DraftModel model = new DraftModel(SeasonRepository.GetById(id), CurrentUser);

            var movieEntities = MovieRepository.GetDraftListForLeagueAndSeason(GetPlayerLeagueId(), id);

            List<MovieDraftListModel> movies = new List<MovieDraftListModel>();
            foreach (var m in movieEntities)
            {
                movies.Add(new MovieDraftListModel(m));
            }

            model.Movies = movies;

            return View(model);
        }
    }
}