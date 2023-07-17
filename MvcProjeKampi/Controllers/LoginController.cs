using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using Entity_Layer.Concrete;
using FluentValidation;
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
                Session["AdminUserName"] = AdminInfo.AdminUserName;
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                ModelState.AddModelError("password", "The username or password is incorrect");
            }
            return View();
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            WriterLogin logwr = new WriterLogin();
            ValidationResult results = logwr.Validate(p);

            Context c = new Context();
            var WriterInfo = c.Writers.FirstOrDefault(x =>x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (WriterInfo != null)
            {
                FormsAuthentication.SetAuthCookie(WriterInfo.WriterMail, false);
                Session["WriterMail"] = WriterInfo.WriterMail;
                return RedirectToAction("GetContentByWriter", "WriterPanelContent");
            }
            else
            {
                ModelState.AddModelError("password", "The username or password is incorrect");
            }
            return View();
        }
    }
}