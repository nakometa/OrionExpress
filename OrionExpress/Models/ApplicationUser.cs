using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OrionExpress.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        [Required]
        public string FullName { get; set; }
    }
}
