using System;
using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data;

// Anything we want to do with database goes here
public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        
    }
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
