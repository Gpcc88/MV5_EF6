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

[Back to Table of contents](#top)


## <a name="setup">Setup

###### Build / Run

Simply build the project on Visual Studio 2022 and run it.

[Back to Table of contents](#top)


## <a name="structure">Tree Structure

.
|   .gitignore
|   ContosoUniversity.sln
|   output.doc
|   README.md
|   test 
|   
+---ContosoUniversity
|   |   ContosoUniversity.csproj
|   |   ContosoUniversity.csproj.user
|   |   favicon.ico
|   |   Global.asax
|   |   Global.asax.cs
|   |   packages.config
|   |   Web.config
|   |   Web.Debug.config
|   |   Web.Release.config   
|   |    
|   +---App_Data
|   |  
|   +---App_Start
|   |       BundleConfig.cs
|   |       FilterConfig.cs
|   |       RouteConfig.cs
|   |  
|   +---bin    
|   |    
|   +---Content   
|   |     
|   +---Controllers
|   |       CourseController.cs
|   |       DepartmentController.cs
|   |       HomeController.cs
|   |       InstructorController.cs
|   |       StudentController.cs  
|   |     
|   +---DAL
|   |       SchoolConfiguration.cs
|   |       SchoolContext.cs
|   |       SchoolInicializer.cs
|   |       SchoolInterceptorLoggingcs.cs
|   |       SchoolInterceptorTransientErrors.cs 
|   |      
|   +---fonts     
|   +---Logging      
|   +---Migrations
|   |       202206081010033_Initial.cs
|   |       202206081010033_Initial.Designer.cs
|   |       202206081010033_Initial.resx
|   |       202206081016357_ComplexDataModel.cs
|   |       202206081016357_ComplexDataModel.designer.cs
|   |       202206081016357_ComplexDataModel.resx
|   |       202206081019461_DepartmentSP.cs
|   |       202206081019461_DepartmentSP.Designer.cs
|   |       202206081019461_DepartmentSP.resx
|   |       202206081023343_Rowversion.cs
|   |       202206081023343_Rowversion.Designer.cs
|   |       202206081023343_Rowversion.resx
|   |       202206081025106_Inheritance.cs
|   |       202206081025106_Inheritance.Designer.cs
|   |       202206081025106_Inheritance.resx
|   |       Configuration.cs  
|   |     
|   +---Models
|   |       Course.cs
|   |       Department.cs
|   |       Enrollment.cs
|   |       Instructor.cs
|   |       OfficeAssignment.cs
|   |       Person.cs
|   |       Student.cs  
|   |      
|   +---obj
|   |  
|   +---Properties
|   |  
|   +---Scripts  
|   |  
|   +---ViewModels
|   |       AssignedCourseData.cs
|   |       EnrollmentDateGroup.cs
|   |       InstructorIndexData.cs
|   |       
|   \---Views
|       |   Web.config
|       |   _ViewStart.cshtml
|       |   
|       +---Course
|       |       Create.cshtml
|       |       Delete.cshtml
|       |       Details.cshtml
|       |       Edit.cshtml
|       |       Index.cshtml
|       |       UpdateCourseCredits.cshtml
|       |       
|       +---Department
|       |       Create.cshtml
|       |       Delete.cshtml
|       |       Details.cshtml
|       |       Edit.cshtml
|       |       Index.cshtml
|       |       
|       +---Home
|       |       About.cshtml
|       |       Contact.cshtml
|       |       Index.cshtml
|       |       
|       +---Instructor
|       |       Create.cshtml
|       |       Delete.cshtml
|       |       Details.cshtml
|       |       Edit.cshtml
|       |       Index.cshtml
|       |       
|       +---Shared
|       |       Error.cshtml
|       |       _Layout.cshtml
|       |       
|       \---Student
|               Create.cshtml
|               Delete.cshtml
|               Details.cshtml
|               Edit.cshtml
|               Index.cshtml
|               
\---packages

[Back to Table of contents](#top)




