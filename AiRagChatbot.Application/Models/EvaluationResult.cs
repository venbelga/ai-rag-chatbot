namespace AiRagChatbot.Application.Models
{
    public class EvaluationResult
    {
        public bool IsFaithful { get; set; }
        public bool IsRelevant { get; set; }
        public double ConfidenceScore { get; set; }
        public string? Observations { get; set; }
    }
}
