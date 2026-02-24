namespace AiRagChatbot.Domain.ValueObjects
{
    public class SimilarityThreshold
    {        public double Value { get; }

        public SimilarityThreshold(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentOutOfRangeException(nameof(value));

            Value = value;
        }
    }
}
