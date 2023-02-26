using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Member.Diagnosis
{
    public class MemberDiagnosisController : BaseController
    {
        public MemberDiagnosisController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        //Application4Evaluation
        public IActionResult Application4Evaluation()
        {
            return View("../Member/Diagnosis/Application4Evaluation");
        }

        //CompanyBasicInformation
        public IActionResult CompanyBasicInformation()
        {
            return View("../Member/Diagnosis/CompanyBasicInformation");
        }
        //DiagnosisFinished
        public IActionResult DiagnosisFinished()
        {
            return View("../Member/Diagnosis/DiagnosisFinished");
        }
        //DiagnosisEvaluationList
        public IActionResult DiagnosisEvaluationList()
        {
            return View("../Member/Diagnosis/DiagnosisEvaluationList");
        }
        //ExpertDiagnosis
        public IActionResult ExpertDiagnosis()
        {
            return View("../Member/Diagnosis/ExpertDiagnosis");
        }
        //ExpertDiagnosisQuestion
        public IActionResult ExpertDiagnosisQuestion()
        {
            return View("../Member/Diagnosis/ExpertDiagnosisQuestion");
        }
        //SelectedResultList
        public IActionResult SelectedResultList()
        {
            return View("../Member/Diagnosis/SelectedResultList");
        }

        //SelfDiagnosis
        public IActionResult SelfDiagnosis()
        {
            return View("../Member/Diagnosis/SelfDiagnosis");
        }
        //SelfDiagnosisQuestion
        public IActionResult SelfDiagnosisQuestion()
        {
            return View("../Member/Diagnosis/SelfDiagnosisQuestion");
        }
    }
}
