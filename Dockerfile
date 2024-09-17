FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

EXPOSE 80
EXPOSE 5119

#Copy project files
COPY ./*.csproj ./
RUN dotnet restore

#Copy all files
COPY . ./
RUN dotnet publish -c Release -o out

#Build image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "GradesService.dll"]