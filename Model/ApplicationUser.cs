using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Api1.Model
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
    }
}
