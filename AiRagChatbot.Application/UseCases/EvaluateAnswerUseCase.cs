using AiRagChatbot.Application.DTOs;
using AiRagChatbot.Application.Interfaces;
namespace AiRagChatbot.Application.UseCases
{
    public class EvaluateAnswerUseCase : IAnswerEvaluator
    {
        private readonly ISemanticSimilarityService _similarityService;

        public EvaluateAnswerUseCase(ISemanticSimilarityService similarityService)
        {
            _similarityService = similarityService;
        }

        public AnswerEvaluationResponse Evaluate(AnswerEvaluationRequest request)
        {
            var score = _similarityService.CalculateSimilarity(
                request.ExpectedAnswer,
                request.UserAnswer
            );

            return new AnswerEvaluationResponse
            {
                Score = score,
                IsCorrect = score >= 0.7,
                Feedback = score >= 0.7
                    ? "Resposta semanticamente correta."
                    : "Resposta distante da esperada."
            };
        }
    }
}
