using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Model = Employee.Api.Model;
namespace Employee.Api.Infrastructure
{
    public class EmployeeContextSeed
    {
        private const string FILENAME = "InitialEmployee.txt";
        public static void Seed(ModelBuilder builder, string contentRootPath)
        {
            List<Model.Employee> employees = new List<Model.Employee>();
            string path = Path.Combine(contentRootPath, "Setup", FILENAME);
            string[] rawEmployees = File.ReadAllLines(path);
            foreach (var item in rawEmployees)
            {
                string[] values = item.Split(',');
                if (values.Length == 4)
                    employees.Add(new Model.Employee() { Id = Int32.Parse(values[0]), FirstName = values[1], Surname = values[2], BirthDate = DateTime.Parse(values[3]) });
            }
            builder.Entity<Model.Employee>().HasData(employees);

        }
    }
}