﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ImagemNoBanco.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<string> lista = new List<string>();
            //Save on Database
            SqlConnection con = new SqlConnection("Server=ESN509VMSSQL;Database=2019_3it_LuannCampos;User id=Aluno;Password=Senai1234");

            con.Open();
            SqlCommand query =
                new SqlCommand("SELECT * FROM img", con);

            SqlDataReader leitor = query.ExecuteReader();
            while (leitor.Read())
            {
                byte[] b = (byte[])leitor["image"];
                lista.Add(Convert.ToBase64String(b));
            }
            con.Close();
            return View(lista);
        }

        public ActionResult Salvar()
        {
            foreach(string fileName in Request.Files)
            {
                HttpPostedFileBase postedFile = Request.Files[fileName];
                int contentLength = postedFile.ContentLength;
                string contentType = postedFile.ContentType;
                string nome = postedFile.FileName;

                if (contentType.IndexOf("jpeg") > 0)
                {
                    //Convert to bytes
                    int fileLength = postedFile.ContentLength;
                    byte[] imageBytes = new byte[fileLength];
                    postedFile.InputStream.Read(imageBytes, 0, fileLength);

                    //saves on Database
                    SqlConnection
                }
            }
        }
    }
    public static class Conecta : SqlConnection
    {
        public Conecta() :base("Server=ESN509VMSSQL;Database=2019_3it_LuannCampos;User id=Aluno;Password=Senai1234")
        {
           
        }
    }
}