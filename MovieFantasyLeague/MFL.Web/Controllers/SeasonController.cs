using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MFL.Web.Models;

namespace MFL.Web.Controllers
{
    public class SeasonController : Controller
    {
        public ActionResult Index()
        {
            SeasonsListModel model = new SeasonsListModel();

            List<SeasonListItemModel> seasons = new List<SeasonListItemModel>();

            seasons.Add(new SeasonListItemModel() { Name = "Summer 2014", DateRange = "4/4/2014 - 9/5/2014", Champion = "Heather" });

            model.Seasons = seasons;

            return View(model);
        }
	}
}