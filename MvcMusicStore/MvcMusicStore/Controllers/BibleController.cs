using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class BibleController : Controller
    {
        // GET: Bible
        public ActionResult Index()
        {
            return View();
        }
    }
}