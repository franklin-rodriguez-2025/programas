//
//
// LA HISTORIA:
//		1. ALGUIEN CREA LENGUAJES DE PROGRAMACION.
//		2. ALGUIEN CREA INFORMACION PARA USAR ESE LENGUAJE DE PROGRAMACION.
//		3. ALGUIEN APRENDE EN BASE A LO QUE OBSERVA SOBRE PROGRAMACION.
//
//		EN INTERNET HAY INFORMACION PARA USAR LOS LENGUAJES DE PROGRMACION...
//
//		EN INTERNET SE APRENDE OBSERVANDO Y COPIANDO Y HACIENDO...
//
//		ALGUIEN JUNTA PIEZAS/ISLAS DE BLOQUES Y ENTONCES CREA UN PRODUCTO.
//
//
//			AUNQUE TE QUITEN PROYECTOS,
//				AUNQUE DESPUES DIGAN QUE NO ES TUYO.
//					AUNQUE DESPUES DIGAN QUE NO LO HICISTE.
//
//		PERO UNO SABE QUE UNO HIZO EL PROYECTO CON SU TIEMPO Y DEDICACION.
//				Y OBVIAMENTE EL AVANCE DEL PROYECTO, DEPENDE DE LA CANTIDAD
//					DE OBREROS CONSTRUYENDO EN ARMONIA SIN SABOTAJES.
//
//

create database dbtemp;

use dbtemp;

create table usuario(
	id int auto_increment,
	primary key(id),
	nombre varchar(255),
	correo varchar(255),
	contrasena varchar(255)
);

alter table usuario add column activo varchar(1);
update usuario set activo = '1';

alter table usuario add column apellido varchar(255);
alter table usuario add column telefono varchar(27);







