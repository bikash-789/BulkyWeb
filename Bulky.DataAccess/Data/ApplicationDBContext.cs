using System;
using Microsoft.EntityFrameworkCore;
using Bulky.Models;

namespace Bulky.DataAccess.Data;

// Anything we want to do with database goes here
public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : DbContext(options)
{
    // will create Table with name 'Categories' in database    
    public DbSet<Category> Categories { get; set; }

    // seeding Categories table with random data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
        .HasData(
            new Category { Id = 1, DisplayOrder = 1, Name = "Action" }, 
            new Category { Id = 2, DisplayOrder = 1, Name = "Sci-Fi" }, 
            new Category { Id = 3, DisplayOrder = 3, Name = "History" }
        );
    }
}
