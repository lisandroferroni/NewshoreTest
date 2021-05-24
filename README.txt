In order to correctly build the app, first we have to set up the database. I used migrations from .net, so please follow these steps:
1- In ../NewshoreTest/NewshoreTest/appsettings.json replace 'localhost' for your local server name. I will create a pull request to show how it would be on my PC.
2- Open Package Manager Console (on visual studio, Tools -> NuGet Package Manager -> Package Manager Console)
3- In that console, there is a dropdown to set Default project. Set it to Data.
4- Run PM> Update-Database

If it builds Ok, it should create the database with its tables and a few sample rows and now we are ready to run the app with 'NewshoreTest' project set as Startup Project
