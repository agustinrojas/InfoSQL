using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientMVC.Controllers
{
    public class UserMVCController : Controller
    {
        // GET: UserMVC
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserMVC/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: UserMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserMVC/Create
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

        // GET: UserMVC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserMVC/Edit/5
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

        // GET: UserMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserMVC/Delete/5
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
