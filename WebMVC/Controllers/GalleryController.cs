using BusinessLayer.Concrete;
using DataAccsesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager ıfm = new ImageFileManager(new EfImageFileDal());


        public ActionResult Index()
        {
            var files = ıfm.GetList();
            return View(files);
        }
    }
}