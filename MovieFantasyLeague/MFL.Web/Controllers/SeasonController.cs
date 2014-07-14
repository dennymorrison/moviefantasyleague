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

        public ActionResult Details(Guid id)
        {
            SeasonDetailsModel model = new SeasonDetailsModel();

            model.Id = Guid.NewGuid();
            model.Name = "Summer 2014";
            model.Notes = "Some notes";
            model.StartDate = new DateTime(2014, 4, 4);
            model.EndDate = new DateTime(2014, 9, 5);
            model.StartEditDate = new DateTime(2014, 3, 20);
            model.EndEditDate = new DateTime(2014, 4, 4);
            model.EndTotalUpdateDate = new DateTime(2014, 9, 6);
            model.Budget = 100;
            model.Champion = "";

            return View(model);
        }
	}
}