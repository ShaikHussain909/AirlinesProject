using Project2d.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2d.Controllers
{
    public class ManagerController : Controller
    {
        private VistaraDb2Entities d = new VistaraDb2Entities();
        // GET: Manager

        public ActionResult Managerhome()
        {
            return View();
        }
        public ActionResult Adding()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Adding(Flight obj)
        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    d.Flights.Add(obj);
                    d.SaveChanges();
                    return RedirectToAction("ViewDetails");
                }
                return View(obj);
            }
            return View(obj);
        }
        [HttpGet]
        public ActionResult ViewDetails()
        {
            var data = d.Flights.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = d.Flights.Where(x => x.FCode == id).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int id ,MrgModel obj)
        {
            var data = d.Flights .FirstOrDefault(x => x.FCode == id);
            if (data != null)
            {
                data.FCode = obj.FCode;
                data.FName = obj.FName;
                data.Source = obj.Source;
                data.Arrival = TimeSpan.Parse(obj.Arrival);
                data.Departure = TimeSpan.Parse(obj.Departure);
                data.Destination = obj.Destination;
                data.Bus_Seats = obj.Bus_Seats;
                data.Bus_Fare = obj.Bus_Fare;
                data.Eco_Seats = obj.Eco_Seats;
                data.Eco_Fare = obj.Eco_Fare;
                data.Exe_Seats = obj.Exe_Seats;
                data.Exe_Fare = obj.Exe_Fare;
                d.SaveChanges();
                return RedirectToAction("ViewDetails");
            }
                return View(data);
        }
        public ActionResult Delete(int id, MrgModel obj)
        {
            var data = d.Flights.FirstOrDefault(x => x.FCode == id);
            if (data != null)
            {
                 d.Flights.Remove(data);
                d.SaveChanges();
                return RedirectToAction("ViewDetails");
            }
            return View(data);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}