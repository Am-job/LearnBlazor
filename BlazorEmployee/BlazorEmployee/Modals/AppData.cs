
using System.ComponentModel.DataAnnotations;

namespace BlazorEmployee.Modals
{
    public class Employee
    {
        public int ID { get; set; }


        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name must contain letter and space")]
        public string Name { get; set; } = string.Empty;


        public DateOnly Dob { get; set; }      


        [Required(ErrorMessage = "Please select your position.")]
        [StringLength(50, ErrorMessage = "Position is too long.")]
        public string Position { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your salary.")]
        [Range(1, 1000000000000, ErrorMessage = "Please enter a valid age.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please enter your Join Date.")]
        public DateTime JoinDate { get; set; } 
    }
}
