
https://learn.microsoft.com/es-mx/aspnet/core/?view=aspnetcore-9.0

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


#
# Agregar herramienta para peticiones http,
# algo asi como postman pero en linea de comandos
#
dotnet tool install -g Microsoft.dotnet-httprepl
#
# se usa asi:
#
httprepl https://localhost:{PORT}
#
# subCommands of httprepl 
# cd,ls,get,post,put,delete,patch
#




###
### Inside the project
###

### Agregar Certificados
dotnet dev-certs https --trust
### Agregar Certificados

# if someoneElse changes the file .csproj then
dotnet restore


### Dependencies = 6
dotnet add package Swashbuckle.AspNetCore                     --version x.x.xx
dotnet add package Microsoft.EntityFrameworkCore.Tools        --version x.x.xx
dotnet add package Microsoft.EntityFrameworkCore.Design       --version x.x.xx
dotnet add package Microsoft.EntityFrameworkCore.Relational   --version x.x.xx
dotnet add package MySql.EntityFrameworkCore                  --version x.x.xx
dotnet add package Pomelo.EntityFrameworkCore.MySql           --version x.x.xx
### Dependencies



###
### Inside the project
###

