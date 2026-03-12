namespace AiRagChatbot.Application.DTOs
{
    public class AnswerEvaluationResponse
    {
        public double Score { get; set; }
        public bool IsCorrect { get; set; }
        public string Feedback { get; set; }
    }
}
