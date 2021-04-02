# StudentResultsService
This is a basic .NET RESTful service that demonstrates the GET verb on a restful microservice.  This was a simple example I put together to show how easy it would be to create a RESTful web API to get some sample (fake) student data from a microservice deployed in the cloud. 

Download the source.
The code has a API controlled called StudentResultsController. This is a Web API controller base class that allows you to add the standard RESTful verbs (GET, POST, PUT, DELETE).
Go to the controllers folder and you'll find the StudentResultsController.
The GET method retrieves a list of students and their classes and the GPA for those classes.
This would normally be pulling from a database, but this exmample is just to show the use of restful web api.

Build the code.  You can download this as a zip file and use the Controller code found in the zip but start with this command on command line to build project:
   prompt>> dotnet new webapi -o MyServiceName --no-https -f net5.0
on PowerShell, navigate to directory.
Once built, in the shell, type 'dotnet run'
This should run the microservice on localhost
in a web browser, type into the address bar 'http://localhost:5000/StudentResults'
This should give you a readout of the values for StudentResults provided by the GET method.

