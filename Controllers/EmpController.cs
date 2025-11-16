using Project2d.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Project2d.Controllers
{
    public class EmpController : Controller
    {
        private VistaraDb2Entities d = new VistaraDb2Entities();

        // Home page
        public ActionResult Emphome()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        // Search Flights
        [HttpGet]
        public ActionResult SearchFlight()
        {
            return View(new List<Flight>());
        }

        [HttpPost] 
        public ActionResult SearchFlight(string Sou, string Des)
        {
            var flights = d.Flights
                           .Where(f => f.Source.Contains(Sou) && f.Destination.Contains(Des))
                           .ToList();

            return View(flights);
        }
        [HttpGet]
        public ActionResult Booking(int id)
        {
            var flight = d.Flights.SingleOrDefault(f => f.FCode == id);

             ViewBag.Flight = flight;

             var booking = new Booking { FCode = flight.FCode };

            return View(booking);
        }

        [HttpPost]
        public ActionResult Booking(Booking obj)
        {
            if (ModelState.IsValid)
            {
                d.Bookings.Add(obj);
                d.SaveChanges();
                return RedirectToAction("AllBookings");
            }
            return View(obj);
        }

    }
}
