using AiRagChatbot.Application.Interfaces;

namespace AiRagChatbot.Infrastructure.Services
{
    public class SimpleSemanticSimilarityService : ISemanticSimilarityService
    {
        public double CalculateSimilarity(string text1, string text2)
        {
            var words1 = text1.ToLower().Split(' ');
            var words2 = text2.ToLower().Split(' ');

            var intersection = words1.Intersect(words2).Count();
            var union = words1.Union(words2).Count();

            if (union == 0)
                return 0;

            return (double)intersection / union;
        }
    }
