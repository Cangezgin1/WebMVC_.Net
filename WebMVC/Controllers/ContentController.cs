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

        public ActionResult GetAllContent(string p)
        {
            p = "Çok";
            var values = from x in c.Contents select x;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(y => y.ConcentValue.Contains(p));
            }
            //var values = c.Contents.ToList();
            return View(values.ToString());
        }
            

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }


    }
}