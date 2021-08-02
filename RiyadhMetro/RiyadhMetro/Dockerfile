FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RiyadhMetro/RiyadhMetro.csproj", "RiyadhMetro/"]
RUN dotnet restore "RiyadhMetro/RiyadhMetro.csproj"
COPY . .
WORKDIR "/src/RiyadhMetro"
RUN dotnet build "RiyadhMetro.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RiyadhMetro.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RiyadhMetro.dll"]
