# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM aaronbee2010/microservicebase:latest AS base
COPY nginx.conf /etc/nginx/sites-available/default
WORKDIR /app
ENV ASPNETCORE_URLS="http://+:8000"
EXPOSE 8000

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src/ShoppingService
COPY ./ShoppingService.csproj .
RUN dotnet restore "./ShoppingService.csproj"
COPY . .
RUN dotnet build "./ShoppingService.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ShoppingService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

COPY supervisord.conf /etc/supervisor/conf.d/supervisord.conf
ENTRYPOINT ["supervisord"]
