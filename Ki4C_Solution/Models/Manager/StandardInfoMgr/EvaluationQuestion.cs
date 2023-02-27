namespace Ki4C_Solution.Models.Manager.StandardInfoMgr
{
    public class EvaluationQuestion
    {
        public int EvaluationQuestionNumber { get; set; }
        public int AreaNumber { get; set; }
        public string EvaluationQuestionCode { get; set; } = string.Empty;
        public string EvaluationQuestionContents { get; set; } = string.Empty;
    }
}
