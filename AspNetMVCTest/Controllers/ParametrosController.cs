﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCTest.Controllers
{
    public class ParametrosController : Controller
    {
        // GET: Parametros
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}