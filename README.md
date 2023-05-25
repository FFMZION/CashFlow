# Challenge Cash Flow
Veja a visão geral de **implementações em microsserviços com ferramentas .net** no desafio **Fluxo de Caixa**


![Microservice Architecture Challenge](https://github.com/FFMZION/CashFlow/assets/31661893/aee65d5d-5232-49c2-971d-6c473364a995)



![component diagram challenge](https://github.com/FFMZION/CashFlow/assets/31661893/de5a3694-2054-47ef-bd7e-6a319d51ffb0)



![Cash Flow Context Diagram](https://github.com/FFMZION/CashFlow/assets/31661893/9684230d-164e-44d7-b427-a61f157de1ed)


### Microsserviço de CashFlowApi que inclui;
* Aplicativo de API da Web ASP.NET Core
* Princípios da API REST, operações CRUD
* Implementando **Clean Architecture** usando as melhores práticas
* Desenvolvendo **CQRS com o uso de pacote AutoMapper**
* Implementação de padrão de repositório
* Implementação da Swagger Open API
* **Conexão de banco de dados SqlServer** 
* Usando o **Entity Framework Core ORM** e migrando automaticamente para o SqlServer na inicialização do aplicativo

#### Microsserviço WebUI Challenge.Web
* Aplicativo Web ASP.NET Core com modelo Bootstrap e MVC
* Chamada para **APIs Ocelot com HttpClientFactory**

#### Microsserviço Duende Identity Server 
* IdentityServer fornece controle total sobre sua interface do usuário, UX, lógica de negócios e dados.
* Garantia de interoperabilidade e práticas de segurança comprovadas.
* Utilização dos protocolos **OAuth e OpenID Connect**

#### Microsserviço Ocelot Gateway de API
* Implementar **Gateway de API com Ocelot**
* Exemplos de microsserviços para redirecionar por meio dos API Gateways
* Execute vários tipos diferentes de contêiner **API Gateway **

#### Implementações de Microsserviços
* Implementação de rastreabilidade utilizando ** SeriLog e NLog** para microsserviços

#### Implementações de resiliência de microsserviços
* Tornando os microsserviços mais **resilientes usando IHttpClientFactory** para implementar solicitações HTTP resilientes

## Executar o Projeto
Você vai precisar dos seguintes passos:
* Configurar os dados de acesso dos bancos de dados no arquivo appsettings.json dos serviços:
    •	CashFlow
    •	Identity

* O usuário de banco de dados, precisa ter permissão para criação de tabelas no SQL Server
* Obs.: Apenas para o desafio foi colocado a ConnectionString no arquivo appsettings, contudo, é possível mover essa informação para o secrets dos serviços que eles funcionarão normalmente.
* Criar o banco e as tabelas usando Entity. O migration já foi criado é só usar o comando Update-Database nos serviços:
    •	CashFlow
    •	Identity
* Executar a aplicação e criar um usuário de acesso com perfil admin
* Após criar o usuário, será direcionado para a página de fluxo de caixa diário. 
* Realizar o cadastro do fluxo de caixa (transação). É possível editar e deletar uma transação
* Visualizar o relatório (dashboard) com as informações do fluxo de caixa da data selecionada

