using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Models;
//using System.Collections.Generic;


namespace Business.Controllers
{
    public class HelpController : Controller
    {
        private readonly HrDbContext _context;

        public HelpController(HrDbContext context)
        {
            _context = context;

        }

        public IActionResult Index() //Index is for My tickets
        {
            ViewBag.UserIsAdmin = Business.Controllers.HomeController.loggedemp.isAdmin;
            //Console.WriteLine("Viewbag admin= "+ ViewBag.UserIsAdmin);
            //ViewBag.UserIsAdmin = true;
            return View();
        }

        public IActionResult TicketDb(string searchTerm) //ticket creator
        {
            Console.WriteLine(_context.Tickets.FirstOrDefault(t => t.Id == 1));
            var ticketQuery = _context.Tickets.AsQueryable();
            //foreach (var ticket in ticketQuery)
            //{
            //    Console.WriteLine("Ticket: " + ticket);
            //}
            if (!string.IsNullOrEmpty(searchTerm))
            {
                // The condition below is not correct. You can't compare the result of Where directly to null.
                // Instead, you should check if any results match the condition.
                if (ticketQuery.Any(t => t.Id.ToString().Contains(searchTerm)))
                {
                    ticketQuery = ticketQuery.Where(t => t.Id.ToString().Contains(searchTerm));
                }
                else
                {
                    ticketQuery = ticketQuery.Where(t => t.Title.ToLower().Contains(searchTerm.ToLower()));
                }
            }

            var tickets = ticketQuery.ToList();

            return View(tickets);
        }

        public IActionResult TicketCrea() //ticket creator
        {
            ViewBag.UserId = Business.Controllers.HomeController.loggedemp.Id;
            Console.WriteLine("Viewbag id= " + ViewBag.UserIsAdmin);
            return View();
        }

        public IActionResult TicketReview(Ticket ticket) //ticket creator
        {
            var foundTicket = _context.Tickets.SingleOrDefault(t => t.Id == ticket.Id);
            Console.WriteLine("clicked ticket = "+ ticket.Title);
            Console.WriteLine("found ticket = " + foundTicket.Title);
            return View(foundTicket);
        }

        public IActionResult MyTickets(string searchTerm)
        {
            ViewBag.UserId = Business.Controllers.HomeController.loggedemp.Id;
            
            var ticketQuery = _context.Tickets.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // The condition below is not correct. You can't compare the result of Where directly to null.
                // Instead, you should check if any results match the condition.
                if (ticketQuery.Any(t => t.Id.ToString().Contains(searchTerm)))
                {
                    ticketQuery = ticketQuery.Where(t => t.Id.ToString().Contains(searchTerm));
                }
                else
                {
                    ticketQuery = ticketQuery.Where(t => t.Title.ToLower().Contains(searchTerm.ToLower()));
                }
            }

            var tickets = ticketQuery.ToList();

            return View(tickets);
        }

        public IActionResult EditTicket(int TicketId)
        {
            var ticketQuery = _context.Tickets.AsQueryable();
            Ticket ticket = _context.Tickets.SingleOrDefault(t => t.Id == TicketId);
            Console.WriteLine(ticket.Title);
            return View(ticket);
        }

        [HttpGet, ActionName("GetIssueOptions")]
        public JsonResult GetIssueOptions(string Type)
        {
            Console.WriteLine("Getissuescontroller is working");
            Console.Write("CONTROLERLELRLERLE is working");
            var issueOptions = _context.Problems
                .Where(prob => prob.Type == Type)
                .Select(prob => prob.Issue)
                .ToList();
            Console.WriteLine("Number of Issue Options: " + issueOptions.Count);
            return Json(issueOptions); // Return the field options as JSON
        }

        [HttpPost]
        public ActionResult newTicketPost(Ticket ticket)
        {
            ticket.senderID = HomeController.loggedemp.Id;
            ticket.Status = "Open";
            ticket.OwnerID = "Not Assigned";
            _context.Tickets.Add(ticket);
            
            _context.SaveChanges();
            return RedirectToAction("TicketCrea"); ;
        }

        [HttpPost]
        public ActionResult EditTicketPost(Ticket ticket)
        {
            Console.WriteLine(ticket.Id);
            var existingTicket = _context.Tickets.FirstOrDefault(t => t.Id == ticket.Id);

            if (existingTicket == null)
            {
                return NotFound();
            }

            // Update the properties of the existing ticket with the properties of the new ticket
            existingTicket.Type = ticket.Type;
            existingTicket.Issue = ticket.Issue;
            existingTicket.Priority = ticket.Priority;
            existingTicket.Title = ticket.Title;
            existingTicket.Desc = ticket.Desc;

            // Update the ticket in the database
            _context.Tickets.Update(existingTicket);

            _context.SaveChanges();
            return RedirectToAction("MyTickets");
        }

        //[HttpPost]
        //public ActionResult ReviewTicket(Ticket tickRev)
        //{
        //    var existingTicket = _context.Tickets.FirstOrDefault(t => t.Id == tickRev.Id);
        //    if (existingTicket == null)
        //    {
        //        Console.WriteLine("Ticket Not Found");
        //        return NotFound();
        //    }

        //    Console.WriteLine("Form ticket id:" + tickRev.Id + ", form status: " + tickRev.Status + ", form statement:" + tickRev.Statement);

        //    existingTicket.OwnerID = HomeController.loggedemp.Id.ToString();
        //    existingTicket.Status = tickRev.Status;
        //    existingTicket.Statement = tickRev.Statement;

        //    Console.WriteLine(" existing ticket id:" + existingTicket.Id + ", new status: " + existingTicket.Status + ", Official statement:" + existingTicket.Statement);

        //    _context.Tickets.Update(existingTicket);

        //    return RedirectToAction("TicketDb");

        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReviewTicket(Ticket tickRev)
        {
            if (ModelState.IsValid)
            {
                var existingTicket = _context.Tickets.FirstOrDefault(t => t.Id == tickRev.Id);
                Console.WriteLine("Form ticket id:" + tickRev.Id + ", form status: " + tickRev.Status + ", form statement:" + tickRev.Statement);

                existingTicket.OwnerID = HomeController.loggedemp.Id.ToString();
                existingTicket.Status = tickRev.Status;
                existingTicket.Statement = tickRev.Statement;

                _context.Tickets.Update(existingTicket);
                _context.SaveChanges();
                return RedirectToAction("TicketDb");
            }
            else
            {
                // Handle invalid ModelState (e.g., return the view with validation errors)
                return View(tickRev);
            }
        }


    }
}
