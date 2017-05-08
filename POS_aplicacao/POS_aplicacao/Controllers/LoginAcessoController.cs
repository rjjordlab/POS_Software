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
    public class LoginAcessoController : Controller
    {
        private PosAppDB db = new PosAppDB();

        // GET: LoginAcesso
        public ActionResult Index()
        {
            return View(db.LoginAcesso.ToList());
        }

        // GET: LoginAcesso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginAcesso loginAcesso = db.LoginAcesso.Find(id);
            if (loginAcesso == null)
            {
                return HttpNotFound();
            }
            return View(loginAcesso);
        }

        // GET: LoginAcesso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginAcesso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AcessoID,EmpregadoID,Senha")] LoginAcesso loginAcesso)
        {
            if (ModelState.IsValid)
            {
                db.LoginAcesso.Add(loginAcesso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loginAcesso);
        }

        // GET: LoginAcesso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginAcesso loginAcesso = db.LoginAcesso.Find(id);
            if (loginAcesso == null)
            {
                return HttpNotFound();
            }
            return View(loginAcesso);
        }

        // POST: LoginAcesso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AcessoID,EmpregadoID,Senha")] LoginAcesso loginAcesso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loginAcesso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loginAcesso);
        }

        // GET: LoginAcesso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginAcesso loginAcesso = db.LoginAcesso.Find(id);
            if (loginAcesso == null)
            {
                return HttpNotFound();
            }
            return View(loginAcesso);
        }

        // POST: LoginAcesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoginAcesso loginAcesso = db.LoginAcesso.Find(id);
            db.LoginAcesso.Remove(loginAcesso);
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
