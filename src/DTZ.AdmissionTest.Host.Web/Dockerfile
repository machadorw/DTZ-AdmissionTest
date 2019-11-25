FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/DTZ.AdmissionTest.Host.Web/DTZ.AdmissionTest.Host.Web.csproj", "src/DTZ.AdmissionTest.Host.Web/"]
RUN dotnet restore "src/DTZ.AdmissionTest.Host.Web/DTZ.AdmissionTest.Host.Web.csproj"
COPY . .
WORKDIR "/src/src/DTZ.AdmissionTest.Host.Web"
RUN dotnet build "DTZ.AdmissionTest.Host.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DTZ.AdmissionTest.Host.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DTZ.AdmissionTest.Host.Web.dll"]