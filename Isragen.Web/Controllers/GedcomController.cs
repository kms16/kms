using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Isragen.Web.Controllers
{
    public class GedcomController : Controller
    {
        // GET: Gedcom
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gedcom/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gedcom/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gedcom/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gedcom/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gedcom/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gedcom/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gedcom/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
