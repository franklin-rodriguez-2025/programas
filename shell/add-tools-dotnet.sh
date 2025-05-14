#!/bin/bash

dotnet tool install --global dotnet-ef
dotnet tool install --global Microsoft.dotnet-httprepl
echo -e "\t"
echo -e "\tTools Added !"
echo -e "\t"

dotnet tool update --global dotnet-ef
dotnet tool update --global Microsoft.dotnet-httprepl

exit 0;
