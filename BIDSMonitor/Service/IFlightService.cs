using BIDSMonitor.Model;

namespace BIDSMonitor.Service
{
    public interface IFlightService
    {
        public Task UpdateFlightAsync(Flight flight);

        public Task<Flight?> GetFlightByIdAsync(long id);

        public Task<List<Object?>> GetFlightAsync();

    }
}
