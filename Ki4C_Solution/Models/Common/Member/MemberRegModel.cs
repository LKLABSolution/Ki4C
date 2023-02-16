using System.ComponentModel.DataAnnotations;

namespace Ki4C_Solution.Models.Common.Member
{
    public class MemberRegModel
    {
        //this model is used for MemberReg.cshtml input tag name

        [Required] public string Id { get; set; } = string.Empty;

        [Required] public string Password { get; set; } = string.Empty;
        [Required] public string PasswordConfirm { get; set; } = string.Empty;
        [Required] public string UserName { get; set; } = string.Empty;
        [Required] public string NormalizedUserName { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
        public string NormalizedEmail { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; }
        [Required] public string PasswordHash { get; set; } = string.Empty;
        public string SecurityStamp { get; set; } = string.Empty;
        public string ConcurrencyStamp { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        [Required] public bool PhoneNumberConfirmed { get; set; }
        [Required] public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string DepartmentName{ get; set; } = string.Empty;
        [Required] public string Address { get; set; } = string.Empty;
        [Required] public string AddressDetail { get; set; } = string.Empty;
        [Required] public string Birth { get; set; } = string.Empty;
        public bool Check1 { get; set; } = false;
        [Required] public bool Check2 { get; set; }
        [Required] public bool Check3 { get; set; }
        [Required] public bool Check4 { get; set; }
        [Required] public bool Check5 { get; set; }
        [Required] public bool Check6 { get; set; }
        [Required] public bool Check7 { get; set; }
        public bool Check8 { get; set; }
        



    }
}
