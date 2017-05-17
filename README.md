# FlatPlanetApp
MVC Application Exam that will increase the counter upon button click.

The application was built using Visual Studio 2015 and SQL Server 2012 Express Edition.

The application has 4 Projects. (3 of which has already been created prior to this exam and were just reused for the sake of this project)
  - Project.Core (reused project and updated the entities model)
  - Project.Data (reused)
  - Project.Service (reused)
  - Project.Web (newly created MVC project for this exam)
  
 In this project, I used  Constructor Dependency Injection, which is the most commonly used Dependency Injection Pattern in OOP. I know that this is just a simple project and doesn't need to have a design pattern implemented, but I did so FlatPlanet would have an overview on how I design my projects.
  
  - The Project.Core contains the entities that are necessary in the application's database. In this project, I created a BaseEntity class which has common properties that will be inherited by each entity and the CountTBL entity which was created using the Database First approach of Entity Framework.
  - The Project.Data has all the Creat, Update and Select operation and methods.
  - The Project.Service communicates with the UI and data access logic. 
  - The Project.WEB is the MVC application that will be used as the user interface for this project.
 
