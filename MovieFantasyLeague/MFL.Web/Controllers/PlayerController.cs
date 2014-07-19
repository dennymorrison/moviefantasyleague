using MFL.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MFL.Web.Controllers
{
    public class PlayerController : BaseController
    {
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            PlayerListModel model = new PlayerListModel();

            var entities = PlayerRepository.List(-1, -1);

            List<PlayerListItemModel> players = new List<PlayerListItemModel>();
            foreach (var p in entities)
            {
                players.Add(new PlayerListItemModel(p));
            }

            model.Players = players;

            return View(model);
        }

        public ActionResult History(Guid id)
        {
            PlayerDetailsModel model = new PlayerDetailsModel(PlayerRepository.GetById(id));

            var teamEntities = PlayerRepository.GetPlayerTeams(id);

            List<PlayerTeamSummaryModel> teams = new List<PlayerTeamSummaryModel>();
            foreach(var t in teamEntities)
            {
                teams.Add(new PlayerTeamSummaryModel(t) { ShowSeasonName = true, ShowPlayerName = false });
            }

            model.Teams = teams;

            return View(model);
        }
	}
}