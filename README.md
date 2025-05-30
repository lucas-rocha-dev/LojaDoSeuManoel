# Loja do Seu Manoel API

Esta API foi desenvolvida para automatizar o processo de embalagem de pedidos da loja online do **Seu Manoel**. Dado um conjunto de pedidos com produtos e suas dimensões, a API determina quais caixas devem ser usadas para cada pedido e quais produtos irão em cada caixa, otimizando o uso do espaço e minimizando o número de caixas.

## Pré-requisitos

Para rodar esta aplicação, você precisa ter instalado:

- **Docker**: Recomenda-se o uso do [Docker Desktop](https://www.docker.com/products/docker-desktop/).

## Estrutura do Projeto

O projeto segue uma arquitetura modular, baseada no conceito de Domain-Driven Design (DDD), dividida em camadas para melhor organização e separação de responsabilidades:

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
1. clone o repositório:
```plaintext
bash
git clone https://github.com/lucas-rocha-dev/LojaDoSeuManoel.git
```

2. Acesse o diretório raiz do projeto, onde está o arquivo docker-compose.yml:
```plaintext
bash
cd LojaDoSeuManoel
```
3. Construa as imagens Docker e inicie os contêineres em segundo plano:
```plaintext
bash
docker-compose up -d --build
```
![image](https://github.com/user-attachments/assets/f18f2efa-aa20-4e34-85be-0d5a366632d7)

Assim que o processo for concluído, você poderá acessar http://localhost:5000/swagger/index.html após 15 segundos, tempo médio para a integração da API com o SQL.

## Como Testar a API (Swagger UI)
Após iniciar a API, você pode acessar a interface do Swagger UI para explorar os endpoints e realizar testes.
1. Acesse o Swagger UI
No navegador, acesse:
```plaintext
http://localhost:5000/swagger/index.html
```
2. Obtenha o Token de Autenticação
. Acesse o endpoint /Register no Swagger UI.

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

Após receber o token JWT,click no cadeado use-o para autorizar requisições nos endpoints protegidos. Insira no campo ( Bearer seu_token )
![image](https://github.com/user-attachments/assets/e86641ee-368d-4a55-9465-47137a68153e)

Os endpoints são protegidos, acessados apenas com autenticação.

3. Explore e Teste os Endpoints

No Swagger UI, você verá a documentação dos endpoints disponíveis. Expanda cada endpoint para visualizar:
Detalhes da requisição e resposta.
![image](https://github.com/user-attachments/assets/00fb09d4-123b-4782-9200-96033a9dc98e)



