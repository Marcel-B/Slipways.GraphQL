FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base

EXPOSE 5000

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY Slipways.GraphQL/Slipways.GraphQL.csproj Slipways/

COPY NuGet.config GraphQL/

RUN dotnet restore Slipways/Slipways.GraphQL.csproj  --configfile ./GraphQL/NuGet.config

# Copy everything else and build
COPY ./Slipways.GraphQL/ Slipways/

WORKDIR "/src/Slipways"
RUN dotnet build "Slipways.GraphQL.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Slipways.GraphQL.csproj" -c Release -o /app

FROM base AS final

WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Slipways.GraphQL.dll"]