namespace AiRagChatbot.Application.Interfaces
{
    public interface ILLMService
    {
        Task<string> GenerateAsync(string question, List<string> context);
    }
}
