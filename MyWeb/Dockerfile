FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MyWeb/MyWeb.csproj", "MyWeb/"]
RUN dotnet restore "MyWeb/MyWeb.csproj"
COPY . .
WORKDIR "/src/MyWeb"
RUN dotnet build "MyWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyWeb.dll"]