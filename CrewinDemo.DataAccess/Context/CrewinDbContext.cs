using CrewinDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CrewinDemo.DataAccess.Context;

public class CrewinDbContext: DbContext
{
    public CrewinDbContext(DbContextOptions<CrewinDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasKey(c => c.Slug);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Category> Categories { get; set; }
}
