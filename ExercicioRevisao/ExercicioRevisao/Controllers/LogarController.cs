using ExercicioRevisao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExercicioRevisao.Controllers
{
    public class LogarController : Controller
    {
        private dbContexto db = new dbContexto();


        public ActionResult Logar([Bind(Include = "nickname,senha")] Usuario usuario)
        {
            if (usuario.nickname == null)
                return View();

            if (ModelState.IsValid)
            {
                var v = db.Usuarios.Where(a => a.nickname.Equals(usuario.nickname) && a.senha.Equals(usuario.senha));

                foreach (var item in v)
                {
                    Session["UserName"] = item.nome;
                }
            }

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Sair()
        {
            Session["Username"] = null;

            return RedirectToAction("Index", "Home");

        }


        public ActionResult Cadastrar([Bind(Include = "nickname,senha,nome")] Usuario usuario)
        {
            if (usuario.nickname == null)
                return View();

            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                Session["UserName"] = usuario.nome;
            }

            return RedirectToAction("Index", "Home");
        }
    }
}