#!/bin/bash

echo -e "\t"
echo -e "if the file WebAspNetCoreMvc.csproj is changed Then "
echo -e "\tdotnet restore"
echo -e "\t"


dotnet add package Swashbuckle.AspNetCore
dotnet add package Swashbuckle.AspNetCore

dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.Relational --version 8.0.14
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 8.0.14

dotnet add package MySql.EntityFrameworkCore --version 9.0.0
dotnet add package MySql.EntityFrameworkCore --version 9.0.0

dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Pomelo.EntityFrameworkCore.MySql



dotnet restore
exit 0;
