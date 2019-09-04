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
    public class ChamadosController : Controller
    {
        private PROJETOQUANTUMEntities db = new PROJETOQUANTUMEntities();

        // GET: Chamados
        public ActionResult Index()
        {
            var cHAMADOS = db.CHAMADOS.Include(c => c.CONTRATO);
            return View(cHAMADOS.ToList());
        }

        // GET: Chamados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAMADO cHAMADO = db.CHAMADOS.Find(id);
            if (cHAMADO == null)
            {
                return HttpNotFound();
            }
            return View(cHAMADO);
        }

        // GET: Chamados/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO");
            return View();
        }

        // POST: Chamados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO_CHAMADO,CODIGO_CONTRATO,DATA_ABERTURA_CHAMADO,DATA_TERMINO_CHAMADO,STATUS_CHAMADO,DESCRICAO_CHAMADO")] CHAMADO cHAMADO)
        {
            if (ModelState.IsValid)
            {
                db.CHAMADOS.Add(cHAMADO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO", cHAMADO.CODIGO_CONTRATO);
            return View(cHAMADO);
        }

        // GET: Chamados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAMADO cHAMADO = db.CHAMADOS.Find(id);
            if (cHAMADO == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO", cHAMADO.CODIGO_CONTRATO);
            return View(cHAMADO);
        }

        // POST: Chamados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO_CHAMADO,CODIGO_CONTRATO,DATA_ABERTURA_CHAMADO,DATA_TERMINO_CHAMADO,STATUS_CHAMADO,DESCRICAO_CHAMADO")] CHAMADO cHAMADO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHAMADO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_CONTRATO = new SelectList(db.CONTRATOS, "CODIGO_CONTRATO", "CODIGO_CONTRATO", cHAMADO.CODIGO_CONTRATO);
            return View(cHAMADO);
        }

        // GET: Chamados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHAMADO cHAMADO = db.CHAMADOS.Find(id);
            if (cHAMADO == null)
            {
                return HttpNotFound();
            }
            return View(cHAMADO);
        }

        // POST: Chamados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHAMADO cHAMADO = db.CHAMADOS.Find(id);
            db.CHAMADOS.Remove(cHAMADO);
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
