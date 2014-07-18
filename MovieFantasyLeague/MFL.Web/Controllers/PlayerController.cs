using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MFL.Web.Models;

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

        public ActionResult Details(Guid id)
        {
            PlayerDetailsModel model = new PlayerDetailsModel(PlayerRepository.GetById(id));
            return View(model);
        }
	}
}