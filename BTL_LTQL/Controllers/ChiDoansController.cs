using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL_LTQL.Models;
using BTL_LTQL.Models.Process;

namespace BTL_LTQL.Controllers
{
    public class ChiDoansController : Controller
    {
        private QLDVDbContext db = new QLDVDbContext();
        private StringProcess strPro = new StringProcess();
        // GET: ChiDoans
        public ActionResult Index()
        {
            return View(db.ChiDoans.ToList());
        }

        // GET: ChiDoans/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiDoan chiDoan = db.ChiDoans.Find(id);
            if (chiDoan == null)
            {
                return HttpNotFound();
            }
            return View(chiDoan);
        }

        // GET: ChiDoans/Create
        public ActionResult Create()
        {
            string chidoanKey = "";
            var model = db.ChiDoans.ToList();
            if (model.Count == 0)
            {
                chidoanKey = "CD1";
            }
            else
            {
                var IDChiDoan = model.OrderByDescending(m => m.IDChiDoan).FirstOrDefault().IDChiDoan;
                chidoanKey = strPro.AutoGenerateKey(IDChiDoan);
            }
            //truyen ma sinh tu dong ve view create
            ViewBag.IDChiDoan = chidoanKey;
            return View();
        }

        // POST: ChiDoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDChiDoan,TenChiDoan")] ChiDoan chiDoan)
        {
            if (ModelState.IsValid)
            {
                db.ChiDoans.Add(chiDoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chiDoan);
        }

        // GET: ChiDoans/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiDoan chiDoan = db.ChiDoans.Find(id);
            if (chiDoan == null)
            {
                return HttpNotFound();
            }
            return View(chiDoan);
        }

        // POST: ChiDoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDChiDoan,TenChiDoan")] ChiDoan chiDoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiDoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chiDoan);
        }

        // GET: ChiDoans/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiDoan chiDoan = db.ChiDoans.Find(id);
            if (chiDoan == null)
            {
                return HttpNotFound();
            }
            return View(chiDoan);
        }

        // POST: ChiDoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChiDoan chiDoan = db.ChiDoans.Find(id);
            db.ChiDoans.Remove(chiDoan);
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
