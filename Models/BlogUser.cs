using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class BlogUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        public string DisplayName { get; set; }

        public ICollection<Comment> Comments { get; set; } /*= new HashSet<Comment>();*/

        public BlogUser()
        {
            Comments = new HashSet<Comment>();
            DisplayName = "New User";
        }
    }
}
