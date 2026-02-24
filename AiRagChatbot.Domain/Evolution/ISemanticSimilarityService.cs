namespace AiRagChatbot.Domain.Evolution
{
    public interface ISemanticSimilarityService
    {
        double CalculateSimilarity(string text1, string text2);
    }
}
