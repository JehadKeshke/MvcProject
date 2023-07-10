using BusinessLayer.Concrete;
using EntityAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class SkillsController : Controller
    {
        SkillsManager sm = new SkillsManager(new EfSkillDal());
        // GET: Skills
        public ActionResult Index()
        {
            var SkillsValue = sm.GetList();
            return View(SkillsValue);
        }
    }
}