#!/bin/bash

dotnet new mvc -n WebAspNetCoreMvc
cd WebAspNetCoreMvc
dotnet dev-certs https --trust

dotnet add package Swashbuckle.AspNetCore
dotnet add package Swashbuckle.AspNetCore --version 6.1.4

exit 0;
