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
    public class ClientesController : Controller
    {
        private QuantumContext db = new QuantumContext();

        // GET: Clientes
        public ActionResult Index()
        {
            var cLIENTES = db.CLIENTES.Include(c => c.FORMA_PAGAMENTO).Include(c => c.USUARIOS);
            return View(cLIENTES.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTES cLIENTES = db.CLIENTES.Find(id);
            if (cLIENTES == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTES);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_FORMA_PAGAMENTO = new SelectList(db.FORMA_PAGAMENTO, "CODIGO_FORMA_PAGAMENTO", "DESCRICAO_FORMA_PAGAMENTO");
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO_CLIENTE,ID_USUARIO,RESPONSAVEL,CODIGO_FORMA_PAGAMENTO,DIA_PAGAMENTO")] CLIENTES cLIENTES)
        {
            if (ModelState.IsValid)
            {
                db.CLIENTES.Add(cLIENTES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_FORMA_PAGAMENTO = new SelectList(db.FORMA_PAGAMENTO, "CODIGO_FORMA_PAGAMENTO", "DESCRICAO_FORMA_PAGAMENTO", cLIENTES.CODIGO_FORMA_PAGAMENTO);
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ", cLIENTES.ID_USUARIO);
            return View(cLIENTES);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTES cLIENTES = db.CLIENTES.Find(id);
            if (cLIENTES == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_FORMA_PAGAMENTO = new SelectList(db.FORMA_PAGAMENTO, "CODIGO_FORMA_PAGAMENTO", "DESCRICAO_FORMA_PAGAMENTO", cLIENTES.CODIGO_FORMA_PAGAMENTO);
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ", cLIENTES.ID_USUARIO);
            return View(cLIENTES);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO_CLIENTE,ID_USUARIO,RESPONSAVEL,CODIGO_FORMA_PAGAMENTO,DIA_PAGAMENTO")] CLIENTES cLIENTES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cLIENTES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_FORMA_PAGAMENTO = new SelectList(db.FORMA_PAGAMENTO, "CODIGO_FORMA_PAGAMENTO", "DESCRICAO_FORMA_PAGAMENTO", cLIENTES.CODIGO_FORMA_PAGAMENTO);
            ViewBag.ID_USUARIO = new SelectList(db.USUARIOS, "ID_USUARIO", "CPF_CNPJ", cLIENTES.ID_USUARIO);
            return View(cLIENTES);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENTES cLIENTES = db.CLIENTES.Find(id);
            if (cLIENTES == null)
            {
                return HttpNotFound();
            }
            return View(cLIENTES);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CLIENTES cLIENTES = db.CLIENTES.Find(id);
            db.CLIENTES.Remove(cLIENTES);
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
