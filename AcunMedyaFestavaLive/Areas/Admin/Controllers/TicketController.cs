using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaFestavaLive.Areas.Admin.Controllers
{
    
    public class TicketController : Controller
    {
        // GET: Admin/Ticket

        Context context  = new Context();
        public ActionResult TicketList()
        {
            var values = context.Tickets.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTicket()
		{
            return View();
		}

        [HttpPost]
        public ActionResult CreateTicket(Ticket ticket)
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return RedirectToAction("TicketList");
        }

        public ActionResult DeleteTicket(int id)
		{
            var value = context.Tickets.Find(id);
            context.Tickets.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TicketList");
		}

        [HttpGet]
        public ActionResult UpdateTicket(int id)
		{
            var value = context.Tickets.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTicket(Ticket ticket)
		{
            var value = context.Tickets.Find(ticket.TicketId);
            value.TicketProperty1 = ticket.TicketProperty1;
            value.TicketProperty2 = ticket.TicketProperty2;
            value.TicketProperty3 = ticket.TicketProperty3;
            value.TicketProperty4 = ticket.TicketProperty4;
            value.TicketProperty5 = ticket.TicketProperty5;
            value.TicketProperty6 = ticket.TicketProperty6;
            value.Price = ticket.Price;
            value.Description = ticket.Description;
            value.Title = ticket.Title;
            context.SaveChanges();
            return RedirectToAction("TicketList");

        }
    }
}