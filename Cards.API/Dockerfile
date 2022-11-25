#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cards.API/Cards.API.csproj", "Cards.API/"]
COPY ["Cards.Infrastructure/Cards.Infrastructure.csproj", "Cards.Infrastructure/"]
COPY ["Cards.Core/Cards.Core.csproj", "Cards.Core/"]
COPY ["Core/Core.csproj", "Core/"]
RUN dotnet restore "Cards.API/Cards.API.csproj"
COPY . .
WORKDIR "/src/Cards.API"
RUN dotnet build "Cards.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cards.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cards.API.dll"]