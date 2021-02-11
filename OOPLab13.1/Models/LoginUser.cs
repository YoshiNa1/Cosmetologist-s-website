using System;
using System.ComponentModel.DataAnnotations;

namespace OOPLab13._1.Models
{
    public class LoginUser
    {
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your login, please")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Enter your password, please")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Must be more than 5 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
