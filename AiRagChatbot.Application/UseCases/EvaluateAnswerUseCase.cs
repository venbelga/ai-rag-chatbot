using AiRagChatbot.Domain.Evolution;

namespace AiRagChatbot.Application.UseCases
{
    public class EvaluateAnswerUseCase
    {
        private readonly IAnswerEvaluator _evaluator;

        public EvaluateAnswerUseCase(IAnswerEvaluator evaluator)
        {
            _evaluator = evaluator;
        }

        public EvaluationResult Execute(string correctAnswer, string studentAnswer)
        {
            return _evaluator.Evaluate(correctAnswer, studentAnswer);
        }
    }
}
