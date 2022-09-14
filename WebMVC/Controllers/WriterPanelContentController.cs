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
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult MyContent(string p)
        {
            Context c = new Context();
            p = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
            var contentvalues = cm.GetListByWriter(writeridinfo);
            return View(contentvalues); 
        }

    }
}