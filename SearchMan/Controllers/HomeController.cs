using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchMan.Models;

namespace SearchMan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Search()
        {
            ViewBag.Message = "Your search page.";

            return View();
        }

        [HttpPost]
        public ActionResult QueryView(string searchKeyword)
        {
            var model = new SearchModel {
                Word = searchKeyword
        };

            return View( model);
        }

    }
}