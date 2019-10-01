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
    public class ANALISTASController : Controller
    {
        private QuantumContext db = new QuantumContext();

        // GET: ANALISTAS
        public ActionResult Index()
        {
            var aNALISTAS = db.ANALISTAS.Include(a => a.ESPECIALIDADES).Include(a => a.USUARIOS);
            return View(aNALISTAS.ToList());
        }

        // GET: ANALISTAS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANALISTAS aNALISTAS = db.ANALISTAS.Find(id);
            if (aNALISTAS == null)
            {
                return HttpNotFound();
            }
            return View(aNALISTAS);
        }

        // GET: ANALISTAS/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_ESPECIALIDADE = new SelectList(db.ESPECIALIDADES, "CODIGO_ESPECIALIDADE", "DESCRICAO_ESPECIALIDADE");
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ");
            return View();
        }

        // POST: ANALISTAS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MATRICULA_ANALISTA,ID_USUARIO,GERENTE,CARGA_HORARIA,CODIGO_ESPECIALIDADE")] ANALISTAS aNALISTAS)
        {
            if (ModelState.IsValid)
            {
                db.ANALISTAS.Add(aNALISTAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_ESPECIALIDADE = new SelectList(db.ESPECIALIDADES, "CODIGO_ESPECIALIDADE", "DESCRICAO_ESPECIALIDADE", aNALISTAS.CODIGO_ESPECIALIDADE);
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ", aNALISTAS.ID_USUARIO);
            return View(aNALISTAS);
        }

        // GET: ANALISTAS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANALISTAS aNALISTAS = db.ANALISTAS.Find(id);
            if (aNALISTAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_ESPECIALIDADE = new SelectList(db.ESPECIALIDADES, "CODIGO_ESPECIALIDADE", "DESCRICAO_ESPECIALIDADE", aNALISTAS.CODIGO_ESPECIALIDADE);
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ", aNALISTAS.ID_USUARIO);
            return View(aNALISTAS);
        }

        // POST: ANALISTAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MATRICULA_ANALISTA,ID_USUARIO,GERENTE,CARGA_HORARIA,CODIGO_ESPECIALIDADE")] ANALISTAS aNALISTAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aNALISTAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_ESPECIALIDADE = new SelectList(db.ESPECIALIDADES, "CODIGO_ESPECIALIDADE", "DESCRICAO_ESPECIALIDADE", aNALISTAS.CODIGO_ESPECIALIDADE);
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ", aNALISTAS.ID_USUARIO);
            return View(aNALISTAS);
        }

        // GET: ANALISTAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ANALISTAS aNALISTAS = db.ANALISTAS.Find(id);
            if (aNALISTAS == null)
            {
                return HttpNotFound();
            }
            return View(aNALISTAS);
        }

        // POST: ANALISTAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ANALISTAS aNALISTAS = db.ANALISTAS.Find(id);
            db.ANALISTAS.Remove(aNALISTAS);
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
