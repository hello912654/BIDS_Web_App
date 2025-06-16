# Asp net core demo
This is a simple demo for baggage information display system

- build with **ASP.NET Core**
# Note

* Create SignalR hub to push messages to clients

` \ConnectionHub\FlightHub.cs `



***
* Create a service to fetch flight data from the server
* Use `IHubContext<FlightHub>` to create a connection to the hub

` \Service\FlightUpdateService.cs `



***

`appsettings.json`

````json
"UpdateIntervalSeconds": 60
````
#### UpdateIntervalSeconds : Interval to fetch data from the server (default : 60 seconds)

***
`Program.cs`

````csharp
 app.MapHub<FlightHub>("/flighthub");  
````
#### Add multiple hubs by add `MapHub`

***
`Views\Flight\Index.cshtml`
#### Use JavaScript to connect to the SignalR hub

````javascript
<script>
        const connection = new signalR.HubConnectionBuilder()
            .withUrl("/flightHub")
            .build();

        connection.start().then(function () {
            console.log("Connected to SignalR Hub");
        }).catch(function (err) {
            return console.error(err.toString());
        });

        connection.on("ReceiveFlightUpdate", function (flight) {
			...
		});
</script>
````
- ### ASP.NET Core MVC Application

- Built with the **Model-View-Controller (MVC)** design pattern
- Combines backend logic and frontend rendering in a unified web project
- Views are rendered dynamically using Razor syntax
- Controllers handle request routing, business logic, and data transformation
- Models represent flight, baggage, and carousel data from the database
  
### Database (SQL Server)
### Key Features

- ASP.NET Core MVC-based clean architecture
- Real-time display of baggage and flight information
- Easy to maintain and extend
 

 
    
