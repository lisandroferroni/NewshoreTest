using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewshoreTest.Models;
using Services.Interfaces;
using System.Diagnostics;
using Model;
using System.Threading.Tasks;

namespace NewshoreTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IHomeService homeService;

        public HomeController(ILogger<HomeController> logger,
            IHomeService homeService)
        {
            this.logger = logger;
            this.homeService = homeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> FindFlightsAsync(RequestFindFlights findFlightsRequest)
        {
            var flights = await this.homeService.FindFlightsAsync(findFlightsRequest);
            
            return View("Index", flights);
        }

        public async Task<IActionResult> SaveFlight(RequestSaveFlight requestSaveFlight)
        {
            var savedFlight = await this.homeService.SaveFlight(requestSaveFlight);

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
