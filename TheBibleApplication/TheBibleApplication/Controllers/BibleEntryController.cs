using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheBibleApplication.Controllers
{
    public class BibleEntryController : Controller
    {
        // GET: BibleEntry
        public ActionResult BibleIndex()
        {
            return View();
        }

        // GET: BibleEntry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BibleEntry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BibleEntry/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("BibleIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: BibleEntry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BibleEntry/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("BibleIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: BibleEntry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BibleEntry/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("BibleIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
