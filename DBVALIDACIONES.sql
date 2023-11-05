use DBSISTEMA_VENTA

 

------------------Registrar-----------------
 
CREATE PROC SP_REGISTRARUSUARIO(
@documento varchar (150),
@nombreCompleto varchar (150),
@Correo varchar (150),
@Clave varchar (150),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar (500) output
)

as 
begin 
set @IdUsuarioResultado = 0
set @Mensaje = ''

if not exists(select * from USUARIO where Documento = @documento)
begin
insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado) values
(@documento, @nombreCompleto, @Correo, @Clave, @IdRol, @Estado)

set @IdUsuarioResultado = SCOPE_IDENTITY()

end 
else 
set @Mensaje = 'No se puede repetir el documento para más de un usuario'

end

go 


----------------------Editar----------------
 
CREATE PROC SP_EDITARUSUARIO(
@IdUsuario int,
@Documento varchar (150),
@nombreCompleto varchar (150),
@Correo varchar (150),
@Clave varchar (150),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar (500) output
)

as 
begin 
set @Respuesta = 0
set @Mensaje = ''

if not exists(select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario )
begin
update USUARIO set Documento = @documento,
NombreCompleto = @nombreCompleto, Correo = @Correo, Clave = @Clave, IdRol = @IdRol, Estado = @Estado where IdUsuario = @IdUsuario 

set @Respuesta = 1

end 
else 
set @Mensaje = 'No se puede repetir el documento para más de un usuario'

end

go 

--------------------------Eliminar---------------------
 

CREATE PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar (500) output
)

as 
begin 
set @Respuesta = 0
set @Mensaje = ''
declare @pasoreglas bit = 1

if exists( select * from COMPRA C inner join USUARIO U on U.IdUsuario = C.IdUsuario
where U.IdUsuario = @IdUsuario
) 

begin
set @pasoreglas = 0
set @Respuesta = 0
set @Mensaje = @Mensaje + 'No se puede eliminar porque	el usuario se encuentra relacionado a una COMPRA\n'

end



if exists( select * from VENTA V inner join USUARIO U on U.IdUsuario = V.IdUsuario
where U.IdUsuario = @IdUsuario
) 

begin
set @pasoreglas = 0
set @Respuesta = 0
set @Mensaje = @Mensaje + 'No se puede eliminar porque	el usuario se encuentra relacionado a una VENTA\n'

end

if (@pasoreglas = 1)
begin 
delete from USUARIO where IdUsuario = @IdUsuario
set @Respuesta = 1

end

end


go






declare @Respuesta bit
declare @mensaje varchar (150)

execute SP_EDITARUSUARIO 11 ,'123', 'pruebas 2', 'prueba@gmail.com', '456', 2, 1,@Respuesta output, @mensaje output 

select @Respuesta

select @mensaje

 


--PROCEDIMIENTOS PARA CATEGORIA
--PARA GUARDAR CATEGORIA
CREATE PROC SP_RegistrarCategoria(
@Descripcion varchar(50),
@Resultado int output,
@Estado bit,
@Mensaje varchar(500) output
)as
begin 
Set @Resultado= 0
If not exists (Select*from CATEGORIA Where Descripcion= @Descripcion)
begin
insert into CATEGORIA(Descripcion, Estado) values (@Descripcion, @Estado)
set @Resultado= SCOPE_IDENTITY()
end
ELSE 
set @Mensaje= 'No se puede repetir la descripcion de una categoria'
end

go

 
--PARA MODIFICAR CATEGORIA
CREATE PROC SP_EditarCategoria(
@IdCategoria int,
@Descripcion varchar(50),
@Resultado bit output,
@Estado bit, 
@Mensaje varchar(500) output
)as
begin 
Set @Resultado= 1
If not exists (Select*from CATEGORIA Where Descripcion= @Descripcion and IdCategoria != @IdCategoria)
update CATEGORIA set
Descripcion = @Descripcion,
Estado= @Estado
where IdCategoria = @IdCategoria
ELSE
begin 
set @Resultado=0
set @Mensaje = 'No se puede repetir la descripcion de la categoria'

  end

end

go
 

---------------ELIMINAR CATEGORIA---------------
 
create PROC SP_EliminarCategoria(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin 
SET @Resultado=1
If not exists (
select*from CATEGORIA c
inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
where c.IdCategoria = @IdCategoria
)
begin

delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
end
Else
begin
set @Resultado= 0
set @Mensaje= 'La categoria se encuentra relacionada a un producto'

end
end

go

select IdCategoria, Descripcion, Estado from  CATEGORIA;
 

----------------AGREGAR CATEGORIAS----------------------

 insert into CATEGORIA (Descripcion, Estado) values('LACTEOS',1);
  insert into CATEGORIA (Descripcion, Estado) values('BEBIDAS',1);
   insert into CATEGORIA (Descripcion, Estado) values('EMBUTIDOS',1);

 SELECT* from CATEGORIA

 -----------------Procedimiento de registrar producto------------------

 create PROC sp_RegistrarProducto ( 
 @Codigo varchar(20),
 @Nombre varchar (30),
 @Descripcion varchar (30),
 @IdCategoria int, 
 @Estado bit,
 @Resultado bit output,
 @Mensaje varchar (500) output
 )
 as
 begin
 set @Resultado = 0
 if not exists (select * from PRODUCTO where Codigo = @Codigo)
 begin 
 insert into PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Estado)
 Values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado)
 set @Resultado = SCOPE_IDENTITY()
 end
 else 
 set @Mensaje = 'Ya existe un producto con el mismo código'
 
 end
 go

 ----------------MODIFICAR PRODUCTO---------------
 create PROCEDURE sp_ModificarProducto(
 @IdProducto int,
 @Codigo varchar(20),
 @Nombre varchar (30),
 @Descripcion varchar (30),
 @IdCategoria int, 
 @Estado bit,
 @Resultado bit output,
 @Mensaje varchar (500) output
 )
 as 
 begin 
 set @Resultado = 1
     If not exists (select * from PRODUCTO where Codigo =@Codigo and IdProducto != @IdProducto)
	 update PRODUCTO set
	 Codigo = @Codigo,
	 Nombre = @Nombre,
	 Descripcion = @Descripcion,
	 IdCategoria = @IdCategoria,
	 Estado = @Estado
	 WHERE IdProducto = @IdProducto
	 else
	 begin 
	 set @Resultado = 0
	 SET @Mensaje = 'Ya existe un producto con el mismo código'
	 end 
	 end
	 go

	 
	 select*from USUARIO


-----------------Eliminar producto------------------
 
create Proc SP_EliminarProducto(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar (500) output
) 
as 
begin 
   set @Respuesta = 0
   set @Mensaje = ''
   declare @pasoreglas bit = 1

   if exists (select * from DETALLE_COMPRA dc
   INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
   WHERE p.IdProducto = @IdProducto)
   begin 
   set @pasoreglas = 0
   set @Respuesta = 0
   set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n'
   end 
   if exists (select * from DETALLE_VENTA dv
   inner join PRODUCTO p On p.IdProducto = dv.IdProducto
   where p.IdProducto = @IdProducto)
   begin 
   set @pasoreglas = 0
   set @Respuesta = 0
   SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
   end
   if (@pasoreglas = 1)
   begin
   delete from PRODUCTO where IdProducto = @IdProducto
   set @Respuesta = 1
   end
   end
   go

   ---------PROCEDIMIENTOS ALMACENADOS PARA CLIENTES---------------

   ----------------------REGISTRAR AL CLIENTE--------------------
  
   create proc SP_RegistrarCliente(
   @Documento varchar(50),
   @NombreCompleto varchar(50),
   @Correo varchar(50),
   @Telefono varchar(50),
   @Estado bit,
   @Resultado int output,
   @Mensaje varchar (500) output

   )as 
   begin 
   set @Resultado=0
   declare @IDPERSONA int
   if not exists (select*from CLIENTE where Documento= @Documento)
   begin
   insert into CLIENTE(Documento, NombreCompleto, Correo, Telefono, Estado) values(@Documento, @NombreCompleto, @Correo, @Telefono, @Estado)
   set @Resultado=SCOPE_IDENTITY()
   end 
   else
   set @Mensaje = 'El numero de documento ya existe XD'
   end

   go
   -----------------MODIFICAR AL CLIENTE--------------
 
   create proc SP_ModificarCliente(
   @IdCliente int,
   @Documento varchar(50),
   @NombreCompleto varchar(50),
   @Correo varchar(50),
   @Telefono varchar(50),
   @Estado bit,
   @Resultado int output,
   @Mensaje varchar(500) output

   )as
   begin
   set @Resultado=1
   declare @IDPERSONA int
   if not exists(select*from CLIENTE where Documento= @Documento and IdCliente !=@IdCliente)
   begin
   update CLIENTE set
   Documento = @Documento,
   NombreCompleto= @NombreCompleto,
   Correo = @Correo,
   @Telefono= @Telefono,
   @Estado= @Estado
   where IdCliente= @IdCliente

   end
   else
   begin
   set @Resultado=0
   set @Mensaje='El numero del documento ya existe xD ponga otro'
   
   end 
   end

   go

   ----------------PROCEDIMIENTOS ALMACENADOSA PARA PROVEEDORES-----------------

  -----------------REGISTRAR PROVEEDOR----------------
 

   create proc SP_RegistrarProveedor(
   @Documento varchar(50),
   @RazonSocial varchar(50),
   @Correo varchar(50),
   @Telefono varchar(50),
   @Estado bit,
   @Resultado int output,
   @Mensaje varchar(500) output
   )as 
   begin 
   set @Resultado =0
   declare @IDPERSONA INT
   if not exists (select*from PROVEEDOR where Documento= @Documento)
   begin
   insert into PROVEEDOR(Documento, RazonSocial,Correo, Telefono, Estado) values(@Documento, @RazonSocial, @Correo, @Telefono, @Estado)
   set @Resultado = SCOPE_IDENTITY()
   END

   else 

   set @Mensaje='El numero de documento ya existe, ponga otro'
   end

   go


   -----------------EDITAR PROVEEDOR------------------
  
   create proc SP_ModificarProveedor(
   @IdProveedor int,
   @Documento varchar(50),
   @RazonSocial varchar(50),
   @Correo varchar(50),
   @Telefono varchar(50),
   @Estado bit,
   @Resultado bit output,
   @Mensaje varchar(500) output

   )as
   begin

   set @Resultado =1
   declare @IDPERSONA int
   if not exists (select*from PROVEEDOR WHERE Documento= @Documento and IdProveedor != @IdProveedor)
   begin 
   update PROVEEDOR set
   Documento= @Documento,
   RazonSocial= @RazonSocial,
   Correo= @Correo,
   Telefono = @Telefono,
   Estado= @Estado
   where IdProveedor= @IdProveedor
   END
   else 

   begin
   set @Resultado=0
   set @Mensaje= 'El numero de documento ya existe'
   end
   end
   go

   --------------------PROCEDIMIENTO PARA ELIMINAR-------------------
  
   CREATE PROC SP_EliminarProveedor(
    @IdProveedor int,
	@Resultado bit output,
	@Mensaje varchar(500) output

   )as
   begin
   set @Resultado= 1
   if not exists(select *from PROVEEDOR p
   inner join COMPRA c on p.IdProveedor= c.IdProveedor
   where p.IdProveedor = @IdProveedor
   )

   begin 
   delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
   end
   else
   begin 
   set @Resultado =0
   set @Mensaje= 'El Proveedor se encuentra relacionado a una compra'

   end
   end

   go


   select IdProveedor, Documento, RazonSocial, Correo, Telefono, Estado from PROVEEDOR
 

   --PROCESOS PARA REGISTRAR COMPRA
   
   CREATE TYPE [dbo].[EDetalle_Compra] as table(
   [IdProducto] int null,
   [PrecioCompra] decimal (18,2),
   [PrecioVenta] decimal(18,2),
   [Cantidad] int null,
   [MontoTotal] decimal (18,2) null
   )

go

create proc SP_RegistrarCompra(
@IdUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@MontoTotal decimal (18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output

)as
begin

begin try
     declare @idcompra int=0
	 set @Resultado = 1
	 set @Mensaje=''

	 begin transaction registro

	 insert into	COMPRA(IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal)
	 values(@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

	 set @idcompra= SCOPE_IDENTITY()

	 insert into DETALLE_COMPRA(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
	 select @idcompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal from @DetalleCompra

	 update p set p.Stock = p.Stock + dc.Cantidad,
	 p.PrecioCompra = dc.PrecioCompra,
	 p.PrecioVenta = dc.PrecioVenta
	 from PRODUCTO p
	 inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto

	 commit transaction registro

end try

begin catch

   set @Resultado =0
   set @Mensaje = ERROR_MESSAGE()
   rollback transaction registro

end catch

end
 