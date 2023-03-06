using BlazorEmployee.Modals;

namespace BlazorEmployee.Services
{
    public class GetData
    {
        public List<Employee> Employees = new List<Employee>();
        
        public List<Employee> EmployeeData()
        {
            Employees.Add(new Employee()
            {
                Name = "Aung",
                Age = 23,
                Dob = new DateTime(2010, 9, 3),
                ID = 1,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Employee",
                Salary = 3
            });
            Employees.Add(new Employee()
            {
                Name = "Hla",
                Age = 23,
                Dob = new DateTime(2010, 9, 3),
                ID = 1,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            });
            Employees.Add(new Employee()
            {
                Name = "Test",
                Age = 23,
                Dob = new DateTime(2010, 9, 3),
                ID = 1,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Employee",
                Salary = 3
            });
            Employees.Add(new Employee()
            {
                Name = "Hla",
                Age = 23,
                Dob = new DateTime(2010, 9, 3),
                ID = 1,
                JoinDate = new DateTime(2010, 9, 3),
                Position = "Manager",
                Salary = 3
            });

            return Employees;
        }
    }
}
