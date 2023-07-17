using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        // GET: WriterPanel
        
        public ActionResult WriterProfile()
        {
            return View();
        }
        [Authorize]
        public ActionResult MyHeading(string p)
        {
            Context c = new Context();
            p = (string)Session["WriterMail"];
            var wirterinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
            var value = hm.GetListByWriter(wirterinfo);
            return View(value);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuectegory = (from x in cm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryID.ToString()
                                                 }
                                                 ).ToList();
            ViewBag.vlc = valuectegory;


            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            Context c = new Context();
            string z = (string)Session["WriterMail"];
            var wirterinfo = c.Writers.Where(x => x.WriterMail == z).Select(y => y.WriterID).FirstOrDefault();
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.HeadingStatus = true;
            p.WriterID = wirterinfo;
            hm.AddHeading(p);
            return RedirectToAction("MyHeading");

        }

        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valuectegory = (from x in cm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryID.ToString()
                                                 }
                                                   ).ToList();
            ViewBag.vlc = valuectegory;
            var HeadingValue = hm.GetByID(id);
            return View(HeadingValue);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.UpdateHeading(p);
            return RedirectToAction("MyHeading");
        }

        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetByID(id);
            hm.RemoveHeading(HeadingValue);
            return RedirectToAction("MyHeading");
        }
    }
}