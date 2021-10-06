# Running This Sample
## Install Tooling
`dotnet tool install --global dotnet-ef`    

## Setup Database
### Docker
The connection string is a sample connection string for a database running in docker    
[https://hub.docker.com/_/microsoft-mssql-server](https://hub.docker.com/_/microsoft-mssql-server)     
`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=yourStrong(!)Password" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest `
### Migration
`dotnet ef migrations add InitialCreate`       
`dotnet ef database update --connection "Server=127.0.0.1,1433; Database=gebruikers; User Id=sa; Password=MySuperPassword123"`

## Set User Secrets
Set the connection string using user secrets
[https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=windows](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=windows)

# Additional Resources
> https://docs.microsoft.com/en-us/ef/core/cli/dotnet   
> https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
