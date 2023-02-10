using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Member.Diagnosis
{
    public class MemberDiagnosisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //CompanyBasicInformation
        public IActionResult CompanyBasicInformation()
        {
            return View("../Member/Diagnosis/CompanyBasicInformation");
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
