using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        
        // GET: WriterPanelContent
        Context c = new Context();
        public ActionResult GetContentByWriter(string p)
        {
            
            p = (string)Session["WriterMail"];
            var WriterIdInfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
            var contentvalue = cm.GetListByWriter(WriterIdInfo);
            return View(contentvalue);
        }

        
    }
}