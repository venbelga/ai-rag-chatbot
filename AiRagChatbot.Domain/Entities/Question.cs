namespace AiRagChatbot.Domain.Entities
{
    public class Question
    {
        public string Text { get; private set; }
        public string ExpectedAnswer { get; private set; }

        public Question(string text, string expectedAnswer)
        {
            Text = text;
            ExpectedAnswer = expectedAnswer;
        }
    }
}
