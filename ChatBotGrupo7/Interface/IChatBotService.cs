namespace ChatBotGrupo7.Interface
{
    public interface IChatBotService
    {
        public Task<string> GetChatbotResponse(string prompt);
        public Task<Boolean> SaveResponseInDatabase(string response);
    }
}
