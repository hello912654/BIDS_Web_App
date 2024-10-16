
using BIDSMonitor.ConeectionHub;
using BIDSMonitor.Model;
using Microsoft.AspNetCore.SignalR;

namespace BIDSMonitor.Service
{
    public class FlightUpdateService : BackgroundService
    {
        private readonly ILogger<FlightUpdateService> logger;
        private readonly IHubContext<FlightHub> hubContext;
        private readonly IServiceScopeFactory scopeFactory;
        private readonly IConfiguration configuration;

        public FlightUpdateService(ILogger<FlightUpdateService> logger, IHubContext<FlightHub> hubContext, IServiceScopeFactory serviceScopeFactory, IConfiguration configuration)
        {
            this.logger = logger;
            this.hubContext = hubContext;
            this.scopeFactory = serviceScopeFactory;
            this.configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = scopeFactory.CreateScope())
                {
                    var flightService = scope.ServiceProvider.GetRequiredService<IFlightService>();
                    var flight = await flightService.GetFlightAsync();
                    if (flight == null)
                    {
                        logger.LogWarning("Flight not found");
                        return;
                    }
                    await hubContext.Clients.All.SendAsync("ReceiveFlightUpdate", flight);
                }
                await Task.Delay(TimeSpan.FromSeconds(configuration.GetValue<int>("UpdateIntervalSeconds")), stoppingToken);
            }
        }
    }
}
