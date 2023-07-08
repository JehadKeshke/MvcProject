using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal()); 
        // GET: Concat
        public ActionResult Index()
        {
            var ContactValue = cm.GetList();
            return View(ContactValue);
        }
        
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        public ActionResult ContactDetailes(int id )
        {
            var ContactValues = cm.GetByID(id);
            return View(ContactValues);
        }
    }
}