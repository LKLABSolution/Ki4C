using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Manager.StandardInforMgr
{
    public class ManagerStandardInforMgrController : BaseController
    {
        public ManagerStandardInforMgrController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        //DiagnosisClass
        public IActionResult DiagnosisClass()
        {
            return View("../Manager/StandardInforMgr/DiagnosisClass");
        }
        public IActionResult DiagnosisEvaluationArea()
        {
            return View("../Manager/StandardInforMgr/DiagnosisEvaluationArea");
        }
        public IActionResult DiagnosisEvaluationMeasurement()
        {
            return View("../Manager/StandardInforMgr/DiagnosisEvaluationMeasurement");
        }
        public IActionResult DiagnosisEvaluationQnA()
        {
            return View("../Manager/StandardInforMgr/DiagnosisEvaluationQnA");
        }
        public IActionResult DiagnosisInputType()
        {
            return View("../Manager/StandardInforMgr/DiagnosisInputType");
        }
        public IActionResult DiagnosisType()
        {
            return View("../Manager/StandardInforMgr/DiagnosisType");
        }
        public IActionResult DiagnosticLevel()
        {
            return View("../Manager/StandardInforMgr/DiagnosticLevel");
        }
        public IActionResult QnADetails()
        {
            return View("../Manager/StandardInforMgr/QnADetails");
        }

        //DiagnosisType.getAll - Get acync
        public async Task<IActionResult> GetAllDiagnosisType()
        {
            var result = await DbManager.DiagnosisType.GetAllJsonAsync();
            return Json(result);
        }


    }
}
