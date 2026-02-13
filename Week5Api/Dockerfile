# ---------- Build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution + restore
COPY *.sln ./

# Copy project file and restore (edit path to match your project folder)
COPY Lab_Week5Api_RB/*.csproj Lab_Week5Api_RB/
RUN dotnet restore

# Copy everything else and build
COPY . ./
WORKDIR /src/Lab_Week5Api_RB
RUN dotnet publish -c Release -o /app/publish

# ---------- Runtime stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Render uses PORT env var; ASP.NET must listen on its
E
