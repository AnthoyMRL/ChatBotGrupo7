namespace ChatBotGrupo7.Interface
{
    public interface IChatBotService
    {
        public Task<string> GetChatbotResponseAsync(string prompt);
    }
}
