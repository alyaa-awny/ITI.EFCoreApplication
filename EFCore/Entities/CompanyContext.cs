using EFCore.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Entities;

public class CompanyContext : DbContext
{
    //runtime connection string
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.; Database= EFCoreSD43; trusted_Connection = true; Encrypt = false");
        base.OnConfiguring(optionsBuilder);
    }

    //fluent api
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Employee>().HasKey(e => e.ID);
        base.OnModelCreating(modelBuilder);
    }



    //build container for classes that will be entities in database 
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
}
