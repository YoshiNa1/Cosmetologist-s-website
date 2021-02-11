using System;
using System.ComponentModel.DataAnnotations;

namespace OOPLab13._1.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime CommentDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Enter the text, please!")]
        public string CommentText { get; set; }
        public bool Hidden { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

    }
}
