Following are the steps to create this Project: 
    1. dotnet new webapi -n ProductApi   : To create new Project
       cd ProductApi                     : Navigate to Project Directory

Project Structure : 
        ProductApi/
        ├── Controllers/
        │   └── WeatherForecastController.cs (can delete)
        ├── Program.cs
        ├── appsettings.json
        ├── Product.cs           <-- Add this
        ├── ProductDbContext.cs  <-- Add this
        ├── ProductController.cs <-- Add this

Install the PostgreSQL provider:(It enables your C# Entity Framework Core app to interact with PostgreSQL, mapping models to tables and supporting LINQ, migrations, and code-first database creation.)
    dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

Write Product.cs Entity class..with all properties
write ProductDbContext to connect and configure DB with Parant class ProductDbContext
Configure PostgreSQL in appsettings.json