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
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator2 writervalidator = new WriterValidator2();


        [AllowAnonymous]
        [HttpGet]
        public ActionResult KayıtOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayıtOl(Writer p)
        {
            //ValidationResult result = writervalidator.Validate(p);
            //if (result.IsValid)
            //{
                wm.WriterAdd(p);
                return RedirectToAction("WriterLogin","Login");
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            //return View();
        }
    }
}