using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MFL.Web.Models;

namespace MFL.Web.Controllers
{
    [RequireHttps]
    public class SeasonController : BaseController
    {
        public ActionResult Index()
        {
            SeasonsListModel model = new SeasonsListModel();
            List<SeasonListItemModel> seasons = new List<SeasonListItemModel>();

            var entities = SeasonRepository.List(-1, -1);

            foreach(var s in entities)
            {
                seasons.Add(new SeasonListItemModel(s));
            }

            model.Seasons = seasons;

            return View(model);
        }

        public ActionResult Details(Guid id)
        {
            var entity = SeasonRepository.GetById(id);
            var teamEntities = SeasonRepository.GetLeagueTeamsForSeason(GetPlayerLeagueId(), id);

            SeasonDetailsModel model = new SeasonDetailsModel(entity);
            List<StandingsEntry> standings = new List<StandingsEntry>();
            List<PlayerTeamSummaryModel> teamSummaries = new List<PlayerTeamSummaryModel>();

            foreach(var t in teamEntities)
            {
                standings.Add(new StandingsEntry(t));
                teamSummaries.Add(new PlayerTeamSummaryModel(t));
            }

            model.Standings = new StandingsModel() { SeasonName = model.Name, Standings = standings };

            model.PlayerSummaries = teamSummaries;

            return View(model);
        }
	}
}