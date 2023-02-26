using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Manager.Member
{
    public class ManagerMemberController : BaseController
    {
        public ManagerMemberController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public IActionResult MemberList()
        {
            return View("../Manager/Member/MemberList");
        }
        public IActionResult MemberDetailView()
        {
            return View("../Manager/Member/MemberDetailView");
        }
    }
}
