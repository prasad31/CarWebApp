#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:2.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY ["test/test1234.test/test1234.test.csproj", "test/test1234.test/"]
COPY ["test1234.csproj", ""]
RUN dotnet restore "test/test1234.test/test1234.test.csproj"
COPY . .
WORKDIR "/src/test/test1234.test"
RUN dotnet build "test1234.test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "test1234.test.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "test1234.test.dll"]
#ENTRYPOINT ["dotnet","test", "test1234.test.csproj"]
ENTRYPOINT ["dotnet", "vstest","./bin/Release/netcoreapp2.1/test1234.test.dll", "--Tests:test2"]