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

## 📸 UI Preview

> 📷 _Add screenshots here for better visual reference._

---

## ⚙️ Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Ollama](https://ollama.com) installed and running locally
- Docker (optional for containerized deployment)
- After you installed ollama on your local, please run: **ollama run llama3** and you must install llama3 llm model.

---

### 🔧 Run Locally

1. **Clone the repo**
   ```bash
   git clone https://github.com/mustafaalkan64/DotnetOllamaAIChatBotProject.git
   cd DotnetOllamaAIChatBotProject
