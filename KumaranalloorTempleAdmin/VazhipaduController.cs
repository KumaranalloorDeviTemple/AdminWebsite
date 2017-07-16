using KumaranalloorTempleAdmin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace kumaranalloordevitempleadminweb
{
    [Authorize]
    public class VazhipaduController : Controller
    {
        private kdtadmin3K365DBEntities db = new kdtadmin3K365DBEntities();

        // GET: Vazhipadu
        public ActionResult Index()
        {
            var vazhipadus = db.Vazhipadus.Include(v => v.Diety);
            return View(vazhipadus.ToList());
        }

        // GET: Vazhipadu
        
        public List<Vazhipadu> List(string sDiety)
        {
            var vazhipadus = db.Vazhipadus.Include(v => v.Diety);
            //var vazhipadus = db.Vazhipadus.Where(v => v.Diety.diety_name == sDiety); //.Where(s => s.Diety.diety_name == sDiety);
            return vazhipadus.ToList();
        }

        // GET: Vazhipadu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vazhipadu vazhipadu = db.Vazhipadus.Find(id);
            if (vazhipadu == null)
            {
                return HttpNotFound();
            }
            return View(vazhipadu);
        }

        // GET: Vazhipadu/Create
        public ActionResult Create()
        {
            ViewBag.diety_id = new SelectList(db.Dieties, "diety_id", "diety_name");
            return View();
        }

        // POST: Vazhipadu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vazhipadu_id,diety_id,offering_name,materials_reqd,offering_amount,remarks")] Vazhipadu vazhipadu)
        {
            if (ModelState.IsValid)
            {
                vazhipadu.datetime_updated = DateTime.Now;
                vazhipadu.user_updated = User.Identity.Name;
                db.Vazhipadus.Add(vazhipadu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.diety_id = new SelectList(db.Dieties, "diety_id", "diety_name", vazhipadu.diety_id);
            return View(vazhipadu);
        }

        // GET: Vazhipadu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vazhipadu vazhipadu = db.Vazhipadus.Find(id);
            if (vazhipadu == null)
            {
                return HttpNotFound();
            }
            ViewBag.diety_id = new SelectList(db.Dieties, "diety_id", "diety_name", vazhipadu.diety_id);
            return View(vazhipadu);
        }

        // POST: Vazhipadu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vazhipadu_id,diety_id,offering_name,materials_reqd,offering_amount,remarks")] Vazhipadu vazhipadu)
        {
            if (ModelState.IsValid)
            {
                vazhipadu.datetime_updated = DateTime.Now;
                vazhipadu.user_updated = User.Identity.Name;
                db.Entry(vazhipadu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.diety_id = new SelectList(db.Dieties, "diety_id", "diety_name", vazhipadu.diety_id);
            return View(vazhipadu);
        }

        // GET: Vazhipadu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vazhipadu vazhipadu = db.Vazhipadus.Find(id);
            if (vazhipadu == null)
            {
                return HttpNotFound();
            }
            return View(vazhipadu);
        }

        // POST: Vazhipadu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vazhipadu vazhipadu = db.Vazhipadus.Find(id);
            db.Vazhipadus.Remove(vazhipadu);
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
