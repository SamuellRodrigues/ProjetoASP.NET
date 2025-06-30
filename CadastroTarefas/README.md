# CadastroTarefas

API Web ASP.NET Core (.NET 8.0) para cadastro de tarefas (CRUD) usando Entity Framework Core com SQLite.

## Endpoints
- `GET /tarefas` — Lista todas as tarefas
- `GET /tarefas/{id}` — Busca uma tarefa por ID
- `POST /tarefas` — Cria uma nova tarefa
- `PUT /tarefas/{id}` — Atualiza uma tarefa existente
- `DELETE /tarefas/{id}` — Remove uma tarefa

## Como executar
1. Certifique-se de ter o .NET 8.0 SDK instalado.
2. Execute `dotnet build` para compilar o projeto.
3. Execute `dotnet run` para iniciar a API.
4. Acesse o Swagger em `http://localhost:5000/swagger` (ou porta exibida no terminal).

O banco de dados SQLite será criado automaticamente como `tarefas.db` na raiz do projeto.
