namespace AiRagChatbot.Application.DTOs
{
    public class AnswerEvaluationRequest
    {
        public string Question { get; set; }
        public string ExpectedAnswer { get; set; }
        public string UserAnswer { get; set; }
    }
}
