# CleanArchMvc

Projeto didático desenvolvido no curso **Clean Architecture Essencial - ASP.NET Core 5.0 e C#** com o formador **Macoratti**.

## 🎯 Objetivo
Aprender e aplicar os conceitos de **Clean Architecture**, **DDD (Domain-Driven Design)** e boas práticas de desenvolvimento em .NET, estruturando um projeto em múltiplas camadas.

## 🏗️ Estrutura da Solução

A solução foi criada como **monólito modularizado** em 5 projetos:

- **CleanArchMvc.Domain** → Contém as entidades, interfaces, validações e regras de negócio.  
- **CleanArchMvc.Application** → Casos de uso e orquestração da lógica de aplicação.  
- **CleanArchMvc.Infra.Data** → Acesso a dados, repositórios e persistência.  
- **CleanArchMvc.Infra.IoC** → Configuração de injeção de dependências.  
- **CleanArchMvc.WebUI** → Interface com o usuário (API/Controllers).

## 📌 Progresso Atual
- [x] Criada a **solução vazia** `CleanArchMvc`.  
- [x] Adicionados os **5 projetos** da solução.  
- [x] Criadas as **pastas** dentro da camada Domain:  
  - `Entities/` → classes **Category** e **Product** (modelo anêmico inicial).  
  - `Interfaces/`  
  - `Validations/`  

➡️ **Próximo passo**: enriquecer os modelos `Category` e `Product` com invariantes e validações.

## ⚙️ Tecnologias Utilizadas
- .NET 5.0 / C#  
- ASP.NET Core Web API  
- Clean Architecture  
- DDD (Domain-Driven Design)

## 📂 Estrutura de Pastas (Domain)
```
CleanArchMvc.Domain/
 ├── Entities/
 │    ├── Category.cs
 │    └── Product.cs
 ├── Interfaces/
 └── Validations/
```

## 🚀 Como executar o projeto
```bash
# Restaurar pacotes
dotnet restore

# Compilar a solução
dotnet build

# Executar o projeto WebUI
dotnet run --project CleanArchMvc.WebUI
```

## 📖 Convenções de Commit
- `feat:` → nova funcionalidade  
- `fix:` → correção de bug  
- `chore:` → manutenção/configuração (ex.: criar solução, gitignore)  
- `docs:` → mudanças na documentação (ex.: README)  
- `test:` → criação ou atualização de testes  
- `refactor:` → refatoração sem alterar comportamento  

## 👨‍💻 Autor
- **Heldemilde João**
