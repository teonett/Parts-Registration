#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Parts.Registration.Api/Parts.Registration.Api.csproj", "src/Parts.Registration.Api/"]
RUN dotnet restore "src/Parts.Registration.Api/Parts.Registration.Api.csproj"
COPY . .
WORKDIR "/src/src/Parts.Registration.Api"
RUN dotnet build "Parts.Registration.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Parts.Registration.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Parts.Registration.Api.dll"]