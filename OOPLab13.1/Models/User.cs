using System;
using System.Collections.Generic;

namespace OOPLab13._1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public List<Comment> Comments { get; set; }
    }
    public class Role
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}
