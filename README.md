# Baggage Information Display System (ASP.NET Core Demo)

This is a simple ASP.NET Core MVC demo project for a baggage information display system, designed for use in airport environments. It includes real-time flight and baggage updates using SignalR, and demonstrates a clean architecture with practical features.

## Technologies Used

- ASP.NET Core MVC  
- SignalR for real-time communication  
- Razor Views for frontend rendering  
- SQL Server for data storage

## Project Structure and Key Components

### Real-time Updates via SignalR

- **FlightHub.cs**  
  Located at: `\ConnectionHub\FlightHub.cs`  
  Implements the SignalR hub for pushing real-time flight and baggage updates to clients.

- **FlightUpdateService.cs**  
  Located at: `\Service\FlightUpdateService.cs`  
  Background service that periodically fetches updated flight data and sends it to clients via `IHubContext<FlightHub>`.

- **Configuration (`appsettings.json`)**

```json
"UpdateIntervalSeconds": 60
```

`UpdateIntervalSeconds` defines the polling interval in seconds. Default is 60 seconds.

- **SignalR Hub Registration (Program.cs)**

```csharp
app.MapHub<FlightHub>("/flighthub");
```

Use `MapHub` to register additional hubs if needed.

### Frontend (View Layer)

- **Index.cshtml**  
  Located at: `\Views\Flight\Index.cshtml`  
  JavaScript code establishes a connection to the SignalR hub and handles incoming updates.

```javascript
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/flighthub")
    .build();

connection.start().then(() => {
    console.log("Connected to SignalR Hub");
}).catch(err => console.error(err.toString()));

connection.on("ReceiveFlightUpdate", function (flight) {
    // Handle flight data
});
```

## Features

- Clean and modular ASP.NET Core MVC architecture  
- Real-time updates using SignalR  
- Integration with SQL Server  
- Easy to maintain and extend  
- Combines backend logic with dynamic frontend rendering

## Database

- Supports tables for flight, baggage, and carousel information  
- Uses SQL Server  
- Schema can be extended depending on system requirements

## Notes

This project is intended for demonstration purposes and learning. It showcases real-time update patterns and MVC design, but does not include full authentication or production-level configurations.
