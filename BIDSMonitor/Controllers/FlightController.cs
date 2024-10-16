using BIDSMonitor.Model;
using BIDSMonitor.Service;
using Microsoft.AspNetCore.Mvc;

namespace BIDSMonitor.Controllers
{
    public class FlightController : Controller
    {
        private readonly ILogger<FlightController> logger;
        private readonly IFlightService flightService;

        public FlightController(ILogger<FlightController> logger, IFlightService flightService)
        {
            this.logger = logger;
            this.flightService = flightService;
        }

        public IActionResult Index()
        {
            logger.LogInformation("FlightController.Index");
            return View();
        }

        public IActionResult Arrival()
        {
            logger.LogInformation("FlightController.Arrival");
            return View();

        }

        //add path variable
        //url : /flight/update/id
        [HttpGet]
        [Route("flight/update/{id}")]
        public async Task<IActionResult> Update(long id)
        {
            logger.LogInformation("FlightController.Update");
            try
            {
                var flight = await flightService.GetFlightByIdAsync(id);
                return View(flight);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePost(Flight updateFlight)
        {
            logger.LogInformation("FlightController.Update");
            try
            {
                var flight = await flightService.GetFlightByIdAsync(updateFlight.Id);

                if (flight != null)
                {
                    flight.FlightNo = updateFlight.FlightNo;
                    flight.ArrivalGate = updateFlight.ArrivalGate;
                    flight.DepartureGate = updateFlight.DepartureGate;
                    flight.CheckinCount = updateFlight.CheckinCount;
                    flight.SortingCount = updateFlight.SortingCount;
                    flight.BRSCount = updateFlight.BRSCount;
                    await flightService.UpdateFlightAsync(flight);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //redirect to update page with id
            return RedirectToAction("Update", new { id = updateFlight.Id });
        }
    }
}
