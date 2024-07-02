# Projeto MVC com ASP .NET Core

Este projeto utiliza o padrão MVC (Model-View-Controller) com ASP .NET Core para desenvolvimento web. Ele inclui várias funcionalidades e tecnologias para oferecer uma aplicação completa e dinâmica.

## Funcionalidades Implementadas

- **Padrão MVC**: Arquitetura utilizada para separar o modelo de domínio, a lógica de negócios e a interface do usuário.
- **Entity Framework Core**: Utilizado para definir e mapear as entidades do modelo de domínio e realizar migrações para o banco de dados utilizando a abordagem Code-First.
- **Data Annotations**: Usado para validação e configuração das entidades diretamente no modelo.
- **Padrão Repository**: Implementado para isolar a lógica de acesso aos dados.
- **Padrão ViewModel**: Utilizado para modelar os dados específicos das Views.
- **Session**: Implementado para gerenciar um carrinho de compras na aplicação.
- **ASP .NET Core Identity**: Implementação de segurança para autenticação de usuários com Login, Registro e Logout.
- **Partial Views**: Criadas para reutilização de componentes visuais.
- **Rotas Personalizadas**: Definidas para facilitar a navegação dentro da aplicação.
- **View Components**: Utilizados para criar componentes reutilizáveis em Views.
- **Paginação e Filtro de Dados**: Implementados para melhorar a experiência do usuário ao lidar com grandes conjuntos de dados.
- **Relatórios com LINQ**: Criados para apresentar informações específicas da aplicação.
- **Gráficos com GoogleChart**: Utilizados para visualização de dados de forma gráfica.
- **Relatórios em PDF com FastReport OpenSource**: Implementados para exportar dados importantes em formato PDF.

## Configuração do Projeto

1. **Requisitos**:
   - ASP .NET Core SDK
   - SQL Server Express

2. **Instalação e Execução**:
   - Clone este repositório.
   - Configure a string de conexão com seu banco de dados no arquivo `appsettings.json`.
   - Execute as migrações para criar o banco de dados e suas tabelas:
     ```
     dotnet ef database update
     ```
   - Execute o projeto:
     ```
     dotnet run
     ```

3. **Contribuição**:
   - Sinta-se à vontade para contribuir com novas funcionalidades ou melhorias. Abra um pull request e vamos revisar juntos!


