using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCTest.Controllers
{
    [RoutePrefix("teste")]
    public class TesteController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [Route("sobre-nos")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("institucional/entre-em-contato")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ContentResult ContentResult()
        {
            return Content("Olá!");
        }

        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.png"));
            return File(foto, "image/png", "capa.png");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        public JsonResult JsonResult()
        {
            return Json("teste:'Teste'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            // returns instance: new RedirectResult
            return new RedirectResult("https://brunocamps.com");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            // returning this way you don't need to hardcode an internal route

            /*
            return RedirectToRoute(new
            {
                controller = "Home",
                action = "Index"
            }); */

            return RedirectToAction("Index");
        }


    }
}