# 🧠 Dotnet Ollama AI ChatBot Project

An AI-powered chatbot web application built using **ASP.NET Core (.NET 9) Web Api**, and **Ollama** for local large language models (LLMs). Supports real-time streaming, Docker deployment, and `.zip` export of chat history.

---

## 🚀 Features

- ✅ Chat with local LLMs via **Ollama** (e.g., `llama3`, `mistral`, etc.)
- 🔁 **Real-time streaming** support with Server-Sent Events (SSE)
- 📦 Export chats as `.zip` with full transcript and metadata
- 🐳 **Docker-ready** for easy containerized deployment
- 📜 Clean, extensible architecture with modern .NET 9 practices

---

## 🛠️ Tech Stack

| Layer         | Technology                            |
|---------------|----------------------------------------|
| Backend       | ASP.NET Core (.NET 9) Web API          |
| AI Model      | [Ollama](https://ollama.com)           |
| Streaming     | Server-Sent Events (SSE)               |
| Deployment    | Docker                                 |

---


## ⚙️ Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Ollama](https://ollama.com) installed and running locally
- Docker (optional for containerized deployment)
- After you installed ollama on your local, please run: **ollama run llama3** and you must install llama3 llm model.

---

### 🔧 Run Locally

**Clone the repo**
   ```bash
   git clone https://github.com/mustafaalkan64/DotnetOllamaAIChatBotProject.git
   cd DotnetOllamaAIChatBotProject

### 📡 Example: Call the API with `curl`

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

### 🖥️ Api Preview

![Screenshot](https://raw.githubusercontent.com/mustafaalkan64/DotnetOllamaAIChatBotProject/master/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-05-19%20000631.png)
