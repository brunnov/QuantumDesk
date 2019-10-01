using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuantumDesk;

namespace QuantumDesk.Views
{
    public class AGENDAMENTOSController : Controller
    {
        private QuantumContext db = new QuantumContext();

        // GET: AGENDAMENTOS
        public ActionResult Index()
        {
            var aGENDAMENTOS = db.AGENDAMENTOS.Include(a => a.OS);
            return View(aGENDAMENTOS.ToList());
        }

        // GET: AGENDAMENTOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AGENDAMENTOS aGENDAMENTOS = db.AGENDAMENTOS.Find(id);
            if (aGENDAMENTOS == null)
            {
                return HttpNotFound();
            }
            return View(aGENDAMENTOS);
        }

        // GET: AGENDAMENTOS/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_OS = new SelectList(db.OS, "CODIGO_OS", "DESCRICAO_OS");
            return View();
        }

        // POST: AGENDAMENTOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO_AGENDAMENTO,CODIGO_OS,DATA_AGENDAMENTO,DESCRICAO_AGENDAMENTO")] AGENDAMENTOS aGENDAMENTOS)
        {
            if (ModelState.IsValid)
            {
                db.AGENDAMENTOS.Add(aGENDAMENTOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_OS = new SelectList(db.OS, "CODIGO_OS", "DESCRICAO_OS", aGENDAMENTOS.CODIGO_OS);
            return View(aGENDAMENTOS);
        }

        // GET: AGENDAMENTOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AGENDAMENTOS aGENDAMENTOS = db.AGENDAMENTOS.Find(id);
            if (aGENDAMENTOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_OS = new SelectList(db.OS, "CODIGO_OS", "DESCRICAO_OS", aGENDAMENTOS.CODIGO_OS);
            return View(aGENDAMENTOS);
        }

        // POST: AGENDAMENTOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO_AGENDAMENTO,CODIGO_OS,DATA_AGENDAMENTO,DESCRICAO_AGENDAMENTO")] AGENDAMENTOS aGENDAMENTOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aGENDAMENTOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_OS = new SelectList(db.OS, "CODIGO_OS", "DESCRICAO_OS", aGENDAMENTOS.CODIGO_OS);
            return View(aGENDAMENTOS);
        }

        // GET: AGENDAMENTOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AGENDAMENTOS aGENDAMENTOS = db.AGENDAMENTOS.Find(id);
            if (aGENDAMENTOS == null)
            {
                return HttpNotFound();
            }
            return View(aGENDAMENTOS);
        }

        // POST: AGENDAMENTOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AGENDAMENTOS aGENDAMENTOS = db.AGENDAMENTOS.Find(id);
            db.AGENDAMENTOS.Remove(aGENDAMENTOS);
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
