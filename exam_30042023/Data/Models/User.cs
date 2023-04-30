using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace exam_30042023.Data.Models
{
    public class User : IdentityUser
    {
        //public User()
        //{
        //    Tickets = new List<Ticket>();
        //}

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "First name cannot be shorter than two letters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Last name cannot be shorter than two letters")]
        public string LastName { get; set; }
    }
}
