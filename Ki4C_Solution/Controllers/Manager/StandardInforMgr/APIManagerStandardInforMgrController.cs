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
        public async Task<IActionResult> UpdateDiagnosisType(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisType diagnosisType)
        {
            var result = await DbManager.DiagnosisType.UpdateAsync(diagnosisType.DiagnosisTypeNumber,diagnosisType.DiagnosisTypeCode, diagnosisType.DiagnosisTypeName);
            return Json(result);
        }

        [HttpDelete("DiagnosisType/delete")]
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

        [HttpDelete("DiagnosisClass/delete")]
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

        [HttpDelete("DiagnosisEvaluationArea/delete")]
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
            var result = await DbManager.EvaluationQuestion.InsertAsync(diagnosisEvaluationQuestion.DiagnosisEvaluationAreaNumber, diagnosisEvaluationQuestion.EvaluationQuestionCode, diagnosisEvaluationQuestion.EvaluationQuestionContents);
            return Json(result);
        }

        [HttpPut("DiagnosisEvaluationQuestion/update")]
        public async Task<IActionResult> UpdateDiagnosisEvaluationQuestion(Ki4C_Solution.Models.Manager.StandardInfoMgr.EvaluationQuestion diagnosisEvaluationQuestion)
        {
            var result = await DbManager.EvaluationQuestion.UpdateAsync(diagnosisEvaluationQuestion.EvaluationQuestionNumber, diagnosisEvaluationQuestion.DiagnosisEvaluationAreaNumber, diagnosisEvaluationQuestion.EvaluationQuestionCode, diagnosisEvaluationQuestion.EvaluationQuestionContents);
            return Json(result);
        }

        [HttpDelete("DiagnosisEvaluationQuestion/delete")]
        public async Task<IActionResult> DeleteDiagnosisEvaluationQuestion(Ki4C_Solution.Models.Manager.StandardInfoMgr.EvaluationQuestion diagnosisEvaluationQuestion)
        {
            var result = 0;
            result = await DbManager.EvaluationQuestion.DeleteAsync(diagnosisEvaluationQuestion.EvaluationQuestionNumber);
            return Json(result);
        }

        //API - InputType - getAll
        [HttpGet("InputType/getAll")]
        public async Task<IActionResult> GetAllInputType()
        {
            var result = await DbManager.InputType.GetAllJsonAsync();
            return Json(result);
        }

        [HttpPost("InputType/insert")]
        public async Task<IActionResult> InsertInputType(Ki4C_Solution.Models.Manager.StandardInfoMgr.InputType inputType)
        {
            var result = await DbManager.InputType.InsertAsync(inputType.InputTypeCode, inputType.InputTypeName);
            return Json(result);
        }

        [HttpPut("InputType/update")]
        public async Task<IActionResult> UpdateInputType(Ki4C_Solution.Models.Manager.StandardInfoMgr.InputType inputType)
        {
            var result = await DbManager.InputType.UpdateAsync(inputType.InputTypeNumber, inputType.InputTypeCode, inputType.InputTypeName);
            return Json(result);
        }

        [HttpDelete("InputType/delete")]
        public async Task<IActionResult> DeleteInputType(Ki4C_Solution.Models.Manager.StandardInfoMgr.InputType inputType)
        {
            var result = 0;
            result = await DbManager.InputType.DeleteAsync(inputType.InputTypeNumber);
            return Json(result);
        }

        //API - Measurement - getAll
        [HttpGet("Measurement/getAll")]
        public async Task<IActionResult> GetAllMeasurement()
        {
            var result = await DbManager.Measurement.GetAllJsonAsync();
            return Json(result);
        }

        [HttpPost("Measurement/insert")]
        public async Task<IActionResult> InsertMeasurement(Ki4C_Solution.Models.Manager.StandardInfoMgr.Measurement measurement)
        {
            var result = await DbManager.Measurement.InsertAsync(measurement.MeasurementCode, measurement.MeasurementName);
            return Json(result);
        }

        [HttpPut("Measurement/update")]
        public async Task<IActionResult> UpdateMeasurement(Ki4C_Solution.Models.Manager.StandardInfoMgr.Measurement measurement)
        {
            var result = await DbManager.Measurement.UpdateAsync(measurement.MeasurementNumber, measurement.MeasurementCode, measurement.MeasurementName);
            return Json(result);
        }

        [HttpDelete("Measurement/delete")]
        public async Task<IActionResult> DeleteMeasurement(Ki4C_Solution.Models.Manager.StandardInfoMgr.Measurement measurement)
        {
            var result = 0;
            result = await DbManager.Measurement.DeleteAsync(measurement.MeasurementNumber);
            return Json(result);
        }

        //API - DiagnosisLevel - getAll
        [HttpGet("DiagnosisLevel/getAll")]
        public async Task<IActionResult> GetAllDiagnosisLevel()
        {
            var result = await DbManager.DiagnosisLevel.GetAllJsonAsync();
            return Json(result);
        }

        [HttpPost("DiagnosisLevel/insert")]
        public async Task<IActionResult> InsertDiagnosisLevel(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisLevel diagnosisLevel)
        {
            var result = await DbManager.DiagnosisLevel.InsertAsync(diagnosisLevel.DiagnosisLevelCode, diagnosisLevel.DiagnosisLevelName);
            return Json(result);
        }

        [HttpPut("DiagnosisLevel/update")]
        public async Task<IActionResult> UpdateDiagnosisLevel(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisLevel diagnosisLevel)
        {
            var result = await DbManager.DiagnosisLevel.UpdateAsync(diagnosisLevel.DiagnosisLevelNumber, diagnosisLevel.DiagnosisLevelCode, diagnosisLevel.DiagnosisLevelName);
            return Json(result);
        }

        [HttpDelete("DiagnosisLevel/delete")]
        public async Task<IActionResult> DeleteDiagnosisLevel(Ki4C_Solution.Models.Manager.StandardInfoMgr.DiagnosisLevel diagnosisLevel)
        {
            var result = 0;
            result = await DbManager.DiagnosisLevel.DeleteAsync(diagnosisLevel.DiagnosisLevelNumber);
            return Json(result);
        }



    }
}
