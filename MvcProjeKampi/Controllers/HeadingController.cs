using BusinessLayer.Concrete;
using Entity_Layer.Concrete;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
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
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());

        // GET: Heading
        public ActionResult Index()
        {
            var headingvlue = hm.GetList();
            return View(headingvlue);
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
            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName,
                                                    Value = x.WriterID.ToString()
                                                }
                                                ).ToList();
            ViewBag.vlw = valueWriter;

            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.AddHeading(p);
            return RedirectToAction("Index");

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
            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text =x.WriterName,
                                                     Value = x.WriterID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.vlw = valueWriter;
            var HeadingValue = hm.GetByID(id);
            return View(HeadingValue);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.UpdateHeading(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetByID(id);
            hm.RemoveHeading(HeadingValue);
            return RedirectToAction("Index");
        }
    }
}