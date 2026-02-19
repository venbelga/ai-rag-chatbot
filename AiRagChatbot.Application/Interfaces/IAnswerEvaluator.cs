using AiRagChatbot.Application.Models;

namespace AiRagChatbot.Application.Interfaces
{
    public interface IAnswerEvaluator
    {
        EvaluationResult Evaluate(string question, List<string> context, string response);
    }
}
