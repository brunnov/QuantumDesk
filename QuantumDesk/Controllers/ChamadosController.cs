using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuantumDesk;
using QuantumDesk.DAL;

namespace QuantumDesk.Controllers
{
    public class ChamadosController : Controller
    {
        private QuantumContext db = new QuantumContext();

        // GET: Chamados
        public ActionResult Index()
        {
            var cHAMADOS = db.CHAMADOS.Include(c => c.CONTRATOS).Include(c => c.STATUS_CHAMADOS);
            return View(cHAMADOS.ToList());
        }

        // GET: Chamados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAMADOS cHAMADOS = db.CHAMADOS.Find(id);
            if (cHAMADOS == null)
            {
                return HttpNotFound();
            }
            return View(cHAMADOS);
        }

        // GET: Chamados/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO");
            ViewBag.CODIGO_STATUS_CHAMADOS = new SelectList(db.STATUS_CHAMADOS, "CODIGO_STATUS_CHAMADOS", "DESCRICAO_STATUS_CHAMADOS");
            return View();
        }

        // POST: Chamados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO_CHAMADO,CODIGO_CONTRATO,DATA_ABERTURA_CHAMADO,DATA_TERMINO_CHAMADO,CODIGO_STATUS_CHAMADOS,DESCRICAO_CHAMADO")] CHAMADOS cHAMADOS)
        {
            if (ModelState.IsValid)
            {
                db.CHAMADOS.Add(cHAMADOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO", cHAMADOS.CODIGO_CONTRATO);
            ViewBag.CODIGO_STATUS_CHAMADOS = new SelectList(db.STATUS_CHAMADOS, "CODIGO_STATUS_CHAMADOS", "DESCRICAO_STATUS_CHAMADOS", cHAMADOS.CODIGO_STATUS_CHAMADOS);
            return View(cHAMADOS);
        }

        // GET: Chamados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAMADOS cHAMADOS = db.CHAMADOS.Find(id);
            if (cHAMADOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO", cHAMADOS.CODIGO_CONTRATO);
            ViewBag.CODIGO_STATUS_CHAMADOS = new SelectList(db.STATUS_CHAMADOS, "CODIGO_STATUS_CHAMADOS", "DESCRICAO_STATUS_CHAMADOS", cHAMADOS.CODIGO_STATUS_CHAMADOS);
            return View(cHAMADOS);
        }

        // POST: Chamados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO_CHAMADO,CODIGO_CONTRATO,DATA_ABERTURA_CHAMADO,DATA_TERMINO_CHAMADO,CODIGO_STATUS_CHAMADOS,DESCRICAO_CHAMADO")] CHAMADOS cHAMADOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHAMADOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO", cHAMADOS.CODIGO_CONTRATO);
            ViewBag.CODIGO_STATUS_CHAMADOS = new SelectList(db.STATUS_CHAMADOS, "CODIGO_STATUS_CHAMADOS", "DESCRICAO_STATUS_CHAMADOS", cHAMADOS.CODIGO_STATUS_CHAMADOS);
            return View(cHAMADOS);
        }

        // GET: Chamados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAMADOS cHAMADOS = db.CHAMADOS.Find(id);
            if (cHAMADOS == null)
            {
                return HttpNotFound();
            }
            return View(cHAMADOS);
        }

        // POST: Chamados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHAMADOS cHAMADOS = db.CHAMADOS.Find(id);
            db.CHAMADOS.Remove(cHAMADOS);
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
