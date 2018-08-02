namespace CarRepairTracker.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarRepairDbContext : DbContext
    {
        // Your context has been configured to use a 'CarRepairDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CarRepairTracker.Models.CarRepairDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CarRepairDbContext' 
        // connection string in the application configuration file.
        public CarRepairDbContext()
            : base("name=CarRepairDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Part> Parts { get; set; }

        public virtual DbSet<Make> Makes { get; set; }

        public virtual DbSet<Model> Models { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Repair> Repairs { get; set; }

        public virtual DbSet<UserCar> UserCars{ get; set; }

        public virtual DbSet<Trim> Trims { get; set; }

        public virtual DbSet<Engine> Engines { get; set; }
    }
}