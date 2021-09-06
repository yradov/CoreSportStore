# CoreSportStore
Study ASP.NET 5.0

## Commands
### Project
dotnet new globaljson --sdk-version 5.0.400 --output SportsSln/SportsStore
dotnet new web --no-https --output SportsSln/SportsStore --framework net5.0
dotnet new sln -o SportsSln
dotnet sln SportsSln add SportsSln/SportsStore

### Tests Project
dotnet new xunit -o SportsSln/SportsStore.Tests --framework net5.0
dotnet sln SportsSln add SportsSln/SportsStore.Tests
dotnet add SportsSln/SportsStore.Tests reference SportsSln/SportsStore
dotnet add SportsSln/SportsStore.Tests package Moq --version 4.16.1

### Library Manager Cli
dotnet tool uninstall --global Microsoft.Web.LibraryManager.Cli
dotnet tool install --global Microsoft.Web.LibraryManager.Cli --version 2.1.113
libman init -p cdnjs # in SportsStore
libman install twitter-bootstrap@4.3.1 -d wwwroot/lib/font-awesome
libman install font-awesome@5.15.4 -d wwwroot/lib/font-awesome

### Entity Framework Core
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.9
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9

dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef --version 5.0.9

#### EF Commands
cd .\SportsStore\
dotnet ef migrations add Initial

cd .\SportsStore\
dotnet ef migrations add Orders


RECREATE DB AND SEED DATA
-----------------------------
-- remove DB
dotnet ef database drop --force --context StoreDbContext --project SportsStore ###from the SportsSln folder
dotnet ef database drop --context StoreDbContext ###from the SportsStore folder
-- recreate DB
dotnet ef database update --context StoreDbContext


