FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT="Development"
EXPOSE 8888


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Powerplant.Api/Powerplant.Api.csproj", "Powerplant.Api/"]
RUN dotnet restore "Powerplant.Api/Powerplant.Api.csproj"
COPY . .
WORKDIR "/src/Powerplant.Api"
RUN dotnet build "Powerplant.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Powerplant.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Powerplant.Api.dll"]