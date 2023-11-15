﻿
using CompaniesApp.API.Data.Models;
using ConsoleAppApi.Data.Models;

namespace CompaniesApp.API.Data
{
    public static class FakeDb
    {
        public static List<Company> CompaniesDb = new List<Company>()
        {
            new Company()
            {
                Id = 1,
                Name = "Microsoft",
                EstablishedYear = 1975,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
            new Company()
            {
                Id = 2,
                Name = "Apple",
                EstablishedYear = 1976,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
            new Company()
            {
                Id = 3,
                Name = "Google",
                EstablishedYear = 1998,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
            new Company()
            {
                Id = 4,
                Name = "Amazon",
                EstablishedYear = 1994,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
            new Company()
            {
                Id = 5,
                Name = "Facebook",
                EstablishedYear = 2004,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
            new Company()
            {
                Id = 6,
                Name = "Twitter",
                EstablishedYear = 2006,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
            new Company()
            {
                Id = 7,
                Name = "Uber",
                EstablishedYear = 2009,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
            new Company()
            {
                Id = 8,
                Name = "Airbnb",
                EstablishedYear = 2008,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            },
        };

        public static List<Company> GetAllCompanies()
        {
            return CompaniesDb;
        }


        public static List<Employee> EmployeesDb = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName = "Employee 01",
                LastName = "LN01",
                DOB = DateTime.UtcNow,
                Role = "Admin"
            },
            new Employee()
            {
                Id = 2,
                FirstName = "Employee 02",
                LastName = "LN02",
                DOB = DateTime.UtcNow,
                Role = "Admin"
            },
            new Employee()
            {
                Id = 3,
                FirstName = "Employee 03",
                LastName = "LN03",
                DOB = DateTime.UtcNow,
                Role = "Admin"
            },
            new Employee()
            {
                Id = 4,
                FirstName = "Employee 04",
                LastName = "LN04",
                DOB = DateTime.UtcNow,
                Role = "Admin"
            }
        };

        public static List<Employee> GetAllEmployees()
        {
            return EmployeesDb;
        }
        public static List<Student> StudentsDb = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                StName = "Student 01",
                LsName = "LN01",
                DOB = DateTime.UtcNow,
               
            },
           new Student()
            {
                Id = 2,
                StName = "Student 02",
                LsName = "LN02",
                DOB = DateTime.UtcNow,

            },
       
           new Student()
            {
                Id = 2,
                StName = "Student 03",
                LsName = "LN03",
                DOB = DateTime.UtcNow,

            },
            new Student()
            {
                Id = 4,
                StName = "Student 04",
                LsName = "LN04",
                DOB = DateTime.UtcNow,
            }
        };

        public static List<Student> GetAllStudent()
        {
            return StudentsDb;
        }
    }
}