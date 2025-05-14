#!/bin/bash

echo -e "\t"
echo -e "\t Primer Comando Para HacerLog De Migraciones"
echo -e "\t\tdotnet ef migrations add InitialCreate"
echo -e "\t"

echo -e "\t"
echo "\tActualizando migraciones"
echo -e "\t"
dotnet ef database update

exit 0;
