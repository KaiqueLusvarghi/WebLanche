# 🍔 Site WebLanches- ASP.NET Core MVC  

Bem-vindo ao repositório do **WebLanches**, um projeto desenvolvido com **ASP.NET Core MVC**. Este é um sistema completo de vendas que simula um e-commerce focado em lanches, permitindo que usuários naveguem, adicionem produtos ao carrinho e finalizem pedidos.  

## 🚀 Funcionalidades  
- 🛒 **Carrinho de Compras**: Gerenciado por sessões, permitindo adicionar e remover itens.  
- 🔐 **Autenticação e Autorização**: Implementado com **ASP.NET Core Identity** (Cadastro, Login e Logout).  
- 🔎 **Filtros e Paginação**: Facilita a busca de lanches com paginação dinâmica.  
- 📊 **Relatórios e Gráficos**: Relatórios PDF gerados com **FastReport OpenSource** e gráficos dinâmicos utilizando **GoogleChart**.  
- 📦 **Gestão de Produtos e Categorias**: Integração com banco de dados para exibir e gerenciar lanches e categorias.  

## 🛠️ Tecnologias Utilizadas  
- **ASP.NET Core MVC**  
- **Entity Framework Core** (Code-First Migrations)  
- **SQL Server**  
- **LINQ**  
- **Data Annotations** para validação e configuração das entidades  
- **FastReport OpenSource** para geração de relatórios PDF  
- **GoogleChart** para gráficos dinâmicos  
- **Bootstrap** para estilização  

## 📂 Estrutura do Projeto  
- `Models`: Contém as entidades do domínio, como **Lanche**, **Categoria** e **Pedido**.  
- `Repositories`: Implementação do padrão Repository para acesso ao banco de dados.  
- `Controllers`: Controladores responsáveis pelo fluxo de dados entre o back-end e as views.  
- `Views`: Contém as interfaces do usuário com suporte a **Partial Views** e **View Components**.  
- `wwwroot`: Arquivos estáticos como imagens, scripts e CSS.  

## ⚙️ Como Executar o Projeto  
1. Clone o repositório:  
   ```bash
   git clone https://github.com/KaiqueLusvarghi/WebLanche.git
Navegue até o diretório do projeto:
bash
Copiar código
cd nome-do-repositorio
Configure a conexão com o banco de dados no arquivo appsettings.json.
Aplique as migrations para criar o banco de dados:
bash
Copiar código
dotnet ef database update
Execute o projeto:
bash
Copiar código
dotnet run

📖 Aprendizados
Durante o desenvolvimento deste projeto, aprimorei conhecimentos em:

Estruturação de projetos com o padrão MVC.
Utilização do Entity Framework Core para mapeamento de dados.
Boas práticas de programação, como SOLID e Clean Code.
Implementação de segurança com ASP.NET Core Identity.
🤝 Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias.

📜 Licença
Este projeto está licenciado sob a MIT License.

🌟 Agradecimentos
Este projeto foi desenvolvido como parte do curso ASP.NET Core MVC - Criando um Site do Zero na Udemy.







