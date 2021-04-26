dotnet clean .\Services\Employee.Api\Employee.Api.csproj
dotnet build .\Services\Employee.Api\Employee.Api.csproj
Start-Process powershell { $host.UI.RawUI.WindowTitle = 'Employee API'; dotnet run --project .\Services\Employee.Api\Employee.Api.csproj }

dotnet clean .\WebClient\WebStatus\WebStatus.csproj
dotnet build .\WebClient\WebStatus\WebStatus.csproj
Start-Process powershell { $host.UI.RawUI.WindowTitle = 'Web Status Healthcheck'; dotnet run --project .\WebClient\WebStatus\WebStatus.csproj }