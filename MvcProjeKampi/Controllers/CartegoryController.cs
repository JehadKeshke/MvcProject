using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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
    public class CartegoryController : Controller
    {
        // GET: Test
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

  
        public ActionResult GetCategoryList()
        {
            var CategeoryValue = cm.GetList();
            return View(CategeoryValue);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidatior cv = new CategoryValidatior();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                cm.AddCategory(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


    }
}