
using System.ComponentModel.DataAnnotations;

namespace BlazorEmployee.Modals
{
    public class Employee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your age.")]
        [Range(1, 100, ErrorMessage = "Please enter a valid age.")]
        public int Age { get; set; }

        public DateOnly Dob { get; set; }      //3-Jan-1998
        [Required(ErrorMessage = "Please select your position.")]
        public string Position { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your salary.")]
        [Range(1, 1000000000000, ErrorMessage = "Please enter a valid age.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please enter your Join Date.")]
        public DateTime JoinDate { get; set; } //3-Jan-1998
    }
}
