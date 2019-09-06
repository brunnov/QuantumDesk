using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuantumDesk;

namespace QuantumDesk.Controllers
{
    public class ContratosController : Controller
    {
        private QuantumContext db = new QuantumContext();

        // GET: Contratos
        public ActionResult Index()
        {
            var cONTRATOS = db.CONTRATOS.Include(c => c.CLIENTES);
            return View(cONTRATOS.ToList());
        }

        // GET: Contratos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTRATOS cONTRATOS = db.CONTRATOS.Find(id);
            if (cONTRATOS == null)
            {
                return HttpNotFound();
            }
            return View(cONTRATOS);
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "RESPONSAVEL");
            return View();
        }

        // POST: Contratos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO_CONTRATO,CODIGO_CLIENTE,INICIO_CONTRATO,FIM_CONTRATO")] CONTRATOS cONTRATOS)
        {
            if (ModelState.IsValid)
            {
                db.CONTRATOS.Add(cONTRATOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "RESPONSAVEL", cONTRATOS.CODIGO_CLIENTE);
            return View(cONTRATOS);
        }

        // GET: Contratos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTRATOS cONTRATOS = db.CONTRATOS.Find(id);
            if (cONTRATOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "RESPONSAVEL", cONTRATOS.CODIGO_CLIENTE);
            return View(cONTRATOS);
        }

        // POST: Contratos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO_CONTRATO,CODIGO_CLIENTE,INICIO_CONTRATO,FIM_CONTRATO")] CONTRATOS cONTRATOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONTRATOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "RESPONSAVEL", cONTRATOS.CODIGO_CLIENTE);
            return View(cONTRATOS);
        }

        // GET: Contratos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTRATOS cONTRATOS = db.CONTRATOS.Find(id);
            if (cONTRATOS == null)
            {
                return HttpNotFound();
            }
            return View(cONTRATOS);
        }

        // POST: Contratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CONTRATOS cONTRATOS = db.CONTRATOS.Find(id);
            db.CONTRATOS.Remove(cONTRATOS);
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
