using Model = Employee.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Employee.Api.Infrastructure.EntityTypeConfiguration
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Model.Employee>
    {
        public void Configure(EntityTypeBuilder<Model.Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(employee => employee.Id);
            builder.Property(employee => employee.Id)
                .HasColumnName(@"Id")
                .HasColumnType("int")
                .IsRequired();
            builder.Property(employee => employee.FirstName)
                .HasColumnName(@"FirstName")
                .HasColumnType("varchar(50)");
            builder.Property(employee => employee.Surname)
                .HasColumnName(@"Surname")
                .HasColumnType("varchar(50)");
            builder.Property(employee => employee.BirthDate)
                .HasColumnName(@"BirthDate")
                .HasColumnType("date");

        }
    }
}