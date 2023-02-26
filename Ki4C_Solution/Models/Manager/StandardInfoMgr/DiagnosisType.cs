using System.ComponentModel.DataAnnotations;

namespace Ki4C_Solution.Models.Manager.StandardInfoMgr
{
    public class DiagnosisType
    {
        public int DiagnosisTypeNumber { get; set; }
        public string DiagnosisTypeCode { get; set; } = string.Empty;
        public string DiagnosisTypeName { get; set; } = string.Empty;

    }
}
