namespace AiRagChatbot.Application.Interfaces
{
    public interface IAnswerValidator
    {
        bool Validate(string response, List<string> context);
    }
}
