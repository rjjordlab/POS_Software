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
    public class VendasDetalhesController : Controller
    {
        private PosAppDB db = new PosAppDB();

        // GET: VendasDetalhes
        public ActionResult Index()
        {
            return View(db.VendasDetalhes.ToList());
        }

        // GET: VendasDetalhes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VendasDetalhes vendasDetalhes = db.VendasDetalhes.Find(id);
            if (vendasDetalhes == null)
            {
                return HttpNotFound();
            }
            return View(vendasDetalhes);
        }

        // GET: VendasDetalhes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VendasDetalhes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetalheID,VendaID,ProdutoID,Quantidade,Preco,TotalAPagar")] VendasDetalhes vendasDetalhes)
        {
            if (ModelState.IsValid)
            {
                db.VendasDetalhes.Add(vendasDetalhes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vendasDetalhes);
        }

        // GET: VendasDetalhes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VendasDetalhes vendasDetalhes = db.VendasDetalhes.Find(id);
            if (vendasDetalhes == null)
            {
                return HttpNotFound();
            }
            return View(vendasDetalhes);
        }

        // POST: VendasDetalhes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetalheID,VendaID,ProdutoID,Quantidade,Preco,TotalAPagar")] VendasDetalhes vendasDetalhes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vendasDetalhes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vendasDetalhes);
        }

        // GET: VendasDetalhes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VendasDetalhes vendasDetalhes = db.VendasDetalhes.Find(id);
            if (vendasDetalhes == null)
            {
                return HttpNotFound();
            }
            return View(vendasDetalhes);
        }

        // POST: VendasDetalhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VendasDetalhes vendasDetalhes = db.VendasDetalhes.Find(id);
            db.VendasDetalhes.Remove(vendasDetalhes);
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
