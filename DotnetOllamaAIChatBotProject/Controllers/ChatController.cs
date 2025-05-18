using DotnetOllamaAIChatBotProject.Models;
using DotnetOllamaAIChatBotProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetOllamaAIChatBotProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatController(OllamaService ollamaService) : ControllerBase
{
    [HttpPost("ask")]
    public async Task<IActionResult> Ask([FromBody] ChatRequest request)
    {
        var response = await ollamaService.SendMessageAsync(request.Message);
        return Ok(response);
    }
}
