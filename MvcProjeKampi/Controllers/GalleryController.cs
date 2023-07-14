using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        GalleryManager gm = new GalleryManager(new EfGalleryDal());

        // GET: Gallery
     
        public ActionResult Index()
        {
            var GalleryValues = gm.GetList();
            return View(GalleryValues);
        }
    }
}