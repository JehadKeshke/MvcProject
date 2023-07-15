using BusinessLayer.Concrete;
using Entity_Layer.Concrete;
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
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }


        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            p.SenderMail = "omer@gmail.com";
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            mm.AddMessage(p);
            return RedirectToAction("SendBox");
        }
        public ActionResult GetListSendboxByID(int id)
        {
            var valuemessage = mm.GetByID(id);
            return View(valuemessage);
        }
    }
}