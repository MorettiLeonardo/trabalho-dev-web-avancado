# API REST - Trabalho Dev Web Avancado

Projeto de API REST com ASP.NET Core, Entity Framework Core, MySQL, Swagger e CORS.

## Requisitos para rodar

- Windows/Linux/Mac com terminal
- .NET SDK 8 instalado
- XAMPP instalado
  - Apache iniciado
  - MySQL iniciado

## Tecnologias usadas

- ASP.NET Core Web API (.NET 8)
- Entity Framework Core 8
- Pomelo EntityFrameworkCore MySQL
- Swagger (Swashbuckle)

## Configuracao do banco

Edite os arquivos:

- `appsettings.json`
- `appsettings.Development.json`

Use uma connection string valida para seu XAMPP/MySQL:

```json
"ConnectionStrings": {
  "ConnPadrao": "Server=localhost;Port=3306;Database=banco;User=root;Password=;SslMode=None"
}
```

Se sua porta for diferente (ex.: `3307`) ou tiver senha no `root`, ajuste os valores.

## Ferramenta de Migrations

Instalar ferramenta global `dotnet-ef`:

```bash
dotnet tool install --global dotnet-ef
```

Se ja instalada, atualizar:

```bash
dotnet tool update --global dotnet-ef
```

## Como rodar o projeto

Na pasta do projeto:

```bash
dotnet restore
dotnet build
dotnet run
```

Swagger:

- `http://localhost:5161/swagger`

## Como rodar migrations

Criar a primeira migration:

```bash
dotnet ef migrations add {nomeMigration}
```

Aplicar ao banco de dados:

```bash
dotnet ef database update
```

Exemplo:

```bash
dotnet ef migrations add Inicial
dotnet ef database update
```

## Endpoints principais

- `api/produtos`
- `api/categorias`
- `api/clientes`

Todos com CRUD completo (`GET`, `GET por id`, `POST`, `PUT`, `DELETE`).

## Possiveis erros comuns

- `Unknown database 'banco'`
  - Crie o banco manualmente no phpMyAdmin ou rode `dotnet ef database update`.
- `Access denied for user 'root'`
  - Verifique usuario/senha na connection string.
- `Host 'NOME-DO-PC' is not allowed to connect`
  - Ajuste permissoes do usuario no MySQL/MariaDB.
