using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Entities;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewshoreTest.Controllers
{
    public class ItineraryController : Controller
    {
        private readonly IItineraryService itineraryService;
        public ItineraryController(IItineraryService itineraryService)
        {
            this.itineraryService = itineraryService;
        }

        public IActionResult Index()
        {
            return View(itineraryService.GetAllPassengers());
        }

        public IActionResult UpdatePassenger(Passenger passenger)
        {
            return View("UpdatePassenger", passenger);
        }

        public IActionResult Update(Passenger passenger)
        {
            itineraryService.UpdatePassenger(passenger);
            return View("Index", itineraryService.GetAllPassengers());
        }


    }
}
