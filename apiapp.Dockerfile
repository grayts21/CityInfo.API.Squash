FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . .
RUN dotnet restore CityInfo.API/CityInfo.API.csproj
RUN dotnet publish CityInfo.API/CityInfo.API.csproj --output /out/ --configuration Release

EXPOSE 8000

ENTRYPOINT ["dotnet", "run", "--project", "CityInfo.API/CityInfo.API.csproj"]
#ENTRYPOINT [ "ls", "-alR" ]