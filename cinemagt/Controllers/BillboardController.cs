using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cinemagt.Models;

namespace cinemagt.Controllers
{
    public class BillboardController : Controller
    {
        private CinemaDbContext _context = new CinemaDbContext();


        // GET: Billboard
        public ActionResult Index(int? id)
        {
            var functions = _context.Functions.ToList().Where(s => s.state != "N");
            if (functions.Count() == 0) ViewBag.Message = "There are no functions";
            ViewBag.Count = functions.Count();

            ViewBag.Functions = functions;

            return View();
        }

        // GET: Billboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Billboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Billboard/Create
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

        // GET: Billboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Billboard/Edit/5
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

        // GET: Billboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Billboard/Delete/5
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
