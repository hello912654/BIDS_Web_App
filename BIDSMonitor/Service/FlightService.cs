using BIDSMonitor.Model;
using Microsoft.EntityFrameworkCore;

namespace BIDSMonitor.Service
{
    public class FlightService : IFlightService
    {
        private readonly FlightContext context;
        private readonly ILogger<FlightService> logger;

        public FlightService(FlightContext context, ILogger<FlightService> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task<List<Object?>> GetFlightAsync()
        {
            logger.LogInformation("FlightService.GetFlightAsync");
            try
            {
                var result = await context.Carousels
                .Select(c => new
                {
                    CarouselNo = c.CarouselNo,
                    Flights = c.FlightCarousels
                           .Select(fc => new
                           {
                               fc.Flight.FlightNo,
                               fc.Flight.FlightTo,
                               fc.Flight.DepartureGate,
                               fc.Flight.ETD,
                               fc.Flight.CheckinCount,
                               fc.Flight.SortingCount,
                               fc.Flight.BRSCount,
                               fc.Flight.DifferenceCount
                           })
                           .ToList()
                })
                .ToListAsync();
                return result.Cast<object?>().ToList();
            }
            catch (Exception ex)
            {

                logger.LogError(ex, "An error occurred while getting flights.");
                throw;
            }
            
        }

        public async Task<Flight?> GetFlightByIdAsync(long id)
        {
            logger.LogInformation("FlightService.GetFlightAsync");
            var flight = await context.Flights.FirstOrDefaultAsync(context => context.Id == id);
            //var flight = await context.Flights.FirstOrDefaultAsync();
            return flight;
        }
        public async Task UpdateFlightAsync(Flight flight)
        {
            logger.LogInformation("FlightService.UpdateFlightAsync");
            context.Flights.Update(flight);
            await context.SaveChangesAsync();
        }

    }
}
