using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace QuantumDesk
{
    public class OSController : Controller
    {
        private QuantumContext db = new QuantumContext();

        // GET: OS
        public ActionResult Index()
        {
            var oS = db.OS.Include(o => o.ANALISTAS).Include(o => o.CHAMADOS).Include(o => o.PRIORIDADES).Include(o => o.SERVICOS).Include(o => o.STATUS_OS);
            return View(oS.ToList());
        }

        // GET: OS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS oS = db.OS.Find(id);
            if (oS == null)
            {
                return HttpNotFound();
            }
            return View(oS);
        }

        // GET: OS/Create
        public ActionResult Create()
        {
            ViewBag.MATRICULA_ANALISTA = new SelectList(db.ANALISTAS, "MATRICULA_ANALISTA", "MATRICULA_ANALISTA");
            ViewBag.CODIGO_CHAMADO = new SelectList(db.CHAMADOS, "CODIGO_CHAMADO", "DESCRICAO_CHAMADO");
            ViewBag.CODIGO_PRIORIDADE = new SelectList(db.PRIORIDADES, "CODIGO_PRIORIDADE", "DESCRICAO_PRIORIDADE");
            ViewBag.CODIGO_SERVICO = new SelectList(db.SERVICOS, "CODIGO_SERVICO", "DESCRICAO_SERVICO");
            ViewBag.CODIGO_STATUS_OS = new SelectList(db.STATUS_OS, "CODIGO_STATUS_OS", "DESCRICAO_STATUS_OS");
            return View();
        }

        // POST: OS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO_OS,CODIGO_CHAMADO,DATA_ABERTURA_OS,DATA_TERMINO_OS,CODIGO_STATUS_OS,MATRICULA_ANALISTA,CODIGO_PRIORIDADE,CODIGO_SERVICO,DESCRICAO_OS")] OS oS)
        {
            if (ModelState.IsValid)
            {
                db.OS.Add(oS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MATRICULA_ANALISTA = new SelectList(db.ANALISTAS, "MATRICULA_ANALISTA", "MATRICULA_ANALISTA", oS.MATRICULA_ANALISTA);
            ViewBag.CODIGO_CHAMADO = new SelectList(db.CHAMADOS, "CODIGO_CHAMADO", "DESCRICAO_CHAMADO", oS.CODIGO_CHAMADO);
            ViewBag.CODIGO_PRIORIDADE = new SelectList(db.PRIORIDADES, "CODIGO_PRIORIDADE", "DESCRICAO_PRIORIDADE", oS.CODIGO_PRIORIDADE);
            ViewBag.CODIGO_SERVICO = new SelectList(db.SERVICOS, "CODIGO_SERVICO", "DESCRICAO_SERVICO", oS.CODIGO_SERVICO);
            ViewBag.CODIGO_STATUS_OS = new SelectList(db.STATUS_OS, "CODIGO_STATUS_OS", "DESCRICAO_STATUS_OS", oS.CODIGO_STATUS_OS);
            return View(oS);
        }

        // GET: OS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS oS = db.OS.Find(id);
            if (oS == null)
            {
                return HttpNotFound();
            }
            ViewBag.MATRICULA_ANALISTA = new SelectList(db.ANALISTAS, "MATRICULA_ANALISTA", "MATRICULA_ANALISTA", oS.MATRICULA_ANALISTA);
            ViewBag.CODIGO_CHAMADO = new SelectList(db.CHAMADOS, "CODIGO_CHAMADO", "DESCRICAO_CHAMADO", oS.CODIGO_CHAMADO);
            ViewBag.CODIGO_PRIORIDADE = new SelectList(db.PRIORIDADES, "CODIGO_PRIORIDADE", "DESCRICAO_PRIORIDADE", oS.CODIGO_PRIORIDADE);
            ViewBag.CODIGO_SERVICO = new SelectList(db.SERVICOS, "CODIGO_SERVICO", "DESCRICAO_SERVICO", oS.CODIGO_SERVICO);
            ViewBag.CODIGO_STATUS_OS = new SelectList(db.STATUS_OS, "CODIGO_STATUS_OS", "DESCRICAO_STATUS_OS", oS.CODIGO_STATUS_OS);
            return View(oS);
        }

        // POST: OS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO_OS,CODIGO_CHAMADO,DATA_ABERTURA_OS,DATA_TERMINO_OS,CODIGO_STATUS_OS,MATRICULA_ANALISTA,CODIGO_PRIORIDADE,CODIGO_SERVICO,DESCRICAO_OS")] OS oS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MATRICULA_ANALISTA = new SelectList(db.ANALISTAS, "MATRICULA_ANALISTA", "MATRICULA_ANALISTA", oS.MATRICULA_ANALISTA);
            ViewBag.CODIGO_CHAMADO = new SelectList(db.CHAMADOS, "CODIGO_CHAMADO", "DESCRICAO_CHAMADO", oS.CODIGO_CHAMADO);
            ViewBag.CODIGO_PRIORIDADE = new SelectList(db.PRIORIDADES, "CODIGO_PRIORIDADE", "DESCRICAO_PRIORIDADE", oS.CODIGO_PRIORIDADE);
            ViewBag.CODIGO_SERVICO = new SelectList(db.SERVICOS, "CODIGO_SERVICO", "DESCRICAO_SERVICO", oS.CODIGO_SERVICO);
            ViewBag.CODIGO_STATUS_OS = new SelectList(db.STATUS_OS, "CODIGO_STATUS_OS", "DESCRICAO_STATUS_OS", oS.CODIGO_STATUS_OS);
            return View(oS);
        }

        // GET: OS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OS oS = db.OS.Find(id);
            if (oS == null)
            {
                return HttpNotFound();
            }
            return View(oS);
        }

        // POST: OS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OS oS = db.OS.Find(id);
            db.OS.Remove(oS);
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
