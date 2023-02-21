﻿using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Manager.Diagnosis
{
    public class ManagerDiagnosisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //DiagnosisEvaluationMgrList
        public IActionResult DiagnosisEvaluationMgrList()
        {
            return View("../Manager/Diagnosis/DiagnosisEvaluationMgrList");
        }
        //DiagnosisMgrList
        public IActionResult DiagnosisMgrList()
        {
            return View("../Manager/Diagnosis/DiagnosisMgrList");
        }
    }
}
