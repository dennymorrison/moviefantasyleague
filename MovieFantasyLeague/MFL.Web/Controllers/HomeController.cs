using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MFL.Web.Models;

namespace MFL.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();

            List<StandingsEntry> standings = new List<StandingsEntry>();

            for (int i = 0; i < 5; i++ )
            {
                StandingsEntry s = new StandingsEntry();
                s.Name = "denny " + i;
                s.Progess = i  + " / " + 5;
                s.Total = i * 100;

                standings.Add(s);
            }

            model.Standings.SeasonName = "Summer 2014";
            model.Standings.Standings = standings;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}