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
