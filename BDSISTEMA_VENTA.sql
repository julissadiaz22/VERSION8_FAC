CREATE DATABASE DBSISTEMA_VENTA

GO
 

USE DBSISTEMA_VENTA

 

CREATE TABLE ROL(
IdRol int primary key identity,
Descripcion varchar(150),
FechaRegistro datetime default getdate ()
);
go

CREATE TABLE PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(150),
FechaRegistro datetime default getdate ()
);
go

CREATE TABLE PROVEEDOR(
IdProveedor int primary key identity,
Documento varchar(150),
RazonSocial varchar(150),
Correo varchar(150),
Telefono varchar(150),
Estado bit,
FechaRegistro datetime default getdate ()
);

go

CREATE TABLE CLIENTE(
IdCliente int primary key identity,
Documento varchar(150),
NombreCompleto varchar(150),
Correo varchar(150),
Telefono varchar(150),
Estado bit,
FechaRegistro datetime default getdate ()
);

go

CREATE TABLE USUARIO(
IdUsuario int primary key identity,
Documento varchar(150),
NombreCompleto varchar(150),
Correo varchar(150),
Clave varchar(150),
IdRol int references ROL(IdRol),
Estado bit,
FechaRegistro datetime default getdate ()
);

go

CREATE TABLE CATEGORIA(
IdCategoria int primary key identity,
Descripcion varchar(100),
Estado bit,
FechaRegistro datetime default getdate ()
);

go

CREATE TABLE PRODUCTO(
IdProducto int primary key identity,
Codigo varchar(150),
Nombre varchar (150),
Descripcion varchar(150),
IdCategoria int references CATEGORIA(IdCategoria),
Stock int not null default 0,
PrecioCompra decimal (10,2) default 0,
PrecioVenta decimal (10,2) default 0,
Estado bit, 
FechaRegistro datetime default getdate ()
);

go

CREATE TABLE COMPRA(
IdCompra int primary key identity,
IdUsuario int references USUARIO (IdUsuario),
IdProveedor int references PROVEEDOR (IdProveedor),
TipoDocumento varchar(150),
NumeroDocumento varchar(150),
MontoTotal int references ROL(IdRol),
FechaRegistro datetime default getdate ()
);

go


CREATE TABLE DETALLE_COMPRA(
IdDetalleCompra int primary key identity,
IdCompra int references COMPRA (IdCompra),
IdProducto int references PRODUCTO (IdProducto),
PrecioCompra decimal (10,2) default 0,
PrecioVenta decimal (10,2) default 0,
Cantidad int,
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate ()
);

go

CREATE TABLE VENTA (
IdVenta int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
TipoDocumento varchar (150),
NumeroDocumento varchar (150),
DocumentoCliente varchar (150),
NombreCliente varchar (150),
MontoPago decimal (10,2),
MontoCambio decimal (10,2),
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate ()
);

go

CREATE TABLE DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVenta decimal (10,2),
Cantidad int,
SubTotal decimal (10,2),
FechaRegistro datetime default getdate ()
);

CREATE TABLE NEGOCIO(
IdNegocio int primary key,
Nombre varchar(150),
RUC varchar (150),
Direccion varchar (150),
Logo varbinary (MAX) NULL
);

/*
select*from usuario;

select*from rol
insert into rol(Descripcion)
values('Administrador');

 
insert into usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('juli22','Julissa Díaz','julissadiaz849@gmail.com', '12345', 1,1);


select *from PERMISO

insert into PERMISO(IdRol, NombreMenu) values
(1, 'menuusuarios'),
(1, 'menumantenedor'),
(1, 'menuventas'),
(1, 'menucompras'),
(1, 'menuclientes'),
(1, 'menuproveedores'),
(1, 'menureportes'),
(1, 'menuacercade')


delete from PERMISO*/

insert into ROL(Descripcion)
values('Empleado');

insert into PERMISO(IdRol, NombreMenu) values
(1, 'menuusuarios'),
(1, 'menumantenedor'),
(1, 'menuventas'),
(1, 'menucompras'),
(1, 'menuclientes'),
(1, 'menuproveedores'),
(1, 'menureportes'),
(1, 'menuacercade')


insert into ROL(Descripcion)
values('Administrador');


insert into PERMISO(IdRol, NombreMenu) values
(2, 'menuusuarios'),
(2, 'menucompras'),
(2, 'menuclientes'),
(2, 'menuproveedores'),
(2, 'menuacercade')
;

select p.IdRol, NombreMenu from PERMISO p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO  u on u.IdRol = r.IdRol
where u.IdUsuario= 2;

select p.IdRol, NombreMenu from PERMISO p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO  u on u.IdRol = r.IdRol
where u.IdUsuario= 3;

select*from USUARIO

insert into usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('juli22','Julissa Díaz','julissadiaz849@gmail.com', '12345', 1,1);

insert into usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('ale22','Alejandro Lúe','alejandro@gmail.com', '54321', 1,2);

insert into usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('sebas22','Alejandro Lúe','alejandro@gmail.com', '67890', 2,1);

insert into usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('ale23','Alejandro Lúe','alejandro@gmail.com', '54321', 2,1);


select * from USUARIO

insert into usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('123','Rosibel Vasquez','julissa.diaz@oportunidades.org.sv', '12345', 2 ,1);

select u.IdUsuario, u.Documento, u.NombreCompleto, u.correo, u.Clave, u.Estado, r.IdRol, r.Descripcion from usuario u inner join rol r on r.IdRol = u.IdRol

select IdProducto, Codigo, Nombre, p.Descripcion, c.IdCategoria, c.Descripcion[DescripcionCategoria], Stock, PrecioCompra, PrecioVenta, p.Estado from PRODUCTO p
inner join CATEGORIA c on c.IdCategoria = p.IdCategoria

select * from PRODUCTO
select * from CATEGORIA

insert into PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Estado) values
('10110', 'gaseosa', '1litro', 2, 1)

SELECT * FROM NEGOCIO


INSERT INTO NEGOCIO (IdNegocio, Nombre, RUC, Direccion) VALUES
(1, 'CodigoEstudiante', '1010', 'av. codigo 123')

select IdNegocio, Nombre, RUC, Direccion from NEGOCIO WHERE IdNegocio = 1;


select*from USUARIO

select*from permiso