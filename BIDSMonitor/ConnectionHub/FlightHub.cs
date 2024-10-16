using System.Threading.Tasks;
using BIDSMonitor.Model;
using Microsoft.AspNetCore.SignalR;

namespace BIDSMonitor.ConeectionHub
{
    public class FlightHub : Hub
    {
        public async Task SendFlightUpdate(Flight flight)
        {
            await Clients.All.SendAsync("ReceiveFlightUpdate", flight);
        }
    }
}
