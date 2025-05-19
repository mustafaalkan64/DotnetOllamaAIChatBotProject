# 🧠 Dotnet Ollama AI ChatBot Project

An AI-powered chatbot web application built using **ASP.NET Core (.NET 9) Web API** and **Ollama** for local large language models (LLMs). Supports real-time streaming, Docker deployment, and `.zip` export of chat history.

---

## 🚀 Features

- ✅ Chat with local LLMs via **Ollama** (e.g., `llama3`, `mistral`, etc.)
- 🔁 **Real-time streaming** support with Server-Sent Events (SSE)
- 📦 Export chats as `.zip` with full transcript and metadata
- 🐳 **Docker-ready** for easy containerized deployment
- 📜 Clean, extensible architecture with modern .NET 9 practices

---

## 🛠️ Tech Stack

| Layer      | Technology                          |
|------------|-----------------------------------|
| Backend    | ASP.NET Core (.NET 9) Web API      |
| AI Model   | [Ollama](https://ollama.com)       |
| Streaming  | Server-Sent Events (SSE)           |
| Deployment | Docker                            |

---

## ⚙️ Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Ollama](https://ollama.com) installed and running locally
- Docker (optional for containerized deployment)

After installing Ollama locally, please run:

```bash
ollama run llama3
```

## 🔧 Run Locally

```bash
git clone https://github.com/mustafaalkan64/DotnetOllamaAIChatBotProject.git
cd DotnetOllamaAIChatBotProject
dotnet run --project src/DotnetOllamaAIChatBotProject
```

## 📡 Example: Call the API with curl
```bash
curl http://localhost:5000/api/chat/ask \
  -H "Content-Type: application/json" \
  -d '{
    "model": "llama3",
    "messages": [
      {
        "role": "user",
        "content": "Explain quantum computing simply."
      }
    ],
    "stream": true
  }'
```

🖥️ API Preview
![Screenshot](https://raw.githubusercontent.com/mustafaalkan64/DotnetOllamaAIChatBotProject/master/ApiScreenshot.png)
