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

