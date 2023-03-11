using BlazorEmployee.Modals;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;

namespace BlazorEmployee.Services
{
    public class GetData
    {
        public List<Employee> employees = new()
        {
            new Employee()
            {
                Name = "Aung",
                Dob = new DateOnly(1998, 9, 3),
                ID = new Random().Next(0,  100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0,  100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0,  100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Aung",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Dob = new DateOnly(2010, 9, 3),
                ID = new Random().Next(0, 100000000),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            }
        };

        public void UpdateEmployee(Employee employee)
        {
            var idx = employees.FindIndex(data => data.ID == employee?.ID);
            if(idx >= 0)
            {
                employees[idx] = employee;
            }
            else
            {
                employees.Add(employee);
            }
        }

        public void DeleteEmployee(int Id)
        {
            var idx = employees.FindIndex(d => d.ID == Id);
            if(idx >= 0)
            {
                employees.RemoveAt(idx);
            }
        }

        
    }
}
