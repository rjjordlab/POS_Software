using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using POS_aplicacao.Models;

namespace POS_aplicacao.Controllers
{
    public class EmpregadosController : Controller
    {
        private PosAppDB db = new PosAppDB();

        // GET: Empregados
        public ActionResult Index()
        {
            return View(db.Empregados.ToList());
        }

        // GET: Empregados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empregados empregados = db.Empregados.Find(id);
            if (empregados == null)
            {
                return HttpNotFound();
            }
            return View(empregados);
        }

        // GET: Empregados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empregados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpregadoID,Nome,NIF,Telefone,Email,Morada")] Empregados empregados)
        {
            if (ModelState.IsValid)
            {
                db.Empregados.Add(empregados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empregados);
        }

        // GET: Empregados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empregados empregados = db.Empregados.Find(id);
            if (empregados == null)
            {
                return HttpNotFound();
            }
            return View(empregados);
        }

        // POST: Empregados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpregadoID,Nome,NIF,Telefone,Email,Morada")] Empregados empregados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empregados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empregados);
        }

        // GET: Empregados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empregados empregados = db.Empregados.Find(id);
            if (empregados == null)
            {
                return HttpNotFound();
            }
            return View(empregados);
        }

        // POST: Empregados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empregados empregados = db.Empregados.Find(id);
            db.Empregados.Remove(empregados);
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
