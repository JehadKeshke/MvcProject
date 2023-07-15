using BusinessLayer.Concrete;
using EntityAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelMesageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());

        // GET: WriterPanelMesage
        public ActionResult Inbox()
        {
            
            var ValueMessage = mm.GetListInbox();
            return View(ValueMessage);
        }

        public ActionResult SendBox()
        {

            var ValueMessage = mm.GetListSendbox();
            return View(ValueMessage);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }

        public ActionResult GetListInboxByID(int id)
        {
            var valuemessage = mm.GetByID(id);
            return View(valuemessage);
        }

        public ActionResult GetListSendboxByID(int id)
        {
            var valuemessage = mm.GetByID(id);
            return View(valuemessage);
        }
    }
}