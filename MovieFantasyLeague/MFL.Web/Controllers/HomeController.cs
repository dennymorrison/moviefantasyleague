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

            var currentSeason = SeasonRepository.GetSeasonForHomepage();
            var teamEntities = SeasonRepository.GetLeagueTeamsForSeason(GetPlayerLeagueId(), currentSeason.SeasonId);
            var plannedSeason = SeasonRepository.GetPlannedSeason();

            if(plannedSeason !=null)
            {
                model.PlannedSeason = new SeasonDetailsModel(plannedSeason);
                model.IsNewSeasonPlanned = true;
            }
            else
            {
                model.IsNewSeasonPlanned = false;
            }

            List<StandingsEntry> standings = new List<StandingsEntry>();

            foreach(var t in teamEntities)
            {
                standings.Add(new StandingsEntry(t));
            }

            model.Standings.SeasonId = teamEntities.First().Season.SeasonId;
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