FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["WebApplicationHW16.csproj", "WebApplicationHW16Project/"]
RUN dotnet restore "WebApplicationHW16Project/WebApplicationHW16.csproj"
COPY . .
RUN dotnet build "WebApplicationHW16.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApplicationHW16.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplicationHW16.dll"]