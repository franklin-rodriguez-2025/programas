
# Observar versiones instaladas de .net
dotnet --list-sdks

# Tipos de proyectos
dotnet new list


# .NET CORE ConsoleApp
dotnet new console -n dotnetConsole -f net9.0
dotnet new console -n dotnetConsole -f net8.0


# ASP.NET CORE => Minimal API
# Endpoints en Program.cs
dotnet new web -n MinimalApi -f net9.0
dotnet new web -n MinimalApi -f net8.0


# ASP.NET CORE => API With Controllers & MVC
dotnet new mvc -n WebAspNetCoreMvc -f net9.0
dotnet new mvc -n WebAspNetCoreMvc -f net8.0

# ASP.NET CORE => API Controllers
dotnet new webapi -controllers -n webapiaspnetcore -f net8.0
dotnet new webapi -controllers -n webapiaspnetcore -f net9.0




###
### Inside the project
###

### Agregar Certificados
dotnet dev-certs https --trust
### Agregar Certificados

### Dependencies
dotnet add package Swashbuckle.AspNetCore
dotnet add package Swashbuckle.AspNetCore --version 6.1.4
dotnet add package Swashbuckle.AspNetCore --version 6.5.0
### Dependencies

###
### Inside the project
###

