using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiRagChatbot.Infrastructure.AI
{
    public class FakeSemanticSimilarityService
    {
        public double CalculateSimilarity(string text1, string text2)
        {
            if (text1 == text2)
                return 1.0;

            return 0.5;
        }
    }
}
