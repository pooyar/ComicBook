using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Title";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "Sth";
            ViewBag.Artists = new string[]
            {
                "Pooya",
                "Marham"
            };

            return View();

        }
    }
}