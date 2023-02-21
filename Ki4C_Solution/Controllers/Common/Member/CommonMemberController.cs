using DbManager;
using Ki4C_Solution.Models.Common;
using Ki4C_Solution.Models.Common.Member;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Ki4C_Solution.Controllers.Common.Member
{
    public class CommonMemberController : Controller
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;

        public CommonMemberController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MemberRegSubscription()
        {
            return View("../Common/Member/MemberRegSubscription");
        }
        public IActionResult MemberRegFinished()
        {
            return View("../Common/Member/MemberRegFinished");
        }
        public IActionResult TermsConditionsPrivacy()
        {
            return View("../Common/Member/TermsConditionsPrivacy");
        }
        [HttpGet]
        public IActionResult MemberReg()
        {
            return View("../Common/Member/MemberReg");
        }
        [HttpPost]
        public IActionResult MemberReg(MemberRegModel memberRegModel)
        {
            foreach (var modelState in ModelState.Values)
            {
                foreach (var error in modelState.Errors)
                {
                    Debug.WriteLine(error.ErrorMessage);
                }
            }

            if (ModelState.IsValid)
            {
            }
            try
            {
                DateTime dateTime= DateTime.Now;
                //20230215 patten DateTIme var

            DbManager.AspNetUser.Insert(
                    memberRegModel.Id,                  //id
                    memberRegModel.UserName,            //UserName
                    memberRegModel.UserName,            //NormalizedUserName
                    memberRegModel.Email,               //Email
                    "",                               //NormalizedEmail
                    false,                              //EmailConfirmed
                    memberRegModel.Password,            //PasswordHash
                    "",                               //SecurityStamp
                    "",                               //ConcurrencyStamp
                    memberRegModel.PhoneNumber,         //PhoneNumber
                    false,                               //PhoneNumberConfirmed
                    false,                              //TwoFactorEnabled
                    DateTimeOffset.Now.AddMinutes(10),            //LockoutEnd
                    false,                               //LockoutEnabled
                    0,                                  //AccessFailedCount
                    memberRegModel.CompanyName,         //CompanyName
                    memberRegModel.DepartmentName,      //DepartmentName
                    "신규회원",                         //CustomerClass
                    1,                                  //CountOfLogins
                    dateTime,      //FinalLogin
                    dateTime,      //SignUpTime
                    "5",                                //ActivityInformation
                    "없음"                              //DiagnosisEvalutionStatus
                    );
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return View("../Common/Member/MemberReg");
            }
            //회원가입 완료시
            return RedirectToAction("MemberRegFinished", "CommonMember");
        }

        private string TokenService(User user)
        {
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.Username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
