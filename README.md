# Loja do Seu Manoel API

Esta API foi desenvolvida para automatizar o processo de embalagem de pedidos da loja do **Seu Manoel**. Dado um conjunto de pedidos com produtos e suas dimensões, a API determina quais caixas devem ser usadas para cada pedido e quais produtos irão em cada caixa, otimizando o uso do espaço e minimizando o número de caixas.

## Funcionalidades Implementadas
✅ Arquitetura baseada em Domain-Driven Design (DDD) \
✅ Dados validados com FluentValidation \
✅ Tokens gerados com JWTs \
✅ Testes com MSTest \
✅ Banco de dados em SQL Server \
✅ Lógica de empacotamento de pedidos otimizada \
✅ API com documentação Swagger \
✅ Entity Framework \
✅ Projeto 100% conteinerizado com Docker \
✅ Segurança na autenticação da API  \
✅ Escalável

## Pré-requisitos

Para rodar esta aplicação, você precisa ter instalado:

- **Docker**: Recomenda-se o uso do [Docker Desktop](https://www.docker.com/products/docker-desktop/).

## Estrutura do Projeto

O projeto segue uma arquitetura modular, baseada no conceito de Domain-Driven Design (DDD), dividida em camadas para melhor organização e separação de responsabilidades:

```plaintext
📦LojaDoSeuManoel
└── 
  📂├── docker-compose.yml
  📂└── src
     📂 ├── LojaDoSeuManoel.API              
     📂 ├── LojaDoSeuManoel.Application     
     📂 ├── LojaDoSeuManoel.Domain          
     📂 └── LojaDoSeuManoel.Infrastructure   
  📂└── tests                               
```
## Como Rodar a Aplicação

A aplicação e o banco de dados SQL Server são configurados para rodar via Docker com poucos comandos, utilizando o docker-compose.
1. clone o repositório: \
bash:
```plaintext
git clone https://github.com/lucas-rocha-dev/LojaDoSeuManoel.git
```

2. Acesse o diretório raiz do projeto, onde está o arquivo docker-compose.yml: \
bash:
```plaintext
cd LojaDoSeuManoel
```
3. Construa as imagens Docker e inicie os contêineres em segundo plano: \
bash:
```plaintext
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

Utilize o método POST para solicitar um token. \
O endpoint espera um objeto RequestUserRegister (validado com FluentValidation). \
Exemplo de RequestUserRegister:
json
```
{
  "username": "seu_email@mail.com",
  "password": "acBdsd$%1213"
}
```

Após receber o token JWT, clique no ícone de cadeado e insira-o no campo "Bearer + [seu_token]" para autenticar as requisições nos endpoints protegidos.
![image](https://github.com/user-attachments/assets/e86641ee-368d-4a55-9465-47137a68153e)

Os endpoints são protegidos, acessados apenas com autenticação.

3. Explore e Teste os Endpoints

No Swagger UI, você verá a documentação dos endpoints disponíveis. Expanda cada endpoint para visualizar:
Detalhes da requisição e resposta.
![image](https://github.com/user-attachments/assets/00fb09d4-123b-4782-9200-96033a9dc98e)



