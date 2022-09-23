using BusinessLayer.Concrete;
using DataAccsesLayer.Concrete;
using DataAccsesLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());

        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult GetAllContent()
        {
            string p = "";
            var values = cm.GetList(p);
            return View(values.ToList());
        }
        [HttpPost]
        public ActionResult GetAllContent(string p)
        {
            var values = cm.GetList(p);
            return View(values.ToList());
        }
            

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}