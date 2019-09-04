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
        private PROJETOQUANTUMEntities db = new PROJETOQUANTUMEntities();

        // GET: Contratos
        public ActionResult Index()
        {
            var cONTRATOS = db.CONTRATOS.Include(c => c.CLIENTE);
            return View(cONTRATOS.ToList());
        }

        // GET: Contratos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTRATO cONTRATO = db.CONTRATOS.Find(id);
            if (cONTRATO == null)
            {
                return HttpNotFound();
            }
            return View(cONTRATO);
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "CPF_CNPJ");
            return View();
        }

        // POST: Contratos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO_CONTRATO,CODIGO_CLIENTE,INICIO_CONTRATO,FIM_CONTRATO")] CONTRATO cONTRATO)
        {
            if (ModelState.IsValid)
            {
                db.CONTRATOS.Add(cONTRATO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "CPF_CNPJ", cONTRATO.CODIGO_CLIENTE);
            return View(cONTRATO);
        }

        // GET: Contratos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTRATO cONTRATO = db.CONTRATOS.Find(id);
            if (cONTRATO == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "CPF_CNPJ", cONTRATO.CODIGO_CLIENTE);
            return View(cONTRATO);
        }

        // POST: Contratos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO_CONTRATO,CODIGO_CLIENTE,INICIO_CONTRATO,FIM_CONTRATO")] CONTRATO cONTRATO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONTRATO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_CLIENTE = new SelectList(db.CLIENTES, "CODIGO_CLIENTE", "CPF_CNPJ", cONTRATO.CODIGO_CLIENTE);
            return View(cONTRATO);
        }

        // GET: Contratos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTRATO cONTRATO = db.CONTRATOS.Find(id);
            if (cONTRATO == null)
            {
                return HttpNotFound();
            }
            return View(cONTRATO);
        }

        // POST: Contratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CONTRATO cONTRATO = db.CONTRATOS.Find(id);
            db.CONTRATOS.Remove(cONTRATO);
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
