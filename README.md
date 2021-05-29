# _Dr. Sillystringz's Factory_

#### _A C# web application to help keep track of Machines and the Engineers licensed to repair them_

#### By _Ryan Walker_

## Description
This application will allow Dr. Sillystringz to add Machines, and the Engineers that are licensed to repair them, to a list as they are installed. The program will allow Dr. Sillystringz to add Machines and Engineers independently as well. While viewing a list of all Machines, Dr. Sillystringz will be able to see which Engineers are licensed to repair which Machines. Additionally, while viewing a list of all Engineers, Dr. Sillystringz will be able to see which machines each Engineer is licensed to repair. The application allows for the creation, modification, and deletion of Machines and Engineers.   

## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A command line interface like Terminal or GitBash to run and interact with the app.
* [MySQL Workbench](https://www.mysql.com/products/workbench/)

### Connecting project to database via appsettings.json
1. In the production folder `Factory.Solution/Factory` create a file called `appsettings.json`
2. Add the following code:`{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database={YOUR_SCHEMA_NAME};uid=root;pwd={YOUR_PASSWORD};"
  }
}`
   * Fill in the desired name of your schema and your MySQL Workbench password, omitting the curly braces

### Installation
1. Clone the repository: `$ git clone https://github.com/RyanDanielWalker/Factory.Solution`
2. Navigate to the `Factory.Solution/` directory on your computer
3. Open with your preferred text editor to view the code base
4. To run the app:
    * Navigate to `Factory.Solution/Factory` in your command line
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the command `dotnet build` to build the project and its dependencies into a set of binaries
    * Run the command `dotnet ef database update` to create database and populate tables
    * Finally, run the command `dotnet run` to run the project!
    * Note: `dotnet run` also restores and builds the project, so you can use this single command to start the app
    * View the application via your preferred web browser by visiting `localhost:5000/`


## Known Bugs
* User able to add same Engineer to Machine an unlimited amount of times.
* If invalid date entered, date defaults to 01/01/0001

## Technologies Used
* ASP .NET Core MVC
* C#
* VS Code
* MySQL Workbench
* MySQL
* Entity Framework Core
* LINQ

### License

MIT

Copyright (c) 2021 _Ryan Walker_

## Contact Information
[Ryandanielwalker@gmail.com](mailto:ryandanielwalker@gmail.com)




