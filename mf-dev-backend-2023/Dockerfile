#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["mf-dev-backend-2023/mf-dev-backend-2023.csproj", "mf-dev-backend-2023/"]
RUN dotnet restore "mf-dev-backend-2023/mf-dev-backend-2023.csproj"
COPY . .
WORKDIR "/src/mf-dev-backend-2023"
RUN dotnet build "mf-dev-backend-2023.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "mf-dev-backend-2023.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mf-dev-backend-2023.dll"]