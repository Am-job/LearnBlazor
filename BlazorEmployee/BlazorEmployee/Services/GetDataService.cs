using BlazorEmployee.Modals;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;

namespace BlazorEmployee.Services
{
    public class GetDataService
    {
        public List<Employee> employees = new()
        {
            new Employee()
            {
                Name = "Aung",
                Dob = new DateOnly(1998, 9, 3),
                ID = 1,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Dob = new DateOnly(2010, 9, 3),
                ID = 2,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Dob = new DateOnly(2010, 9, 3),
                ID = 3,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Dob = new DateOnly(2010, 9, 3),
                ID = 4,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Dob = new DateOnly(2010, 9, 3),
                ID = 5,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Dob = new DateOnly(2010, 9, 3),
                ID = 6,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Dob = new DateOnly(2010, 9, 3),
                ID = 7,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Dob = new DateOnly(2010, 9, 3),
                ID = 8,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Aung",
                Dob = new DateOnly(2010, 9, 3),
                ID = 9,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Dob = new DateOnly(2010, 9, 3),
                ID = 10,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Dob = new DateOnly(2010, 9, 3),
                ID = 11,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Dob = new DateOnly(2010, 9, 3),
                ID = 12,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Dob = new DateOnly(2010, 9, 3),
                ID = 13,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Dob = new DateOnly(2010, 9, 3),
                ID = 14,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Dob = new DateOnly(2010, 9, 3),
                ID = 15,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Dob = new DateOnly(2010, 9, 3),
                ID = 16,
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
