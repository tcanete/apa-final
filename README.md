## Análise, Projeto e Avaliação de Arquitetura - Sistema de Matrícula

Projeto com fins acadêmicos para estudar arquiteturas, simulando um sistema de matrícula parcialmente

No caso do projeto será utilizado .NET Core, com a arquitetura MVVM. A disposição das dependências será baseada no modelo de Clean Architecture.

# Estrutura:

A arquitetura Clena Architecture possui quatro camadas de que são divididas com o intuito de serem idependentes sem que uma afete a outra durante alguma manutenção.

As camadas são: Frameworks & Drives, Interface Adapters, Application Business Rules e Enterprise Business Rules. Essas camadas estão destribuídas, respectivamente, nos diretórios: Infrastructure, WebApi, Application e Domain.