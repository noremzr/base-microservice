# Microservice Base

## Passos para criação de um microserviço.

1. Criar o projeto api asp net core (Nesse caso utilizei asp net core 7)
2. Marcar para utilizar o docker isso irá criar já o arquivo DOCKERFILE e fazer algumas configurações inicias.
3. Desenvolver o microserviço.
4. Entrar na mesma pasta que está o csproj exemplo: Client.Microservice\Client.Microservice\Client.Microservice\Client.Microservice.csproj.
5. Rodar o comando: docker build -f Dockerfile .. -t client-microservice (sendo esse ultimo paramêtro o nome do contâiner)
6. No aplicativo do docker windows é possível rodar a imagem em portas.