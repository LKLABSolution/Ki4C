using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Manager.StandardInforMgr
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIManagerStandardInforMgrController : BaseController
    {
        public APIManagerStandardInforMgrController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        //API - DiagnosisType - getAll
        [HttpGet("DiagnosisType/getAll")]
        public async Task<IActionResult> GetAllDiagnosisType()
        {
            var result = await DbManager.DiagnosisType.GetAllJsonAsync();
            return Json(result);
        }


    }
}
