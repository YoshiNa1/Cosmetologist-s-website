using System;
using System.ComponentModel.DataAnnotations;

namespace OOPLab13._1.Models
{
    public class Client
    {
        [Required(ErrorMessage = "Enter your surname and name, please!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Check the correctness of the entered data")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email, please")]
        [EmailAddress(ErrorMessage = "You entered invalid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your phone, please")]
        [RegularExpression(@"\d{10}", ErrorMessage = "You entered invalid number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please, select date")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Please, select time")]
        public string Time { get; set; }

        public int Id { get; set; }
        public DateTime SignDate { get; set; }

    }
}
