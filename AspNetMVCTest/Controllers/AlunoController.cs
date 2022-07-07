﻿using AspNetMVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCTest.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        [Route("novo-aluno")]
        // route
        public ActionResult NovoAluno()
        {
            return View();
        }

        [HttpPost]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            // alguma regra de negocio + Salvar no banco

            return View(aluno);

        }
    }
}
