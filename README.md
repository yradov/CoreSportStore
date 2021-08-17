# CoreSportStore
Study ASP.NET 5.0

## Commands
### Project
dotnet new globaljson --sdk-version 5.0.302 --output SportsSln/SportsStore
dotnet new web --no-https --output SportsSln/SportsStore --framework net5.0
dotnet new sln -o SportsSln
dotnet sln SportsSln add SportsSln/SportsStore
### Tests Project
dotnet new xunit -o SportsSln/SportsStore.Tests --framework net5.0
dotnet sln SportsSln add SportsSln/SportsStore.Tests
dotnet add SportsSln/SportsStore.Tests reference SportsSln/SportsStore
dotnet add SportsSln/SportsStore.Tests package Moq --version 4.16.1