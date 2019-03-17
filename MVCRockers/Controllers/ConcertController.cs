using MVCRockers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    public class ConcertController : Controller
    {
        Concert concert = new Concert
        {
            Name = "TestData Concert",
            Price = 1.00,
            Tickets = 10,
            City = "Someville",
            ConcertDate = DateTime.UtcNow
        };

        // GET: Concert
        public ActionResult Index()
        {
            return View(concert);
        }

        public ActionResult Edit()
        {
            return View(concert);
        }

    }
}