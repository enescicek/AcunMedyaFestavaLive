using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Member.Controllers
{
    public class MyTicketController : Controller
    {
        // GET: Member/MyTicket
        public ActionResult MyTicketList()
        {
            return View();
        }

        public ActionResult CreateGuid()
		{
            string newGuid = Guid.NewGuid().ToString();
            ViewBag.Guid = newGuid;
            return View();
		}
    }
}