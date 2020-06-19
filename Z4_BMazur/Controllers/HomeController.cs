using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Z4_BMazur;
using Z4_BMazur.Models;

namespace Z4_BMazur.Controllers
{
    public class HomeController : Controller
    {
        private Database1Entities _db = new Database1Entities();

        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Table.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id, Table table)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Table collection)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                _db.Table.Add(collection);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_db.Table.Find(id));
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Table table)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();
                var Jumper = _db.Table.Find(id);
                Jumper.Name = table.Name;
                Jumper.Surname = table.Surname;
                Jumper.Age = table.Age;
                Jumper.Jump1 = table.Jump1;
                Jumper.Note = table.Note;
                Jumper.K_Point = table.K_Point;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_db.Table.Find(id));
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Table table)
        {
            try
            {
                _db.Table.Remove(_db.Table.Find(id));
                _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
