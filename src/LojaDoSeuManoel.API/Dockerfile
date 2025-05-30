FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/LojaDoSeuManoel.API/LojaDoSeuManoel.API.csproj", "src/LojaDoSeuManoel.API/"]
COPY ["src/LojaDoSeuManoel.Application/LojaDoSeuManoel.Application.csproj", "src/LojaDoSeuManoel.Application/"]
COPY ["src/LojaDoSeuManoel.Domain/LojaDoSeuManoel.Domain.csproj", "src/LojaDoSeuManoel.Domain/"]
COPY ["src/LojaDoSeuManoel.Infrastructure/LojaDoSeuManoel.Infrastructure.csproj", "src/LojaDoSeuManoel.Infrastructure/"]
RUN dotnet restore "./src/LojaDoSeuManoel.API/LojaDoSeuManoel.API.csproj"
COPY . .
WORKDIR "/src/src/LojaDoSeuManoel.API"
RUN dotnet build "./LojaDoSeuManoel.API.csproj" -c $BUILD_CONFIGURATION -o /app/build


FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./LojaDoSeuManoel.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LojaDoSeuManoel.API.dll"]