using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
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
        Context c = new Context();
        public int countmessage;
        // GET: WriterPanelMesage
        [Authorize]
        public ActionResult Inbox()
        {
            string p = (string)Session["WriterMail"];
            var inboxinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
            var ValueMessage = mm.GetListInbox(p);
            return View(ValueMessage);
        }
        [Authorize]
        public ActionResult SendBox()
        {
            string p = (string)Session["WriterMail"];
            var inboxinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
            var ValueMessage = mm.GetListSendbox(p);
            return View(ValueMessage);
        }

        public PartialViewResult MessageListMenu()
        {
            string p = (string)Session["WriterMail"];
            countmessage = c.Messages.Where(y => y.ReciverMail == p && y.IsReading == false).Count();
            ViewBag.count = countmessage;
            return PartialView();
        }

        public ActionResult GetListInboxByID(int id)
        {

            var valuemessage = mm.GetByID(id);
            if (valuemessage != null)
            valuemessage.IsReading = true;
            mm.UpdateMessage(valuemessage);
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
            string z = (string)Session["WriterMail"];
            var inboxinfo = c.Writers.Where(x => x.WriterMail == z).Select(y => y.WriterID).FirstOrDefault();
            p.SenderMail = z;
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