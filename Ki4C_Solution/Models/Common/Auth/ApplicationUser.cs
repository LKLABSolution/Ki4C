using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ki4C_Solution.Models.Common.Auth
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "아이디")]
        public string Id { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public bool KeepLoggedIn { get; set; }

    }
}
