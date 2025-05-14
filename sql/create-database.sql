
create database dbtemp;

use dbtemp;

create table usuario(
	id int auto_increment,
	primary key(id),
	nombre varchar(255),
	correo varchar(255),
	contrasena varchar(255)
);

