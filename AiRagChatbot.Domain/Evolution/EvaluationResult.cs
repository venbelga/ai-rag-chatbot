namespace AiRagChatbot.Domain.Evolution
{
    public class EvaluationResult
    {
        public bool IsCorrect { get; }
        public string Feedback { get; }
        public double Score { get; }

        private EvaluationResult(bool isCorrect, string feedback, double score)
        {
            IsCorrect = isCorrect;
            Feedback = feedback;
            Score = score;
        }

        public static EvaluationResult Success(string feedback, double score = 1.0)
            => new EvaluationResult(true, feedback, score);

        public static EvaluationResult Failure(string feedback, double score = 0.0)
            => new EvaluationResult(false, feedback, score);
    }
}
