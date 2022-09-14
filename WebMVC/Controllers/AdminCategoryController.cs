using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccsesLayer.Concrete.Repositories;
using DataAccsesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View("~/Views/AdminCategory/Index.cshtml", categoryvalues);
        }


        #region ActionResult to !!!  Add  !!! Category

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
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

        #endregion

        #region ActionResult to !!!  Delete  !!! Category

        public ActionResult DeleteCategory(int id)
        {
            var catergoryvalue = cm.GetById(id);
            cm.CategoryDelete(catergoryvalue);
            return RedirectToAction("Index");
        }

        #endregion

        #region ActionResult to !!!  EDIT  !!! Category

        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryvalue = cm.GetById(id);
            return View(categoryvalue);
        }
        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }

        #endregion
    }
}