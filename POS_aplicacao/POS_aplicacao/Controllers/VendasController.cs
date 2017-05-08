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
    public class VendasController : Controller
    {
        private PosAppDB db = new PosAppDB();

        // GET: Vendas
        public ActionResult Index()
        {
            return View(db.Vendas.ToList());
        }

        // GET: Vendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return HttpNotFound();
            }
            return View(vendas);
        }

        // GET: Vendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VendaID,ClienteID,DataVenda,TotalPago,EmpregadoID")] Vendas vendas)
        {
            if (ModelState.IsValid)
            {
                db.Vendas.Add(vendas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vendas);
        }

        // GET: Vendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return HttpNotFound();
            }
            return View(vendas);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VendaID,ClienteID,DataVenda,TotalPago,EmpregadoID")] Vendas vendas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vendas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vendas);
        }

        // GET: Vendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vendas vendas = db.Vendas.Find(id);
            if (vendas == null)
            {
                return HttpNotFound();
            }
            return View(vendas);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vendas vendas = db.Vendas.Find(id);
            db.Vendas.Remove(vendas);
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
