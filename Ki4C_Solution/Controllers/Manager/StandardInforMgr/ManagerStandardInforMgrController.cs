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
        public IActionResult DiagnosisLevel()
        {
            return View("../Manager/StandardInforMgr/DiagnosisLevel");
        }
        public IActionResult QnADetails()
        {
            return PartialView("../Manager/StandardInforMgr/QnADetails");
        }

        public IActionResult QuestionDetails()
        {
            return PartialView("../Manager/StandardInforMgr/DiagnosisQuestionDetails");
        }
    }
}
