using System.ComponentModel.DataAnnotations;

namespace BlazorCustomValidation.Model
{
    public class Person
    {
        [Required]
        [StringLength(50, ErrorMessage = "Please add only real name")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name must contain letter and space")]
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; } 
        
        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        //[CreditCard(ErrorMessage = "Credit Card number must be 15 number")]
        public string CreditCard { get; set; } = string.Empty;

        [Required]
        public DateTime JoinDate { get; set; } = DateTime.Now;
    }
}

