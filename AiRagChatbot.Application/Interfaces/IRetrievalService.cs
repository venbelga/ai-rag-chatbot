namespace AiRagChatbot.Application.Interfaces
{
    public interface IRetrievalService
    {
        Task<List<string>> RetrieveAsync(string question);
    }
}
