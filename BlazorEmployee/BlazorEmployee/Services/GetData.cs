using BlazorEmployee.Modals;

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
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Age = 25,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Aung",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Hla",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Test",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Su",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Htet",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            },
            new Employee()
            {
                Name = "Kyaw",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Junior",
                Salary = 3
            },
            new Employee()
            {
                Name = "San",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Senior",
                Salary = 3
            },
            new Employee()
            {
                Name = "Mg",
                Age = 23,
                Dob = new DateOnly(2010, 9, 3),
                ID = Guid.NewGuid().GetHashCode(),
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            }
        };

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
