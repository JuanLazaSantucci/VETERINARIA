--create database Veterinaria
--use Veterinaria

--create table razas
--(
--	id_raza int,
--	raza nvarchar(60),

--constraint pk_razas primary key(id_raza)
--)

--create table barrios
--(
--	id_barrio int,
--	barrio nvarchar(60),

--constraint pk_barrios primary key(id_barrio)
--)

--create table telefonos
--(
--	nro_telefono int,
--	descripcion nvarchar(60),

--	constraint pk_telefonos primary key(nro_telefono)
--)


--create table propietarios
--(
--	id_propietario int,
--	nombre nvarchar(60),
--	apellido nvarchar(60),
--	id_barrio int,
--	calle nvarchar(60),
--	nro_calle int,
--	nro_telefono int,
--	e_mail nvarchar(60),

--	constraint pk_propietarios primary key(id_propietario),
	
--	constraint fk_propietarios_barrios foreign key(id_barrio)
--	references barrios (id_barrio),

--	constraint fk_propietarios_telefonos foreign key(nro_telefono)
--	references telefonos (nro_telefono)
--)

--create table mascotas
--(
--	id_mascota int,
--	id_propietario int,
--	nombre nvarchar(60),
--	id_raza int,
--	peso decimal(3,2),
--	fec_nac datetime,

--	constraint pk_macotas primary key(id_mascota),

--    constraint fk_mascotas_propietarios foreign key(id_propietario)
--	references propietarios (id_propietario),

--	constraint fk_mascotas_razas foreign key(id_raza)
--	references razas (id_raza)
--)

--create table veterinarios
--(
--	id_veterinario int,
--	nombre nvarchar(60),
--	apellido nvarchar(60),
--	direccion nvarchar(60),
--	e_mail nvarchar(60),
--	nro_telefono int,
--	id_barrio int,

--	constraint pk_veterinarios primary key(id_veterinario),

--	constraint fk_veterinarios_telefonos foreign key(nro_telefono)
--	references telefonos (nro_telefono),
	
--	constraint fk_veterinarios_barrios foreign key(id_barrio)
--	references barrios (id_barrio)
--)

--create table turnos
--(
--	id_turno int,
--	id_propietario int,
--	id_mascota int,
--	id_veterinario int,
--	descripcion nvarchar(60),
--	fecha datetime,

--	constraint pk_turnos primary key(id_turno),

--	constraint fk_turnos_propietarios foreign key(id_propietario)
--	references propietarios (id_propietario),

--	constraint fk_turnos_mascotas foreign key(id_mascota)
--	references mascotas (id_mascota),

--	constraint fk_turnos_veterinarios foreign key(id_veterinario)
--	references veterinarios (id_veterinario)
--)

--insert int veterinarios (id_veterinario, nombre, apellido)

