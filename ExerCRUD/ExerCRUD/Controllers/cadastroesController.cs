using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExerCRUD.Models;

namespace ExerCRUD.Controllers
{
    public class cadastroesController : Controller
    {
        private Entities2 db = new Entities2();

        // GET: cadastroes
        public ActionResult Index()
        {
            return View(db.cadastro.ToList());
        }

        // GET: cadastroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadastro cadastro = db.cadastro.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }

        // GET: cadastroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cadastroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,foto,endereco,bairro,fone,cidade,cep,estado,nomePai,nomeMae,nacionalidade,naturalidade,dataNascimento,estadoCivil,grauInstrucao,cedulaIdentidade,carteiraProfissional,carteiraReservista,tituloEleitor,carteiraHabilitacao,cpf")] cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                db.cadastro.Add(cadastro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadastro);
        }

        // GET: cadastroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadastro cadastro = db.cadastro.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }

        // POST: cadastroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,foto,endereco,bairro,fone,cidade,cep,estado,nomePai,nomeMae,nacionalidade,naturalidade,dataNascimento,estadoCivil,grauInstrucao,cedulaIdentidade,carteiraProfissional,carteiraReservista,tituloEleitor,carteiraHabilitacao,cpf")] cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastro);
        }

        // GET: cadastroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadastro cadastro = db.cadastro.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }

        // POST: cadastroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cadastro cadastro = db.cadastro.Find(id);
            db.cadastro.Remove(cadastro);
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
