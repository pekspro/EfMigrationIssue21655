﻿using Microsoft.EntityFrameworkCore;

namespace NetCore3_0TestApplication.Data
{
    public class FirstDatabaseContext : DbContext
    {
        public FirstDatabaseContext(DbContextOptions<FirstDatabaseContext> options)
                : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FirstDataModel>().HasData(
                new FirstDataModel() { FirstDataModelID = 1, Name = "First name", LastName = "Last name" });
        }

        public DbSet<FirstDataModel> FirstDataModels { get; set; }
    }

    public class FirstDataModel
    {
        public int FirstDataModelID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }
    }
}
