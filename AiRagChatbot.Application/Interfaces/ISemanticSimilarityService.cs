namespace AiRagChatbot.Application.Interfaces
{
    public interface ISemanticSimilarityService
    {
        double CalculateSimilarity(string text1, string text2);
    }
}
