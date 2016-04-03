using Isragen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Isragen.Web.Controllers
{
    public class ArchiveController : Controller
    {
        // GET: Archive
        public ActionResult Index()
        {
            return View();
        }

        // GET: Archive/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: Archive/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Archive/Edit/5
        [HttpPost]
        public ActionResult Edit(IsragenArchiveRecord record)
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
    }
}
