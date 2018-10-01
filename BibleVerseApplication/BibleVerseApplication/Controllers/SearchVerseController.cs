using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BibleVerseApplication.Models;

namespace BibleVerseApplication.Controllers
{
    [Authorize]
    public class SearchVerseController : Controller
    {
        private BibleVerseApplicationContext db = new BibleVerseApplicationContext();

        // GET: SearchVerse
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "Testament")
            {
                return View(db.BibleUserEntries.Where(x => x.TestamentSelection == search || search == null).ToList());
            }
            else
            {
                return View(db.BibleUserEntries.Where(x => x.BookSelection.StartsWith(search) || search == null).ToList());
            }
            
        }
        // GET: SearchVerse/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BibleUserEntry bibleUserEntry = db.BibleUserEntries.Find(id);
            if (bibleUserEntry == null)
            {
                return HttpNotFound();
            }
            return View(bibleUserEntry);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
