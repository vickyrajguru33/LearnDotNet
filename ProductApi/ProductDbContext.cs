using Microsoft.EntityFrameworkCore;
// This imports the Entity Framework Core namespace, which provides tools for Object Relational Mapping (ORM), 
// enabling you to work with databases using C# objects.
// ProductDbContext : This is my class inherited with DbContext
// DbContext :  the base class in Entity Framework Core that manages the database connection and operations.
public class ProductDbContext : DbContext {

    // Constructor
    // This is a constructor that receives DbContextOptions<ProductDbContext>,
    //  typically injected via Dependency Injection (DI).

    // base(options) passes the options to the base DbContext 
    // so EF Core knows which database provider (e.g., PostgreSQL, SQL Server) and connection string to use.

    // Part	                Purpose
    // DbContext	        Base class to interact with database in EF Core
    // DbContextOptions	    Configures which DB to use and how
    // DbSet<Product>	    Represents a table of products
    
     public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
        {
    }

//     DbSet<Product> tells EF Core that Product is a model/table.

//     Products will map to a table named Products in the database.

    public DbSet<Product> product{get; set;}

}