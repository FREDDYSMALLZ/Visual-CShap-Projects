using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApplication.Controllers
{
    public class Users : Controller
    {
       
        //Registration Action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
    }
}