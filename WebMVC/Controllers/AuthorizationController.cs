using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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
    public class AuthorizationController : Controller
    {
        AdminManager am = new AdminManager(new EfAdminDal());
        AdminValidator adminvalidator = new AdminValidator();


        public ActionResult Index()
        {
            var adminvalues = am.GetList();
            return View(adminvalues);
        }




        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {

            ValidationResult result = adminvalidator.Validate(p);
            if (result.IsValid)
            {
                am.AdminAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }




        public ActionResult EditAdmin(int id)
        {
            var adminvalues = am.GetById(id);
            if (adminvalues.AdminRole =="A")
                adminvalues.AdminRole = "B";
            else
                adminvalues.AdminRole = "A";
            am.YetkiAdmin(adminvalues);
            return RedirectToAction("Index");
        }





        public ActionResult DeleteAdmin(int id)
        {
            var adminvalues = am.GetById(id);
            adminvalues.AdminStatü= false;
            am.AdminDelete(adminvalues);
            return RedirectToAction("Index");
        }





        public ActionResult AktifAdmin(int id)
        {
            var adminvalues = am.GetById(id);
            adminvalues.AdminStatü = true;
            am.AktifAdmin(adminvalues);
            return RedirectToAction("Index");
        }
    }
}