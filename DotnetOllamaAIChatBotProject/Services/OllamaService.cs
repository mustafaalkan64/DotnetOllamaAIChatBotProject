using DotnetOllamaAIChatBotProject.Models;
using System.Text.Json;

namespace DotnetOllamaAIChatBotProject.Services
{
    // Services
    public class OllamaService(HttpClient httpClient)
    {
        public async Task<string> SendMessageAsync(string prompt)
        {
            var request = new OllamaChatRequest
            {
                Model = "llama3",
                Stream = false,
                Messages = new List<Message>
                {
                    new Message
                    {
                        Role = "user",
                        Content = prompt
                    }
                }
            };

            var response = await httpClient.PostAsJsonAsync("/api/chat", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<OllamaChatResponse>();
            return result?.Message.Content ?? "Yanıt alınamadı.";
        }

        private class OllamaResponse
        {
            public string response { get; set; }
        }
    }
}
