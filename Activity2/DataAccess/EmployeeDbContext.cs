using Activity2.Entities;
using Activity2.Models;
using Microsoft.EntityFrameworkCore;

namespace Activity2.DataAccess
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    _ = modelBuilder.Entity<Employee>().HasData(
        //        new Employee()
        //        {
        //            Id = Guid.Parse("fafe3893-193c-4e84-9001-ffe1f478e914"),
        //            Name = "Summi Derama",
        //            Email = "jeskhasamanthaderama@gmail.com",
        //            Position = "Developer",
        //            Salary = 28000,
        //            SSSNumber = "21101228",
        //            PagIbigNumber = "21101228",
        //            //IsDeleted = false
        //        },
        //        new Employee()
        //        {
        //            Id = Guid.Parse("e1c93f76-c6a4-4b1a-b423-aa7c5e1a2005"),
        //            Name = "Jansen Choi",
        //            Email = "jansenchoi@gmail.com",
        //            Position = "Scrum Master",
        //            Salary = 28000,
        //            SSSNumber = "21101228",
        //            PagIbigNumber = "21101228",
        //            //IsDeleted = false
        //        },
        //        new Employee()
        //        {
        //            Id = Guid.Parse("20176a93-4603-4cce-9d1b-884d8b3bfea6"),
        //            Name = "Josh Lui",
        //            Email = "joshlui@gmail.com",
        //            Position = "Project Owner",
        //            Salary = 28000,
        //            SSSNumber = "21101228",
        //            PagIbigNumber = "21101228",
        //            //IsDeleted = false
        //        }
        //        );
        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
