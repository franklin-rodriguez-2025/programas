
PS1="> "

fechayhora=$(date +%Y%m%d%H%M%S)

unalias -a
alias mysql="mysql -u root -p -h localhost -P 3306"
alias ls="clear;ls -p --color=always"
alias l="clear;ls -logo --color=always"
alias ll="clear;ls -l --color=always"
alias delete="rm -f "
alias tarfile='tar -cJf "${fechayhora}.tar.xz" $1'
alias gs="git status"
alias gol="git log --oneline -n 9"
alias add="git add -A"




# programas
export PATH="${HOME}/Downloads/files-programas/shell":${PATH}
export PATH="/usr/local/mysql/bin":${PATH}
export PATH="/usr/local/bin":${PATH}



# Java Configs
export JAVA_HOME=$(/usr/libexec/java_home)
export PATH="${JAVA_HOME}/bin":${PATH}
# Java Configs
export PATH="${HOME}/opt/visual-studio-code":${PATH}
# Maven Configs
#      Maven No Sigue Patron Que 1 programa debe hacer 1 sola cosa y hacerla bien.
export MAVEN_HOME="${HOME}/opt/apache-maven-3.9.9"
export PATH="${MAVEN_HOME}/bin":${PATH}
export MAVEN_OPTS="-Xms256m -Xmx512m --enable-native-access=ALL-UNNAMED"
export MAVEN_ARGS="-B -V checkstyle:checkstyle"
#      Maven No Sigue Patron Que 1 programa debe hacer 1 sola cosa y hacerla bien.
# Maven Configs






