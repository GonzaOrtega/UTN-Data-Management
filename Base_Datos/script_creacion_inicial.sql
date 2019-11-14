use GD2C2019;
----------------------------------------------------------------------------------------------------------		CREACION_DE_TABLAS
CREATE TABLE RUBRO(
	ID_Rubro int IDENTITY PRIMARY KEY,
	Descripcion nvarchar(100)
);
CREATE TABLE PROVEEDOR(
	CUIT_proveedor nvarchar(20),
	Razon_social nvarchar(100),
	Domicilio nvarchar(100),
	Ciudad nvarchar(255),
	Telefono numeric(18,0),
	ID_rubro int,
	Mail nvarchar(255),
	Codigo_postal numeric(18,0),
	Nombre_contacto nvarchar(100),
	habilitado nvarchar(10) check (habilitado IN ('True','False')) default 'True',
	PRIMARY KEY(CUIT_proveedor,Razon_Social),
	FOREIGN KEY (ID_Rubro) REFERENCES rubro
);
CREATE TABLE CLIENTES(
	DNI_cliente numeric(18,0),
	Codigo_postal numeric(18,0),
	Nombre nvarchar(255),
	Apellido nvarchar(255),
	Direccion nvarchar (255),
	Telefono numeric(18,0),
	Mail nvarchar(255),
	Fecha_nacimiento datetime,
	Ciudad nvarchar (255),
	Credito numeric(18,2) NULL DEFAULT 0,
	habilitado nvarchar(10) check (habilitado IN ('True','False')) default 'True',
	Primary Key (DNI_Cliente)
);
CREATE TABLE TARJETA (
	ID_tarjeta smallint identity(1,1),
	Fecha_Vencimiento datetime,
	Nombre_tutorial nvarchar(1255),
	Tipo_pago_desc nvarchar(20) check (Tipo_pago_desc IN ('Crédito','Débito')),
	Primary Key (ID_tarjeta)
);

CREATE TABLE CARGA(
	ID_carga int identity Primary Key,
	Credito numeric(18,2),
	Fecha_carga datetime,
	Tipo_pago_desc nvarchar(100) check (Tipo_pago_desc IN ('Crédito','Efectivo','Débito')),
	ID_tarjeta smallint,
	DNI_Cliente numeric(18,0),
	Foreign Key (DNI_Cliente) references clientes(DNI_Cliente),
	Foreign Key (ID_tarjeta) references tarjeta (ID_tarjeta)
);

CREATE TABLE TIPO_USUARIO(
	ID_usuario int identity Primary Key,
	CUIT_proveedor nvarchar(20),
	Razon_social nvarchar(100),
	DNI_cliente numeric(18,0),
	FOREIGN KEY (DNI_cliente) REFERENCES clientes(DNI_cliente),
	FOREIGN KEY (CUIT_proveedor,Razon_social) REFERENCES proveedor(CUIT_proveedor,Razon_social)
); 
CREATE TABLE USUARIO(
	ID_usuario int Primary Key,
	contrasenia nvarchar(50),
	Nombre_usuario nvarchar(50),
	Foreign Key (ID_usuario) REFERENCES tipo_usuario
);
CREATE TABLE ROL(
	ID_rol int identity Primary Key,
	Nombre varchar(20),
	habilitado nvarchar(10) check (habilitado IN ('True','False')) default 'True',
);
CREATE TABLE USUARIO_ROL(
	ID_usuario int,
	ID_rol int,
	PRIMARY KEY (ID_usuario,ID_rol),
	FOREIGN KEY (ID_usuario) REFERENCES usuario,
	FOREIGN KEY (ID_rol) REFERENCES rol
);
CREATE TABLE FUNCIONALIDAD(
	ID_funcionalidad int identity PRIMARY KEY,
	Descripcion varchar(100)
);
CREATE TABLE ROL_FUNCIONALIDAD(
	ID_funcionalidad int,
	ID_rol int,
	PRIMARY KEY (ID_funcionalidad,ID_rol),
	FOREIGN KEY (ID_funcionalidad) REFERENCES funcionalidad,
	FOREIGN KEY (ID_rol) REFERENCES rol
);
CREATE TABLE OFERTAS(
	Codigo_oferta nvarchar(50) PRIMARY KEY,
	Precio_oferta numeric(18,2),
	Fecha_publicacion datetime,
	Fecha_vencimiento datetime,
	Stock numeric(18,0),
	Description nvarchar(255),
	Precio_lista numeric(18,2),
	Cant_maxima numeric(18,0),
	CUIT_proveedor nvarchar(20),
	Razon_social nvarchar(100),
	FOREIGN KEY (CUIT_proveedor,Razon_social) REFERENCES proveedor(CUIT_proveedor,Razon_social) 
);
CREATE TABLE FACTURA(
	Num_factura numeric(18,0) Primary Key,
	Fecha_factura datetime,
	Importe numeric (18,2),
	CUIT_proveedor nvarchar(20),
	Razon_social nvarchar(100),
	FOREIGN KEY (CUIT_proveedor,Razon_social) REFERENCES proveedor(CUIT_proveedor,Razon_social) 
	);
CREATE TABLE COMPRA(
	Codigo_oferta nvarchar(50),
	DNI_cliente numeric(18,0),
	Cantidad_compra numeric(18,0),
	Fecha_compra datetime,
	Num_factura numeric(18,0),
	PRIMARY KEY (Codigo_oferta,DNI_cliente,Fecha_compra),
	FOREIGN KEY (Num_factura) REFERENCES FACTURA(Num_factura),
	FOREIGN KEY (DNI_cliente) REFERENCES clientes(DNI_cliente),
	FOREIGN KEY (Codigo_oferta) REFERENCES OFERTAS(Codigo_oferta)
);

CREATE TABLE CUPON(
	Codigo_cupon int identity PRIMARY KEY,
	Entregado_fecha datetime,
	DNI_cliente_origen numeric(18,0),
	DNI_cliente_destino numeric(18,0), 
	Codigo_oferta nvarchar(50),
	FOREIGN KEY (DNI_cliente_origen) REFERENCES clientes (DNI_cliente),
	FOREIGN KEY (DNI_cliente_destino) REFERENCES clientes (DNI_cliente),
	FOREIGN KEY (Codigo_oferta) REFERENCES ofertas(Codigo_oferta)
);
GO
----------------------------------------------------------------------------------------------------------		CREACION_DE_STORED_PROCEDURES
CREATE PROCEDURE migrarRubro
AS
BEGIN
	insert into RUBRO (Descripcion)
	(select Provee_Rubro from gd_esquema.Maestra group by Provee_Rubro)
END
GO
CREATE PROCEDURE migrarClientes--ProblemasConCredito probar ir cargandolo a medida que migra credito
AS
BEGIN
	insert into CLIENTES(DNI_cliente,Nombre,Apellido,Direccion,Telefono,Mail,Fecha_nacimiento,Ciudad)
	(select Cli_Dni,Cli_Nombre,Cli_Apellido,Cli_Direccion,Cli_Telefono,Cli_Mail,Cli_Fecha_Nac,Cli_Ciudad
		from gd_esquema.Maestra
		GROUP BY Cli_Dni,Cli_Nombre,Cli_Apellido,Cli_Direccion,Cli_Telefono,Cli_Mail,Cli_Fecha_Nac,Cli_Ciudad)
END
GO
CREATE PROCEDURE migrarCarga
AS
BEGIN
	insert into CARGA(Credito,Fecha_carga,Tipo_pago_desc,DNI_Cliente)
	(select Carga_Credito,Carga_Fecha,Tipo_Pago_Desc,Cli_Dni FROM gd_esquema.Maestra)
	UPDATE CLIENTES 
	set Credito = (SELECT COALESCE(sum (Credito),0) FROM CARGA where CLIENTES.DNI_cliente = CARGA.DNI_Cliente)
END
GO
CREATE PROCEDURE migrarProveedor
AS
BEGIN
	insert into PROVEEDOR (CUIT_proveedor,Razon_social,Domicilio, Ciudad,Telefono, ID_rubro)
	(Select Provee_CUIT,Provee_RS,Provee_Dom,Provee_Ciudad,Provee_Telefono, ID_Rubro
		FROM gd_esquema.Maestra m
		JOIN RUBRO r ON m.Provee_Rubro= r.Descripcion
		where Provee_CUIT IS NOT NULL
		GROUP BY  Provee_CUIT,Provee_RS,Provee_Dom,Provee_Ciudad,Provee_Telefono,ID_Rubro)
END
GO
CREATE PROCEDURE migrarOfertas
AS
BEGIN
	insert into OFERTAS(Codigo_oferta,Precio_oferta,Fecha_publicacion,Fecha_vencimiento,Stock,Description,Precio_lista,Cant_maxima ,CUIT_proveedor,Razon_social)
	(SELECT Oferta_Codigo, Oferta_Precio_Ficticio,Oferta_Fecha,Oferta_Fecha_Venc,sum(Oferta_Cantidad),Oferta_Descripcion,Oferta_Precio,(select top 1 sum(m2.Oferta_Cantidad) from gd_esquema.Maestra m2 where m2.Oferta_Codigo=m1.Oferta_Codigo group by m2.Cli_Dni),Provee_CUIT,Provee_RS
		FROM gd_esquema.Maestra m1
		where Oferta_Codigo IS NOT NULL
		GROUP BY Oferta_Codigo,Oferta_Precio_Ficticio,Oferta_Fecha,Oferta_Fecha_Venc, Oferta_Descripcion,Oferta_Precio,Provee_CUIT,Provee_RS)
END
GO
CREATE PROCEDURE migrarFacturas
AS
BEGIN
	insert into FACTURA(Num_factura, Fecha_factura, Importe,CUIT_Proveedor,Razon_social)
	(SELECT Factura_Nro,Factura_Fecha, sum(Oferta_Cantidad*Oferta_Precio_Ficticio),Provee_CUIT,Provee_RS
	FROM gd_esquema.Maestra
	WHERE Factura_Nro IS NOT NULL
	GROUP BY Factura_Nro,Factura_Fecha,Provee_CUIT,Provee_RS)
END
GO
CREATE PROCEDURE migrarCompras
AS
BEGIN
	insert into COMPRA(Codigo_oferta, DNI_cliente,Cantidad_compra,Fecha_compra)
	(select Oferta_Codigo,Cli_Dni,Oferta_Cantidad,Oferta_Fecha_Compra 
	FROM gd_esquema.Maestra
	where Oferta_Codigo IS NOT NULL
	GROUP BY Oferta_Codigo,Cli_Dni,Oferta_Cantidad,Oferta_Fecha_Compra)
END
GO
CREATE PROCEDURE migrarCupon
AS
BEGIN
	insert into Cupon (Entregado_fecha,	DNI_cliente_origen, Codigo_oferta)
	(select Oferta_Entregado_Fecha,Cli_Dni,Oferta_Codigo  FROM gd_esquema.Maestra
	where Oferta_Fecha_Compra IS NOT NULL)
END
GO
CREATE PROCEDURE iniciarMigracionTablaMaestra
AS
BEGIN
	exec migrarRubro
	exec migrarClientes
	exec migrarCarga
	exec migrarProveedor
	exec migrarOfertas
	exec migrarFacturas
	exec migrarCompras
	exec migrarCupon
END
GO
----------------------------------------------------------------------------------------------------------Ejecuto stored procedure para realizar la migracion
exec iniciarMigracionTablaMaestra
----------------------------------------------------------------------------------------------------------Creo Trigger para encriptar la contraseña
GO
CREATE TRIGGER encriptarContrasenia
ON USUARIO
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO USUARIO(ID_usuario,Nombre_usuario,contrasenia)
	(SELECT ID_usuario,Nombre_usuario, HASHBYTES('SHA2_256', contrasenia) FROM inserted)
END
----------------------------------------------------------------------------------------------------------Creo Trigger para manejar los deletes en proveedor,cliente y rol
GO
Create trigger borrarRol
ON ROL
INSTEAD OF DELETE
AS
BEGIN
	UPDATE ROL
	SET habilitado = 'False'
	where ID_rol in (select ID_rol from deleted)
	DELETE USUARIO_ROL
	where ID_rol in (select ID_rol from deleted)
END
GO
Create trigger borrarClientes
ON CLIENTES
INSTEAD OF DELETE
AS
BEGIN
	UPDATE CLIENTES
	SET habilitado = 'False'
	where DNI_cliente in (select DNI_cliente from deleted)
	UPDATE TIPO_USUARIO
	SET DNI_cliente=NULL
	where DNI_cliente in (select DNI_cliente from deleted)
END
GO
Create trigger borrarProveedor
ON PROVEEDOR
INSTEAD OF DELETE
AS
BEGIN
	UPDATE PROVEEDOR
	SET habilitado = 'False'
	where CUIT_proveedor in (select CUIT_proveedor from deleted)
	and Razon_social in (select Razon_social from deleted)
	UPDATE TIPO_USUARIO
	SET CUIT_proveedor=NULL,Razon_social=NULL
	where CUIT_proveedor in (select CUIT_proveedor from deleted)
	and Razon_social in (select Razon_social from deleted)
END
----------------------------------------------------------------------------------------------------------Creado Usuario
GO
CREATE PROCEDURE crearUsuario
AS
BEGIN
	insert into TIPO_USUARIO(CUIT_proveedor,DNI_cliente,Razon_social)
	values (NUll,Null,Null);
	
	insert into USUARIO (Nombre_usuario,contrasenia,ID_usuario)
	(select top 1 'admin', 'w23e',ID_usuario from TIPO_USUARIO where CUIT_proveedor IS NULL AND DNI_cliente IS NULL AND Razon_social IS NULL );
	
	insert into ROL(Nombre)
	values('AdministradorGeneral')
	
	insert into USUARIO_ROL(ID_usuario,ID_rol)
	(select top 1 ID_usuario,ID_ROL FROM USUARIO,ROL
	where Nombre_usuario like'admin' and Nombre like 'AdministradorGeneral')

	insert into ROL_FUNCIONALIDAD(ID_funcionalidad,ID_rol)
	(select top 1 ID_funcionalidad,ID_ROL FROM FUNCIONALIDAD,ROL where Nombre like 'AdministradorGeneral')
END
GO
exec crearUsuario
GO
insert into ROL(Nombre)
	values('Proveedor')
insert into ROL(Nombre)
	values('Cliente')
insert into FUNCIONALIDAD(Descripcion)
values('ConfeccionarOferta')
insert into FUNCIONALIDAD(Descripcion)
values('CargarCredito')
insert into FUNCIONALIDAD(Descripcion)
values ('ComprarOferta')
insert into FUNCIONALIDAD(Descripcion)
values('BajarOferta')
insert into FUNCIONALIDAD(Descripcion)
values('FacturarProveedor')
insert into FUNCIONALIDAD(Descripcion)
values ('ListadoEstadistico')
insert into FUNCIONALIDAD(Descripcion)
values('ABM_ROL')
insert into FUNCIONALIDAD(Descripcion)
values('ABM_CLIENTES')
insert into FUNCIONALIDAD(Descripcion)
values('ABM_PROVEEDOR')

 insert into ROL_FUNCIONALIDAD(ID_rol,ID_funcionalidad)
 (select ID_rol ,ID_funcionalidad
 FROM FUNCIONALIDAD f,ROL
 where Nombre like 'AdministradorGeneral'
 AND (Descripcion  like 'ListadoEstadistico'
 OR Descripcion  like 'ABM_ROL'
 OR Descripcion like 'ABM_CLIENTES'
 OR Descripcion like 'ABM_PROVEEDOR'
 OR  Descripcion like 'FacturarProveedor'
 OR Descripcion like 'ConfeccionarOferta'))
 
insert into ROL_FUNCIONALIDAD(ID_rol,ID_funcionalidad)
 (select ID_rol,ID_funcionalidad
 FROM ROL r,FUNCIONALIDAD f
 where r.Nombre like 'Proveedor'
 AND(f.Descripcion  like 'BajarOferta'
 OR f.Descripcion  like 'ConfeccionarOferta'))
 
 insert into ROL_FUNCIONALIDAD(ID_rol,ID_funcionalidad)
 (select ID_rol,ID_funcionalidad
 FROM ROL r,FUNCIONALIDAD f
 where r.Nombre like 'Cliente'
 AND (f.Descripcion  like 'CargarCredito'
 OR f.Descripcion  like 'ComprarOferta'))
 go




 create procedure insertarCliente(
	@dni numeric(18,0), 
	@cp numeric(18,0), 
	@nombre nvarchar(255), 
	@apellido nvarchar(255), 
	@direccion nvarchar(255), 
	@telefono numeric(18,0), 
	@mail nvarchar(255), 
	@fechanacimiento datetime, 
	@ciudad nvarchar(255), 
	@credito numeric(18,0))
as begin
	INSERT INTO CLIENTES VALUES (@dni, @cp, @nombre, @apellido, @direccion, 
		@telefono, @mail, @fechanacimiento, @ciudad, @credito)
end
go



create procedure insertarCarga(@Credito numeric(18,2),
	@Fecha_carga datetime, @Tipo_pago_desc nvarchar(100), 
	@ID_tarjeta smallint, @DNI_Cliente numeric(18,0))
as begin
	insert into CARGA (Credito, Fecha_carga,Tipo_pago_desc, ID_tarjeta, DNI_Cliente) 
	values (@Credito, @Fecha_carga, @Tipo_pago_desc, @ID_tarjeta, @DNI_Cliente);
end
go




create procedure insertarTarjeta(@Fecha_Vencimiento datetime,
	@Nombre_tutorial nvarchar(1255), @Tipo_pago_desc char(2))
as begin
	insert into TARJETA (Fecha_Vencimiento, Nombre_tutorial, Tipo_pago_desc)
		values (@Fecha_Vencimiento, @Nombre_tutorial, @Tipo_pago_desc);
end
go



create procedure insertarCompra(@Codigo_oferta nvarchar(50), 
	@DNI_cliente numeric(18,0), @Cantidad_compra numeric(18,0), 
	@Fecha_compra datetime, @Num_factura numeric(18,0))
as begin
	insert into COMPRA (Codigo_oferta, DNI_cliente, Cantidad_compra, Fecha_compra, Num_factura)
		values (@Codigo_oferta, @DNI_cliente, @Cantidad_compra, @Fecha_compra, @Num_factura)
end
go


create procedure insertarCupon(@DNI_cliente_origen numeric(18,0), 
	@DNI_cliente_destino numeric(18,0), @Codigo_oferta nvarchar(50))
as begin
	insert into CUPON (DNI_cliente_origen, DNI_cliente_destino, Codigo_oferta)
		values (@DNI_cliente_origen, @DNI_cliente_destino, @Codigo_oferta)
end
go

create procedure canjearCupon(@Entregado_fecha datetime, @Codigo_cupon int)
as begin
	update CUPON set Entregado_fecha = @Entregado_fecha
		where Codigo_cupon = @Codigo_cupon
end
go

create procedure cobrarCompra(@DNI_cliente numeric(18,0), @Credito numeric(18,2))
as begin
	update CLIENTES set Credito = Credito - @Credito
		where DNI_cliente = @DNI_cliente;
end
go

create procedure aumentarCredito(@DNI_cliente numeric(18,0), @Credito numeric(18,2))
as begin
	update CLIENTES set Credito = Credito + @Credito
		where DNI_cliente = @DNI_cliente;
end
go

create procedure actualizarCliente(
	@dni numeric(18,0), 
	@cp numeric(18,0), 
	@nombre nvarchar(255), 
	@apellido nvarchar(255), 
	@direccion nvarchar(255), 
	@telefono numeric(18,0), 
	@mail nvarchar(255), 
	@fechanacimiento datetime, 
	@ciudad nvarchar(255))
as begin
	update CLIENTES set
		Codigo_postal = @cp,
		Nombre = @nombre,
		Apellido = @apellido,
		Direccion = @direccion,
		Telefono = @telefono,
		Mail = @mail,
		Fecha_nacimiento = @fechanacimiento,
		Ciudad = @ciudad
	where DNI_cliente = @dni
end
go

create procedure eliminarCliente(@DNI_cliente numeric(18,0))
as begin
	delete from CLIENTES where DNI_cliente = @DNI_cliente
end
go