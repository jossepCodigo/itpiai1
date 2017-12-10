create database instituto;
go
--use otro
use instituto;
--drop database instituto
go

create table usuario(
	id_usuario int not null primary key identity(1,1),
	username varchar(100) not null,
	passwords varchar(100) not null,
	tipo_usuario varchar(100) not null,
	activo bit not null,
	intentos int not null,
)

create table bitacora(
	id_bitacora int primary key identity(1,1) not null,
	id_usuario int not null,
	fecha_hora datetime not null,
	accion varchar (100) not null,
	tipo_accion varchar(100) not null,
	descripcion varchar(100) not null,
	foreign key (id_usuario) references usuario (id_usuario)on delete cascade on update cascade,
)

create table nivel(
	id_nivel int not null primary key identity(1,1),
	nombre varchar(50) not null,
	modalidad varchar(50) not null,
)

create table persona(
	id_persona int not null primary key identity(1,1),
	id_usuario int not null,
	ci int not null,
	nombre varchar(100) not null,
	apellido_p varchar(100) not null,
	apellido_m varchar(100) not null,
	sexo bit not null,
	domicilio varchar(200),
	correo varchar(100),
	nacionalidad  varchar(100),
	nacimiento date,
	foreign key (id_usuario) references usuario (id_usuario)on delete cascade on update cascade,
)

create table telefono(
	id_telefono int not null primary key identity(1,1),
	id_persona int not null,
	numero int not null,
	tipo varchar(50),
	foreign key (id_persona) references persona (id_persona)on delete cascade on update cascade,
)

create table administrador(
	id_admin int not null primary key identity(1,1),
	id_persona int not null,
	cargo varchar(100) not null,
	imagen varchar (300),
	foreign key (id_persona) references persona (id_persona)on delete cascade on update cascade,
)

create table docente(
	id_docente int not null primary key identity(1,1),
	id_persona int not null,
	fecha_ingreso date,
	imagen varchar(300),
	foreign key (id_persona) references persona (id_persona)on delete cascade on update cascade,
)

create table secretaria(
	id_secretaria int not null primary key identity(1,1),
	id_persona int not null,
	fecha_ingreso Date,
	imagen varchar(300),
	foreign key (id_persona) references persona (id_persona)on delete cascade on update cascade,
)

create table estudiante(
	cod_itpiai int not null primary key,
	id_persona int not null,
	añoIng int not null,
	imagen varchar(300),
	foreign key (id_persona) references persona (id_persona)on delete cascade on update cascade,
)

create table carrera(
	id_carrera int not null primary key identity(1,1),
	nombre varchar(100),
	modalidad varchar(100),
	duracion int not null,
	activo bit not null,
)

create table kardex(
	id_Kardex int not null primary key identity(1,1),
	cod_itpiai int not null,
	id_carrera int not null,
	serie_tit_b varchar(100),
	numero_tit_b varchar(100),
	fecha_tit_b date,
	estado varchar(100),
	activo bit,
	foreign key (cod_itpiai) references estudiante (cod_itpiai)on delete cascade on update cascade,
	foreign key (id_carrera) references carrera (id_carrera)on delete cascade on update cascade,
)

create table especialidad(
	id_especialidad int not null primary key identity(1,1),
	nombre varchar(50),
	estado bit,
)

create table esp_doc(
	id_docente int not null,
	id_especialidad int not null,
	foreign key (id_docente) references docente (id_docente)on delete cascade on update cascade,
	foreign key (id_especialidad) references especialidad (id_especialidad)on delete cascade on update cascade,
)

create table materia(
	id_materia int not null primary key identity(1,1),
	sigla varchar(100) not null,
	nombre varchar(100) not null,
	carga_horaria int,
	activo bit not null,
)

create table gestion(
	id_gestion int not null primary key identity(1,1),
	numero int not null,
	año int not null,
	fechaIni date,
	fechaFin date,
	modalidad varchar(100) not null,
	activo bit not null,
)

create table curricula(
	id_curricula int not null primary key identity(1,1),
	id_carrera int not null,
	activo bit not null,
	foreign key (id_carrera) references carrera (id_carrera)on delete cascade on update cascade,
)

create table detalleCurricula(
	id_det int not null primary key identity(1,1),
	id_curricula int not null,
	id_materia int not null,
	nivel int not null,
	activo bit not null,
	foreign key (id_curricula) references curricula (id_curricula)on delete cascade on update cascade,
	foreign key (id_materia) references materia (id_materia)on delete cascade on update cascade,
)

create table programacionCurso(
	id_prog_cur int not null primary key identity(1,1),
	id_docente int not null,
	id_gestion int not null,
	fechaIni date not null,
	fechaFin date not null,
	foreign key (id_docente) references docente (id_docente)on delete cascade on update cascade,
	foreign key (id_gestion) references gestion (id_gestion)on delete cascade on update cascade,
)

create table aula(
	id_aula int not null primary key identity(1,1),
	capacidad int not null,
	nombre varchar(100) not null,
	piso int not null,
	activo bit not null,
)

create table materiasProgramadas(
	id_materia_programada int not null primary key identity(1,1),
	id_det int not null,
	id_prog_cur int not null,
	id_aula int not null,
	horaIni date not null,
	hotaFin date not null,
	dia varchar not null,
	foreign key (id_det) references detalleCurricula (id_det)on delete cascade on update cascade,
	foreign key (id_prog_cur) references programacionCurso (id_prog_cur)on delete cascade on update cascade,
	foreign key (id_aula) references aula (id_aula)on delete cascade on update cascade,
)

create table detalleMatInscripcion(
	id_det_mat_ins int not null primary key identity(1,1),
	id_materia_programada int not null,
	nota int,
	asistencia int,
	foreign key (id_materia_programada) references materiasProgramadas (id_materia_programada)on delete cascade on update cascade,
)

create table inscripcion(
	id_inscripcion int not null primary key identity(1,1),
	cod_itpiai int not null,
	id_det_mat_ins int not null,
	fecha date,
	foreign key (cod_itpiai) references estudiante (cod_itpiai)on delete cascade on update cascade,
)



--------- usuario
insert into usuario values('jhas',123456,'estudiante',1,0);
insert into usuario values('jesus',123456,'administrador',1,0);
insert into usuario values('emanuel',123456,'administrador',1,0);
insert into usuario values('maria',123456,'secretaria',1,0);
insert into usuario values('pablo',123456,'docente',1,0);
insert into usuario values('juan',123456,'docente',1,0);
---------bitacora
insert into bitacora values(1,'2015-05-05 01:05:05','prueba1','eliminar','se elimino a un alumno');
insert into bitacora values(2,'2015-05-05 06:05:05','prueba2','agregar','se agrego a un alumno');
--------- persona
insert into persona values(1,9812155,'jhasmany junior','fernandez','ruiz',1,'plan 3000 c/venecia #35','jhasmany00@hotmail.com','boliviano','01/01/1995');
insert into persona values(2,7751423,'diego jossep','pinto','abendaño',1,'plan 3000 c/tairon #5','nazareno_jossep@hotmail.com','boliviano','01/01/90');
insert into persona values(3,7651423,'emanuel julio','ruiz','tuzco',1,'cuarto anillo c/tulio #1','emanuel@hotmail.com','boliviano','01/01/91');
insert into persona values(4,7051423,'maria DB','soliz','tuz',0,'plan 2000 c/yuyi #77','mm@hotmail.com','boliviano','01/25/2017');
insert into persona values(5,9151421,'pablo luis','tora','mazo',1,'cian 1000 c/yuyi #77','platin@hotmail.com','boliviano','01/25/2017');
insert into persona values(6,9151423,'juan manuel','zulo','pinto',1,'lujan c/yuyi #77','juan@hotmail.com','boliviano','01/25/2017');
--------- administrador
insert into administrador values(2,'director','');
insert into administrador values(3,'director','');
--------- docente
insert into docente values(5,'01/01/2017','');
insert into docente values(6,'02/01/2017','');
--------- secretaria
insert into secretaria values(4,'02/01/2017','');
---------especialidad
insert into especialidad values('android',1);
insert into especialidad values('seguridad web',1);
insert into especialidad values('java',1);
insert into esp_doc values(1,1);
insert into esp_doc values(1,2);
insert into esp_doc values(2,3);
---------estudiante
insert into estudiante values(1001,1,2015,'');
---------carrera
insert into carrera values('sistema','semestral',3,1);
---------kardex
insert into kardex values(1001,1,'65366-2868-1527','123332','11/01/2000','creado',1);
---------materia
insert into materia values('mat-101','matematica basica',120,1);
insert into materia values('mat-201','matematica avanzada',130,1);
---------gestion
insert into gestion values(2,2017,'12/01/17','01/01/18','semestral',1);
insert into gestion values(1,2017,'12/01/17','01/01/18','anual',1);
---------curricula
insert into curricula values(1,1);
---------detalleCurricula
insert into detalleCurricula values(1,1,1,1);
insert into detalleCurricula values(1,2,2,1);
---------aula
insert into aula values(30,'lab1',1,1);

----------------------------------------------------------------------------------------------
select * from aula where activo = 1 and nombre='lab1'
update aula set capacidad = 100, piso=2,activo=1 where id_aula = 1

select * from persona;
select * from usuario;
select * from administrador;
select * from docente;
select * from secretaria;
select * from telefono;
select * from especialidad;
select * from esp_doc;
select * from estudiante;
select * from carrera;
select * from kardex; 
select * from materia;
select * from gestion;
select * from curricula;
select * from detalleCurricula;
select * from aula;

update kardex set id_carrera=1,serie_tit_b='65366-2868',numero_tit_b=12311,fecha_tit_b='11/02/2001',estado='modificado',activo=0 where id_Kardex=1;

select docente.id_docente,docente.id_persona,docente.fecha_ingreso,docente.imagen from docente,persona where docente.id_persona = persona.id_persona and persona.ci = 7151423;

-- busqueda de especialidades de un docente id
select especialidad.id_especialidad,especialidad.nombre from especialidad,esp_doc where especialidad.id_especialidad=esp_doc.id_especialidad and esp_doc.id_docente = 1;
--- todos las especialidades menos ese docente
select * from especialidad where estado=1 and  id_especialidad not in (select esp_doc.id_especialidad from esp_doc where esp_doc.id_docente=1)