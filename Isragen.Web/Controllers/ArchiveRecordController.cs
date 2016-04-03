using Isragen.Models;
using Isragen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Isragen.Web.Models
{
    public class ArchiveRecordController : Controller
    {
        // GET: ArchiveRecord/Index
        public ActionResult Index()
        {
            return View();
        }

        /*
        // GET: ArchiveRecord/Details/5
        public ActionResult Details(string id)
        {
            var archiveService = new IsragenArchiveService();
            var record = archiveService.Find(id);
            return RedirectToAction("Details", "ArchiveRecord", record);
        }*/

        // GET: ArchiveRecord/Details/Model
        public ActionResult Details(IsragenArchiveRecord record)
        {
            if (record != null)
            {
                return View(record);
            }

            return View("Error");
        }

        // GET: ArchiveRecord/List
        public ActionResult List(List<IsragenArchiveRecord> records)
        {
            return View(records);
        }

        // GET: ArchiveRecord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArchiveRecord/Create
        [HttpPost]
        public ActionResult Create(ArchiveRecordCreateViewModel model)
        {
            IsragenArchiveService archiveService;
            if (ModelState.IsValid)
            {
                try
                {
                    archiveService = new IsragenArchiveService();
                    if (archiveService.Add(model))
                    {
                        // TODO: Add insert logic here
                        return RedirectToAction("Details", "ArchiveRecord", model);
                    }
                }
                catch
                {
                    return View("NotSaved");
                }
            }
            return View("Create", model);
        }

        // GET: ArchiveRecord/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: ArchiveRecord/Edit/model
        [HttpPost]
        public ActionResult Edit(IsragenArchiveRecord model)
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

        // GET: ArchiveRecord/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArchiveRecord/Delete/model
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

        // GET: ArchiveRecord/Search
        public ActionResult Search()
        {
            return View();
        }

        // POST: ArchiveRecord/Search/model
        [HttpPost]
        public ActionResult Search(ArchiveRecordSearchViewModel model)
        {
            if (Request.IsAjaxRequest())
            {
                return View("Error");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("List", "ArchiveRecord");
            }
            return View("BadSearch");
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

        public PartialViewResult AddPerson(int index)
        {
            return PartialView("_TemplateIsragenPerson", index);
        }

        public PartialViewResult AddUserEvent(int index)
        {
            return PartialView("_TemplateIsragenUserEvent", index);
        }

        public PartialViewResult AddPlace(int index)
        {
            return PartialView("_TemplateIsragenPlace", index);
        }

        public PartialViewResult AddAgency(int index)
        {
            return PartialView("_TemplateIsragenAgency", index);
        }

        public PartialViewResult Test()
        {
            return PartialView("Test");
        }
    }
}
