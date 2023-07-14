using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using Entity_Layer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{

    public class LoginController : Controller
    {
       
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            LoginValidator logv = new LoginValidator();
            ValidationResult results = logv.Validate(p);

            Context c = new Context();
            var AdminInfo = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            if (AdminInfo!=null)
            {
                FormsAuthentication.SetAuthCookie(AdminInfo.AdminUserName, false);
                return RedirectToAction("GetCategoryList", "AdminCategory");
            }
            else
            {
                ModelState.AddModelError("password", "The username or password is incorrect");
            }
            return View();
        }
    }
}