using Microsoft.AspNetCore.Mvc;
using Ki4C_Solution.Models.Common.Auth;
using DbManager;
using MemberRegModel = Ki4C_Solution.Models.Common.Member.MemberRegModel;
using Google.Protobuf.WellKnownTypes;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System;

namespace Ki4C_Solution.Controllers.Common.Auth
{
    public class CommonAuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //public CommonAuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IHttpContextAccessor httpContextAccessor)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //    _httpContextAccessor = httpContextAccessor;
        //}


        public IActionResult Login()
        {
            //html doc path : Views/Common/Auth/Login.cshtml
            return View("../Common/Auth/Login");
            //return View();
        }

        //method=post login email, password
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                DbManager.AspNetUser aspNetUser = DbManager.AspNetUser.GetByKey(loginModel.Id);
                if (aspNetUser != null)
                {
                    if (aspNetUser.PasswordHash.Equals(loginModel.Password))
                    {
                        List<Claim> claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.Name, loginModel.Id),
                            //new Claim(ClaimTypes.Email, loginModel.Email),
                            //new Claim(ClaimTypes.Role, "Admin"),
                            new Claim("OtherProperties","Example Role")
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        AuthenticationProperties authProperties = new AuthenticationProperties
                        {
                            AllowRefresh = true,
                            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                            IsPersistent = loginModel.KeepLoggedIn,
                        };
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                                                       , new ClaimsPrincipal(claimsIdentity), authProperties);

                        try
                        {
                            aspNetUser.LockoutEnd = DateTimeOffset.Now.AddMinutes(10);
                            aspNetUser.CountOfLogins = aspNetUser.CountOfLogins + 1;
                            aspNetUser.FinalLogin = DateTime.Today;

                            aspNetUser.Update();
                        }
                        catch (Exception ex)
                        {
                            ViewData["ValidateMessage"] = "로그인시 오류가 발생하였습니다. " + ex.Message;
                            return View("../Common/Auth/Login");
                        }

                        ViewData["ValidateMessage"] = aspNetUser.UserName+ " 고객님께서 " + DateTime.Now.ToString() + "에 접속하였습니다.";
                        return View("../Home/Index");
                    }
                    else
                    {
                        ViewData["ValidateMessage"] = "ID 또는 패스워드가 일치하지 않습니다.";
                        return View("../Common/Auth/Login");
                    }
                }
                else
                {
                    ViewData["ValidateMessage"] = "등록되지 않은 사용자 정보 입니다.";
                    return View("../Common/Auth/Login");
                }
            }
            catch (Exception ex)
            {
                ViewData["ValidateMessage"] = "로그인시 오류가 발생하였습니다.";
                ViewData["ExceptionObj"] = ex.ToString();
                return View("../Common/Auth/Login");
            }

        }

        public async Task<IActionResult> Login2(LoginModel loginModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(loginModel);
            //}

            DbManager.AspNetUser aspNetUser = DbManager.AspNetUser.GetByKey(loginModel.Id);
            var user = await _userManager.FindByIdAsync(loginModel.Id);

            if (user != null && await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("OtherProperties","Example Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    IsPersistent = loginModel.KeepLoggedIn,
                };

                await _signInManager.SignInAsync(user, authProperties);
                //await _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(loginModel);
            }
        }


        public IActionResult LogoutPage()
        {
            return View("../Common/Auth/Logout");
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "CommonAuth");
        }


        // Views/Common/Auth/FindIdInput
        public IActionResult FindIdInput()
        {
            return View("../Common/Auth/FindIdInput");
        }

        // Views/Common/Auth/FindIdResultView
        public IActionResult FindIdResultView()
        {
            return View("../Common/Auth/FindIdResultView");
        }

        // Views/Common/Auth/FindPassInput
        public IActionResult FindPassInput()
        {
            return View("../Common/Auth/FindPassInput");
        }

        // Views/Common/Auth/FindPassResultView
        public IActionResult FindPassResultView()
        {
            return View("../Common/Auth/FindPassResultView");
        }

        //Account create page
        public IActionResult CreateAccount()
        {
            return View("../Common/Auth/CreateAccount");
        }

    }
}
