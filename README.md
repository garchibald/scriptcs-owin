scriptcs-owin
===============

# Owin Self Host Script Pack

## What is it?
Owin self hosted HTTP server within scriptcs

## Highlights:

* Creates a self hosted OWIN http server host.
* Allows instances of IOwinStartup to plug in as OWIN middleware components

## Getting started with OWIN using the pack

```csharp
public class TestController : ApiController {
	public string Get { 
		return "Hello World";
	}
}

Require<OwinSelfHost>();

var webApi = Require<WebApiOwin>();
webApi.CreateServer();

using ( OwinSelfHost.CreateServer("http://localhost:8080", webApi) ) {
	Console.WriteLine("Listening...");
	Console.ReadLine();
}

```
* Install the dependencies ```scriptcs -install -pre```
* Running as admin type ```scriptcs start.csx``` to launch the app.
* Open a browser to "http://localhost:8080/api/test";
* That's it, your OWIN self hosted server is running with webapi

## Customizing
You can customize the componants loaded by passing in additional IOwinStartup

## What's next
TBD