using ChatBotGrupo7.Interface;

namespace ChatBotGrupo7.Repository
{
    public class GeminiRepository : IChatBotService
    {
        private HttpClient _httpClient;
        private string geminiApiKey = "AIzaSyATksFNyjGqbmkp3WXQTmBEvJYe_gKpLrg"

        public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }

        public Task<string> GetChatbotResponse(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" +geminiApiKey;
        }

        public Task<bool> SaveResponseInDatabase(string response)
        {
            throw new NotImplementedException();
        }
    }


}
