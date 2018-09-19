using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BibleVerseApplication.Models;

namespace BibleVerseApplication.Controllers
{
    public class BibleUserEntriesController : Controller
    {
        private BibleVerseApplicationContext db = new BibleVerseApplicationContext();

        // GET: BibleUserEntries
        public ActionResult Index()
        {
            return View(db.BibleUserEntries.ToList());
        }

        // GET: BibleUserEntries/Details/5
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

        // GET: BibleUserEntries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BibleUserEntries/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BibleUserEntry bibleUserEntry)
        {
            if (ModelState.IsValid)
            {
                db.BibleUserEntries.Add(bibleUserEntry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bibleUserEntry);
        }

        // GET: BibleUserEntries/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: BibleUserEntries/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BibleUserEntry bibleUserEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bibleUserEntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bibleUserEntry);
        }

        // GET: BibleUserEntries/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: BibleUserEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BibleUserEntry bibleUserEntry = db.BibleUserEntries.Find(id);
            db.BibleUserEntries.Remove(bibleUserEntry);
            db.SaveChanges();
            return RedirectToAction("Index");
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
