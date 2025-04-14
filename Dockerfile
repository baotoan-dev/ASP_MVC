# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY *.sln .
COPY src/MvcStudentDemo/*.csproj ./MvcStudentDemo/
RUN dotnet restore

COPY . .
WORKDIR /app/MvcStudentDemo
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/MvcStudentDemo/out ./
ENTRYPOINT ["dotnet", "MvcStudentDemo.dll"]
