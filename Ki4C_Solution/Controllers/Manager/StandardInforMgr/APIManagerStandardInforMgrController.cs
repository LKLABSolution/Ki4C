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

        [HttpPut("DiagnosisType/update")]
        public async Task<IActionResult> UpdateDiagnosisType(DiagnosisType diagnosisType)
        {
            var result = await DbManager.DiagnosisType.UpdateAsync(diagnosisType.DiagnosisTypeNumber,diagnosisType.DiagnosisTypeCode, diagnosisType.DiagnosisTypeName);
            return Json(result);
        }

        [HttpPost("DiagnosisType/delete")]
        public async Task<IActionResult> DeleteDiagnosisType(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisType diagnosisType)
        {
            var result = 0;
            result = await DbManager.DiagnosisType.DeleteAsync(diagnosisType.DiagnosisTypeNumber);
            return Json(result);
        }

        //API - DiagnosisClass - getAll
        [HttpGet("DiagnosisClass/getAll")]
        public async Task<IActionResult> GetAllDiagnosisClass()
        {
            var result = await DbManager.DiagnosisClass.GetAllJsonAsync();
            return Json(result);
        }

        [HttpPost("DiagnosisClass/insert")]
        public async Task<IActionResult> InsertDiagnosisClass(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisClass diagnosisClass)
        {
            var result = await DbManager.DiagnosisClass.InsertAsync(diagnosisClass.DiagnosisTypeNumber,diagnosisClass.DiagnosisClassCode, diagnosisClass.DiagnosisClassName);
            return Json(result);
        }

        [HttpPut("DiagnosisClass/update")]
        public async Task<IActionResult> UpdateDiagnosisClass(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisClass diagnosisClass)
        {
            var result = await DbManager.DiagnosisClass.UpdateAsync(diagnosisClass.DiagnosisClassNumber,diagnosisClass.DiagnosisTypeNumber, diagnosisClass.DiagnosisClassCode, diagnosisClass.DiagnosisClassName);
            return Json(result);
        }

        [HttpPost("DiagnosisClass/delete")]
        public async Task<IActionResult> DeleteDiagnosisClass(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisClass diagnosisClass)
        {
            var result = 0;
            result = await DbManager.DiagnosisClass.DeleteAsync(diagnosisClass.DiagnosisClassNumber);
            return Json(result);
        }

        //API - DiagnosisEvaluationArea - getAll
        [HttpGet("DiagnosisEvaluationArea/getAll")]
        public async Task<IActionResult> GetAllDiagnosisEvaluationArea()
        {
            var result = await DbManager.EvaluationAreaNumber.GetAllJsonAsync();
            return Json(result);
        }

        [HttpPost("DiagnosisEvaluationArea/insert")]
        public async Task<IActionResult> InsertDiagnosisEvaluationArea(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisEvaluationArea diagnosisEvaluationArea)
        {
            var result = await DbManager.EvaluationAreaNumber.InsertAsync(diagnosisEvaluationArea.DiagnosisClassNumber, diagnosisEvaluationArea.DiagnosisEvaluationAreaCode, diagnosisEvaluationArea.DiagnosisEvaluationAreaName);
            return Json(result);
        }

        [HttpPut("DiagnosisEvaluationArea/update")]
        public async Task<IActionResult> UpdateDiagnosisEvaluationArea(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisEvaluationArea diagnosisEvaluationArea)
        {
            var result = await DbManager.EvaluationAreaNumber.UpdateAsync(diagnosisEvaluationArea.DiagnosisEvaluationAreaNumber, diagnosisEvaluationArea.DiagnosisClassNumber, diagnosisEvaluationArea.DiagnosisEvaluationAreaCode, diagnosisEvaluationArea.DiagnosisEvaluationAreaName);
            return Json(result);
        }

        [HttpPost("DiagnosisEvaluationArea/delete")]
        public async Task<IActionResult> DeleteDiagnosisEvaluationArea(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisEvaluationArea diagnosisEvaluationArea)
        {
            var result = 0;
            result = await DbManager.EvaluationAreaNumber.DeleteAsync(diagnosisEvaluationArea.DiagnosisEvaluationAreaNumber);
            return Json(result);
        }

        //API - DiagnosisEvaluationQuestion - getAll
        [HttpGet("DiagnosisEvaluationQuestion/getAll")]
        public async Task<IActionResult> GetAllDiagnosisEvaluationQuestion()
        {
            var result = await DbManager.EvaluationQuestion.GetAllJsonAsync();
            return Json(result);
        }

        [HttpPost("DiagnosisEvaluationQuestion/insert")]
        public async Task<IActionResult> InsertDiagnosisEvaluationQuestion(Ki4C_Solution.Models.Manager.StandardInfoMgr.EvaluationQuestion diagnosisEvaluationQuestion)
        {
            var result = await DbManager.EvaluationQuestion.InsertAsync(diagnosisEvaluationQuestion.AreaNumber, diagnosisEvaluationQuestion.EvaluationQuestionCode, diagnosisEvaluationQuestion.EvaluationQuestionContents);
            return Json(result);
        }

        [HttpPut("DiagnosisEvaluationQuestion/update")]
        public async Task<IActionResult> UpdateDiagnosisEvaluationQuestion(Ki4C_Solution.Models.Manager.StandardInfoMgr.EvaluationQuestion diagnosisEvaluationQuestion)
        {
            var result = await DbManager.EvaluationQuestion.UpdateAsync(diagnosisEvaluationQuestion.EvaluationQuestionNumber, diagnosisEvaluationQuestion.AreaNumber, diagnosisEvaluationQuestion.EvaluationQuestionCode, diagnosisEvaluationQuestion.EvaluationQuestionContents);
            return Json(result);
        }

        [HttpPost("DiagnosisEvaluationQuestion/delete")]
        public async Task<IActionResult> DeleteDiagnosisEvaluationQuestion(Ki4C_Solution.Models.Manager.StandardInfoMgr.EvaluationQuestion diagnosisEvaluationQuestion)
        {
            var result = 0;
            result = await DbManager.EvaluationQuestion.DeleteAsync(diagnosisEvaluationQuestion.EvaluationQuestionNumber);
            return Json(result);
        }


    }
}
