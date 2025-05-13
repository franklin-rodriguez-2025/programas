
# Tipos de proyectos
dotnet new list


# PuntoNet Console App
dotnet new console -n dotnetConsole -f 9.0
dotnet new console -n dotnetConsole -f 8.0


dotnet new mvc -n WebAspNetCoreMvc -f 9.0
dotnet new mvc -n WebAspNetCoreMvc -f 8.0

# Agregar Certificados
dotnet dev-certs https --trust


# Dependencies
dotnet add package Swashbuckle.AspNetCore
dotnet add package Swashbuckle.AspNetCore --version 6.1.4
dotnet add package Swashbuckle.AspNetCore --version 6.5.0


# Observar versiones instaladas de .net
dotnet --list-sdks

