# ---------- Build Stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution file
COPY *.sln ./

# Copy project file and restore dependencies
COPY Lab_Week5Api_RB/*.csproj Lab_Week5Api_RB/
RUN dotnet restore

# Copy everything else
COPY . ./
WORKDIR /src/Lab_Week5Api_RB

# Publish the app
RUN dotnet publish -c Release -o /app/publish

# ---------- Runtime Stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Render dynamic port support
ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}
ENV DOTNET_RUNNING_IN_CONTAINER=true

COPY --from=build /app/publish ./

ENTRYPOINT ["dotnet", "Lab_Week5Api_RB.dll"]
