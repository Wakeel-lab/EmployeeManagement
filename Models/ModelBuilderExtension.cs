using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 001,
                   Name = "Maryam",
                   Department = Dept.IT,
                   Email = "maryam@olajaws.com"
               },
               new Employee
               {
                   Id = 002,
                   Name = "Fashanu",
                   Department = Dept.HR,
                   Email = "fash@olajaws.com"
               }
               );
        }
    }
}
