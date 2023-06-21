using BusinessLayer.Concrete;
using EntityAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());  

        // GET: Heading
        public ActionResult Index()
        {
            var headingvlue = hm.GetList();
            return View(headingvlue);
        }
    }
}