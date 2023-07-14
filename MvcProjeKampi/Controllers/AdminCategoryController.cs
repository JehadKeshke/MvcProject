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
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        // GET: AdminCategory
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
        public ActionResult RemoveCategory(int id)
        {
            var CategoryValue = cm.GetByID(id);
            cm.RemoveCategory(CategoryValue);
            return RedirectToAction("GetCategoryList");
            
        }
        [HttpGet]
        public ActionResult UpdateCategory(int ID)
        {
            var categpryValue = cm.GetByID(ID);
            return View(categpryValue);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category p)
        {
            cm.UpdateCategory(p);
            return RedirectToAction("GetCategoryList");
        }

    }
}