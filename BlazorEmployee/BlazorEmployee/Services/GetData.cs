using BlazorEmployee.Modals;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;

namespace BlazorEmployee.Services
{
    public class GetData
    {
        public List<Employee> Employees = new()
        {
            new Employee()
            {
                Name = "Aung",
                Age = 23,
                Dob = new DateOnly(1998, 9, 3),
                ID = new Random().Next(0,  100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Age = 25,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0,  100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0,  100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Aung",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            }
        };

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var idx = Employees.IndexOf(employee);
            Employees[idx] = employee;
        }

        public void DeleteEmployee(int Id)
        {
            var EmployeeToDelete = Employees.FirstOrDefault(d => d.ID == Id);
            if(EmployeeToDelete != null)
            {
                Employees.Remove(EmployeeToDelete); 
            }
        }
    }
}
