#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CardBrand.Api/CardBrand.Api.csproj", "CardBrand.Api/"]
COPY ["CardBrand.Domain/CardBrand.Domain.csproj", "CardBrand.Domain/"]
COPY ["CardBrand.Persistence/CardBrand.Persistence.csproj", "CardBrand.Persistence/"]
COPY ["CardBrand.Service/CardBrand.Service.csproj", "CardBrand.Service/"]
RUN dotnet restore "./CardBrand.Api/./CardBrand.Api.csproj"
COPY . .
WORKDIR "/src/CardBrand.Api"
RUN dotnet build "./CardBrand.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CardBrand.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CardBrand.Api.dll"]