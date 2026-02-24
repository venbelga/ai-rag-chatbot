namespace AiRagChatbot.Domain.Evolution
{
    public interface IAnswerEvaluator
    {
        EvaluationResult Evaluate(string correctAnswer, string studentAnswer);
    }
}
