using Microsoft.AspNetCore.Mvc;
using DbManager;
using Ki4C_Solution.Models;

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

        [HttpPost("DiagnosisType/insert")]
        public async Task<IActionResult> InsertDiagnosisType(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisType diagnosisType)
        {
            var result = await DbManager.DiagnosisType.InsertAsync(diagnosisType.DiagnosisTypeCode,diagnosisType.DiagnosisTypeName);
            return Json(result);
        }

        [HttpPost("DiagnosisType/update")]
        public async Task<IActionResult> UpdateDiagnosisType(DiagnosisType diagnosisType)
        {
            var result = await DbManager.DiagnosisType.UpdateAsync(diagnosisType.DiagnosisTypeNumber,diagnosisType.DiagnosisTypeCode, diagnosisType.DiagnosisTypeName);
            return Json(result);
        }

        [HttpPost("DiagnosisType/delete")]
        public async Task<IActionResult> DeleteDiagnosisType(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisType diagnosisType)
        {
            var result = 0;
            //foreach (var item in diagnosisType)
            //{
            //    result += await DbManager.DiagnosisType.DeleteAsync(item.DiagnosisTypeNumber);
            //}
            result = await DbManager.DiagnosisType.DeleteAsync(diagnosisType.DiagnosisTypeNumber);
            return Json(result);
        }


    }
}
