using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using cinemagt.Models;

namespace cinemagt.Controllers
{
    public class FunctionsController : Controller
    {
        private readonly CinemaDbContext _context = new CinemaDbContext(); 

        // GET: Functions
        public ActionResult Index(int? id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult ComingSoon(int? id)
        {
            ViewBag.Id = id;
            return View();
        }

        // GET: Functions/Details/5
        [Route("Functions/{id}")]
        public ActionResult Details(int id)
        {
            ViewBag.Id = id;

            var function = this._context.Functions.Where(f => f.idFunction == id).FirstOrDefault();

            if(function == null)
            {
                
                return View("Error");
            }

            ViewBag.Function = function;


            return View();
        }

        // GET: Functions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Functions/Create
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

        // GET: Functions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Functions/Edit/5
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

        // GET: Functions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Functions/Delete/5
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
