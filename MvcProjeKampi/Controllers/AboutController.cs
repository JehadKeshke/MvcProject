using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutDal());

        // GET: About
        public ActionResult Index()
        {
            var AboutValue = am.GetList();
            return View(AboutValue);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            am.AddAbout(p);
            return RedirectToAction("Index");
        }

       
    }
}