using System.ComponentModel.DataAnnotations;

namespace BlazorStorageService.Model
{
    public class Employee
    {

        [Required]
        [StringLength(50, ErrorMessage = "Please add only real name")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name must contain letter and space")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }

        public int id { get; set; } = 1;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [CreditCard(ErrorMessage = "Credit Card number must be 15 number and please fill correctly")]
        public string CreditCard { get; set; } = string.Empty;

        [Required]
        public DateTime JoinDate { get; set; } = DateTime.Today;

        public Employee ShallowCopy()
        {
            return (Employee)MemberwiseClone();
        }
    }
}
