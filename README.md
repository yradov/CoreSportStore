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

### Entity Framework Core
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9

dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef --version 5.0.9

#### EF Commands
cd .\SportsStore\
dotnet ef migrations add Initial
-- recreate db and seed data
dotnet ef database drop --force --context StoreDbContext




