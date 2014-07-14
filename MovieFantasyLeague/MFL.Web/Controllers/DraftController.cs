using MFL.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFL.Web.Controllers
{
    public class DraftController : Controller
    {
        public ActionResult Index()
        {
            DraftModel model = new DraftModel();



            return View(model);
        }
    }
}