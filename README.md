# CleanArchMvc

Projeto didático desenvolvido no curso **Clean Architecture Essencial -
ASP.NET Core 5.0 e C#** com o formador **Macoratti**.

## Objetivo

Aprender e aplicar os conceitos de **Clean Architecture**, **DDD
(Domain-Driven Design)** e boas práticas de desenvolvimento em .NET,
estruturando um projeto em múltiplas camadas.

## Estrutura da Solução

A solução foi criada como **monólito modularizado** em 5 projetos:

-   **CleanArchMvc.Domain** → contém as entidades, interfaces,
    validações e regras de negócio\
-   **CleanArchMvc.Application** → casos de uso e orquestração da lógica
    de aplicação\
-   **CleanArchMvc.Infra.Data** → acesso a dados, repositórios e
    persistência\
-   **CleanArchMvc.Infra.IoC** → configuração de injeção de
    dependências\
-   **CleanArchMvc.WebUI** → interface com o usuário (API/Controllers)

## Progresso Atual

-   Criada a solução `CleanArchMvc`\
-   Adicionados os 5 projetos da solução\
-   Criadas as pastas dentro da camada Domain (`Entities`, `Interfaces`,
    `Validations`)\
-   Implementadas as entidades Category e Product (modelo anêmico
    inicial)\
-   Criadas as classes base `Entity` e `DomainExceptionValidation`\
-   Entidades Category e Product enriquecidas com validações de domínio\
-   Criadas as interfaces `ICategoryRepository` e `IProductRepository`
-   Adicionado os tests unitários para `Category` na camada Domain
-   Adicionado os tests unitários para `Product` na camada Domain

**Próximo passo:** fazer ajustes no modelo de ajustes Product e começar a trabalhar na camada de Infraestrutura 

## Tecnologias Utilizadas

-   .NET 5.0 / C#\
-   ASP.NET Core Web API\
-   Clean Architecture\
-   DDD (Domain-Driven Design)

## Estrutura de Pastas (Domain)

    CleanArchMvc.Domain/
        Entities/ 
            Category.cs
            Product.cs
            Entity.cs
        Interfaces/ 
             ICategoryRepository
             IProductRepository
        Validations/ 
            DomainExceptionValidation.cs

## Como executar o projeto

``` bash
# Restaurar pacotes
dotnet restore

# Compilar a solução
dotnet build
```

## Convenções de Commit

-   feat: nova funcionalidade\
-   fix: correção de bug\
-   chore: manutenção/configuração (ex.: gitignore)\
-   docs: mudanças na documentação (ex.: README)\
-   test: criação ou atualização de testes\
-   refactor: refatoração sem alterar comportamento

## Autor

**Heldemilde João**
