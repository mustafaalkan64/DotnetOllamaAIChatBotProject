using System.ComponentModel.DataAnnotations;

namespace DotnetOllamaAIChatBotProject.Models
{
    public class ChatRequest
    {
        [Required]
        public string Message { get; set; }
    }
}
