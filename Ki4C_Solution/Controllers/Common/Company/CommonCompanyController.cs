using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Common.Company
{
    public class CommonCompanyController : BaseController
    {
        public CommonCompanyController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public IActionResult Greetings()
        {
            return View("../Common/Company/Greetings");
        }
        public IActionResult IntroductionDX()
        {
            return View("../Common/Company/IntroductionDX");
        }
        public IActionResult OnTheWay()
        {
            return View("../Common/Company/OnTheWay");
        }

        /// <summary>
        /// 추후 로직추가시 활용
        /// </summary>
        /// <returns></returns>
        /// 
        public IActionResult CompanyReg()
        {
            return View("../Common/Company/CompanyReg");
        }
        public IActionResult CompanyRegFinished()
        {
            return View("../Common/Company/CompanyRegFinished");
        }
        public IActionResult CompanyRegSubscription()
        {
            return View("../Common/Company/CompanyRegSubscription");
        }
        
        
    }
}
