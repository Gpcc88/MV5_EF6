# <a name="top">Table of contents 

* [Entity Framework 6 Code First Using MVC 5](#description)

	* [Setup](#setup)
	* [Tree Structure](#structure)

# <a name="description">Entity Framework 6 Code First Using MVC 5

This project results from the microsoft tutorial: Tutorial: Get Started with Entity Framework 6 Code First using MVC 5 | Microsoft Docs (https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application).
On this project, a "Contoso University" sample application (simple website) was built with CRUD functions.
This ASP.NET MVC 5 app uses Entity Framework 6 for data access. 
The CRUD functionality uses addicional features: sortiing, filtering and paging.
As this project uses a Windows Azure SQL Database, connection resiliency was enabled in order to prevent transient connection errors.
An Asynchronous programming model was implemented, enhancing performance on the Departments tab.
Also in the Departments tab, an optimistic concurrency to handle conflits, in the event of simultaneous update or delete, was set in place.
All nugget packages updated except Bootstrap which cannot be updated past 3.4.1 version.

[Back to Table of contents](#top)


## <a name="setup">Setup

###### Build / Run

Simply build the project on Visual Studio 2022 and run it.

[Back to Table of contents](#top)


## <a name="structure">Tree Structure
	
	📦ContosoUniversity
		┣ 📂ContosoUniversity
		┃ ┣ 📂App_Data
		┃ ┣ 📂App_Start			#MapRoute Configuration.
		┃ ┣ 📂Content			#precompiled files of Bootstrap.
		┃ ┣ 📂Controllers		#Classes for interaction between user and MVC APP.
		┃ ┣ 📂DAL			#Data Access Layer for access to entity-relational database
		┃ ┣ 📂fonts
		┃ ┣ 📂Logging
		┃ ┣ 📂Migrations		#Deploy changes to production without having to drop and re-create the database.
		┃ ┣ 📂Models			#Determines the shape of the data as public properties and business logic as methods.
		┃ ┣ 📂Scripts
		┃ ┣ 📂ViewModels		#Contains fields that are represented in the view				
		┃ ┣ 📂Views			#Contains template and data form. Receives data from the controller and shows them in the browser.				
		┃ ┃ ┣ 📂Course
		┃ ┃ ┣ 📂Department
		┃ ┃ ┣ 📂Home
		┃ ┃ ┣ 📂Instructor
		┃ ┃ ┣ 📂Shared
		┃ ┃ ┣ 📂Student
		┃ ┃ ┣ 📜Web.config
		┃ ┃ ┗ 📜_ViewStart.cshtml
		┃ ┣ 📜ContosoUniversity.csproj
		┃ ┣ 📜ContosoUniversity.csproj.user
		┃ ┣ 📜favicon.ico
		┃ ┣ 📜Global.asax
		┃ ┣ 📜Global.asax.cs
		┃ ┣ 📜packages.config
		┃ ┣ 📜Web.config
		┃ ┣ 📜Web.Debug.config
		┃ ┗ 📜Web.Release.config
		┣ 📂packages
		┣ 📜.gitignore
		┣ 📜ContosoUniversity.sln
		┗ 📜README.md
		
[Back to Table of contents](#top)




