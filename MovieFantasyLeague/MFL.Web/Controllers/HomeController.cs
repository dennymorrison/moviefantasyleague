using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MFL.Web.Models;

namespace MFL.Web.Controllers
{
    [RequireHttps]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();

            var teamEntities = SeasonRepository.GetLeagueTeamsForSeason(GetPlayerLeagueId(), GetCurrentSeasonId());

            List<StandingsEntry> standings = new List<StandingsEntry>();

            foreach(var t in teamEntities)
            {
                standings.Add(new StandingsEntry(t));
            }

            model.Standings.SeasonName = teamEntities.First().Season.Name;
            model.Standings.Standings = standings;
            model.Standings.IsHomepage = true;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}