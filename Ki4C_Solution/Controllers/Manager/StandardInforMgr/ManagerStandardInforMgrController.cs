using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Manager.StandardInforMgr
{
    public class ManagerStandardInforMgrController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
    }
}
