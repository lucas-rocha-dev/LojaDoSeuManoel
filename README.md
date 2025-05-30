# Loja do Seu Manoel API

Esta API foi desenvolvida para automatizar o processo de embalagem de pedidos da loja online do **Seu Manoel**. Dado um conjunto de pedidos com produtos e suas dimensões, a API determina quais caixas devem ser usadas para cada pedido e quais produtos irão em cada caixa, otimizando o uso do espaço e minimizando o número de caixas.

## Pré-requisitos

Para rodar esta aplicação, você precisa ter instalado:

- **Docker**: Recomenda-se o uso do [Docker Desktop](https://www.docker.com/products/docker-desktop/).

## Estrutura do Projeto

O projeto segue uma **arquitetura modular**, dividida em camadas para melhor organização e separação de responsabilidades:

```plaintext
.
├── docker-compose.yml
└── src
    ├── LojaDoSeuManoel.API              # Camada de apresentação (Controllers, Swagger)
    ├── LojaDoSeuManoel.Application      # Camada de aplicação (Serviços, lógica de negócio)
    ├── LojaDoSeuManoel.Domain           # Camada de domínio (Entidades, interfaces de repositório)
    └── LojaDoSeuManoel.Infrastructure   # Camada de infraestrutura (Implementação de repositórios, acesso a dados)
└── tests                                # Projetos de testes (se houver)
```
## Como Rodar a Aplicação

A aplicação e o banco de dados SQL Server são configurados para rodar via Docker, utilizando o docker-compose.
1. Obtenha o Código
No terminal ou prompt de comando, clone o repositório:
```plaintext
bash
git clone https://github.com/lucas-rocha-dev/LojaDoSeuManoel.git
```

2. Navegue até a Pasta do Projeto
Acesse o diretório raiz do projeto, onde está o arquivo docker-compose.yml:
```plaintext
bash
cd LojaDoSeuManoel
```
4. Inicie a Aplicação e o Banco de Dados
Construa as imagens Docker e inicie os contêineres em segundo plano:
```plaintext
bash
docker-compose up -d --build
```

## Como Testar a API (Swagger UI)
Após iniciar a API, você pode acessar a interface do Swagger UI para explorar os endpoints e realizar testes.
1. Acesse o Swagger UI
No navegador, acesse:
```plaintext
http://localhost:5000/swagger/index.html
```
2. Obtenha o Token de Autenticação
A API utiliza autenticação JWT. Para testar endpoints protegidos, obtenha um token de acesso:
Acesse o endpoint /Register no Swagger UI.

Utilize o método POST para solicitar um token.

O endpoint espera um objeto RequestUserRegister (validado com FluentValidation).

Exemplo de RequestUserRegister:
json
```
{
  "username": "seu_email@mail.com",
  "password": "acBdsd$%1213"
}
```

Após receber o token JWT, use-o para autorizar requisições nos endpoints protegidos.
3. Explore e Teste os Endpoints
No Swagger UI, você verá a documentação dos endpoints disponíveis. Expanda cada endpoint para visualizar:
Detalhes da requisição e resposta.

Esquemas de dados.

Teste os endpoints diretamente, fornecendo o token de autenticação quando necessário.


