using System.Xml.Linq;

namespace BlazorEmployee
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int dob { get; set; }

        public string postion { get; set; } 

        public int salary { get; set; }

        public string joinDate { get; set; }
    }
    public class AppData
    {
        public List<Employee> EmployeeData { get; set; } = new List<Employee>();
    }

}
