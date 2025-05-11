#!/bin/bash

filename=$(basename "$1")
fechayhora=$(date +%Y%m%d%H%M%S)

tar -cJf "${HOME}/${filename}_${fechayhora}.tar.xz" $1

exit 0;
