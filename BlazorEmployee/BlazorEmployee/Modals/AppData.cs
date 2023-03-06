
namespace BlazorEmployee.Modals
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime Dob { get; set; }

        public string Position { get; set; } = string.Empty;

        public int Salary { get; set; }

        public DateTime JoinDate { get; set; }
    }
   

}
