using BusinessLayer.Concrete;
using Entity_Layer.Concrete;
using EntityAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());


        public ActionResult Index()
        {
            var WriterValue = wm.GetList();
            return View(WriterValue);
        }
        
     
    }
}