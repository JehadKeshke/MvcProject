using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class DefaultController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        // GET: Default
        public ActionResult GetListHeading()
        {
            var value = hm.GetList();
            return View(value);
        }

        public PartialViewResult GetAllContent(int id = 0)
        {
            var getlistcontent = cm.GetListByHeading(id);
            return PartialView(getlistcontent);
        }
    }
}