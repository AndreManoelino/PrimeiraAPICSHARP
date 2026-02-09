# ControleAD

Projeto desenvolvido em **C# (.NET 8)** com arquitetura em camadas, criado com o objetivo de **estudo e aprendizado** de:

- Programação Orientada a Objetos (POO)
- Arquitetura em camadas (API, Application, Domain, Infrastructure)
- Criação de APIs REST com ASP.NET Core
- Integração com serviços externos
- Boas práticas de organização e separação de responsabilidades
- Documentação com Swagger

---

## Objetivo do Projeto

O projeto **ControleAD** foi iniciado como um estudo de integração com **Active Directory (AD)** utilizando `System.DirectoryServices`.

Durante o desenvolvimento, ficou claro que:

- Active Directory **exige um domínio ativo**
- É necessária infraestrutura específica (Windows Server, DNS, domínio)
- Para fins de aprendizado local e portfólio, isso gera dependência de ambiente

Por esse motivo, o projeto foi **encerrado nesta fase** e documentado como **estudo técnico**, servindo como base arquitetural para projetos futuros.

---

##  Arquitetura do Projeto

O projeto segue o padrão **Clean Architecture / Camadas**:

```text
ControleAD
│
├── ControleAD.API           → Camada de apresentação (ASP.NET Core)
├── ControleAD.Application   → Interfaces e regras de aplicação
├── ControleAD.Domain        → Entidades e regras de negócio
├── ControleAD.Infrastructure→ Implementações externas (serviços, AD, etc)
├── ControleAD.Shared        → Classes e utilitários compartilhados
