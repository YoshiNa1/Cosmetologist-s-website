using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOPLab13._1.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "Enter your email, please")]
        [EmailAddress(ErrorMessage = "You entered invalid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your login, please")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Enter your password, please")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Must be more than 5 characters")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

    }
}
