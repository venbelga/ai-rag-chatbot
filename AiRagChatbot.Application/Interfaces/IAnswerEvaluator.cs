using AiRagChatbot.Application.DTOs;

namespace AiRagChatbot.Application.Interfaces
{
    public interface IAnswerEvaluator
    {
        AnswerEvaluationResponse Evaluate(AnswerEvaluationRequest request);
    }
}
