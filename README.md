# CleanArchMvc

Projeto desenvolvido com o objetivo de aplicar os conceitos de Clean Architecture, Domain-Driven Design (DDD) e boas práticas de desenvolvimento em ASP.NET Core.

## Descrição

O projeto consiste numa aplicação estruturada em camadas, seguindo os princípios da Clean Architecture, com separação clara de responsabilidades entre domínio, aplicação, infraestrutura e interface.

A solução evoluiu a partir de um modelo didático e foi aprimorada com a implementação de CQRS, MediatR, AutoMapper e boas práticas de organização de código.

## Estrutura da Solução

A solução está organizada em cinco projetos principais:

- CleanArchMvc.Domain: contém as entidades e regras de negócio do domínio
- CleanArchMvc.Application: contém os casos de uso, DTOs, comandos, consultas e handlers
- CleanArchMvc.Infra.Data: responsável pelo acesso a dados e implementação dos repositórios
- CleanArchMvc.Infra.IoC: configuração de injeção de dependência
- CleanArchMvc.API: camada de apresentação (controllers e endpoints)

## Funcionalidades implementadas

- Gestão de produtos
- Gestão de categorias
- Implementação de CQRS com MediatR
- Mapeamento de objetos com AutoMapper
- Validações de domínio e aplicação
- Separação de responsabilidades por camadas
- API REST estruturada
- Integração com base de dados relacional

## Tecnologias utilizadas

- ASP.NET Core Web API
- C#
- Entity Framework Core
- MediatR
- AutoMapper
- SQL Server
- Clean Architecture
- DDD (Domain-Driven Design)

## Status do projeto

Projeto concluído em termos de estrutura base e funcionalidades principais.

Próximos passos possíveis incluem:
- Implementação de autenticação com JWT


## Convenções de commit

- feat: nova funcionalidade
- fix: correção de erro
- refator: refatoração de código
- chore: manutenção de projeto
- docs: documentação

## Autor

Heldemilde João