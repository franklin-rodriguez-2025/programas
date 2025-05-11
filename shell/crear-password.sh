#!/bin/bash

# Verifica que se haya pasado la longitud
if [ -z "$1" ]; then
  echo "Uso: $0 <longitud>"
  exit 1
fi

LONGITUD=$1

# Conjunto de caracteres (puedes ajustar si quieres más o menos)
CARACTERES='abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+{}[]:;<>?,./'

# Longitud del conjunto de caracteres
CARACTERES_LENGTH=${#CARACTERES}

PASSWORD=""

for (( i=0; i<LONGITUD; i++ )); do
    # Generar índice aleatorio con $RANDOM
    INDEX=$((RANDOM % CARACTERES_LENGTH))
    # Extraer el carácter correspondiente
    PASSWORD+="${CARACTERES:$INDEX:1}"
done
echo "Contraseña generada:"
echo "$PASSWORD"
echo ""
exit 0;
