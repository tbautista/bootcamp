using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Model = Employee.Api.Model;
using Employee.Api.Infrastructure.EntityTypeConfiguration;

namespace Employee.Api.Infrastructure
{
    public class EmployeeContext : DbContext
    {
        private string ContentRootPath;
        public DbSet<Model.Employee> Employees { get; set; }
        public EmployeeContext(DbContextOptions<EmployeeContext> options, IWebHostEnvironment env) : base(options)
        {
            ContentRootPath = env.ContentRootPath;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
            EmployeeContextSeed.Seed(builder, ContentRootPath);
        }
    }
}