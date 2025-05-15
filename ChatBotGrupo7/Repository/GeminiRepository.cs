using System.Text;
using ChatBotGrupo7.Interface;
using ChatBotGrupo7.Models;
using Newtonsoft.Json;

namespace ChatBotGrupo7.Repository
{
    public class GeminiRepository : IChatBotService
    {
        private HttpClient _httpClient;
        private string geminiApiKey = "AIzaSyATksFNyjGqbmkp3WXQTmBEvJYe_gKpLrg";

        public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetChatbotResponse(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" +geminiApiKey;
            
            GeminiRequest request = new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts = new List<GeminiPart>
                        {
                            new GeminiPart
                            {
                                text = prompt
                            }
                        }
                    }
                }
            };

            string requestJson = JsonConvert.SerializeObject(request);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            
            var response = await _httpClient.PostAsync(url, content);
            

            var answer = await response.Content.ReadAsStringAsync();

            return answer;
        }

        public Task<bool> SaveResponseInDatabase(string response)
        {
            throw new NotImplementedException();
        }
    }


}
