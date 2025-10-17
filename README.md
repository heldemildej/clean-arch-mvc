# CleanArchMvc

Projeto backend em .NET estruturado com Clean Architecture + DDD, organizado em 5 camadas:

Domain → Entidades, regras de negócio e validações (com testes de unidade)

Application → Casos de uso / serviços da aplicação

Infra.Data → Repositórios e persistência

Infra.IoC → Injeção de dependências

WebApi (a implementar) → Exposição via API + Autenticação JWT + Segurança

❌ Sem camada WebUI (MVC/Razor/Views) — o foco é backend puro, com domínio forte, testes e API segura.

Objetivo

Servir como base sólida para projetos backend profissionais, aplicando boas práticas, modelo de domínio rico, testes de unidade e segurança.

```
Convenção de Commits

feat • fix • docs • test • refactor • chore
```

## Convenções de Commit

-   feat: nova funcionalidade\
-   fix: correção de bug\
-   chore: manutenção/configuração (ex.: gitignore)\
-   docs: mudanças na documentação (ex.: README)\
-   test: criação ou atualização de testes\
-   refactor: refatoração sem alterar comportamento
