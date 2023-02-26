using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ki4C_Solution.Controllers
{
    public class BaseController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (_httpContextAccessor.HttpContext.Session.GetString("UserId") == null)
            {
                // Redirect to the login page if the session is not valid
                context.Result = RedirectToAction("Login", "CommonAuth");
            }

            base.OnActionExecuting(context);
        }

    }
}
