--use GD2C2019;
--Drop procedure reiniciarTablas
create procedure reiniciarTablas
AS
Begin
	drop table cupon;
	drop table FACTURA;
	drop table COMPRA;
	drop table OFERTAS;
	drop table ROL_FUNCIONALIDAD;
	drop table FUNCIONALIDAD;
	drop table USUARIO_ROL;
	drop table rol;
	drop table USUARIO;
	drop table TIPO_USUARIO;
	drop table carga;
	drop table TARJETA;
	drop table clientes;
	drop table PROVEEDOR;
	drop table Rubro;
End
exec reiniciarTablas
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
	Nombre_contacto nvarchar(100)
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
	Primary Key (DNI_Cliente)
);
CREATE TABLE TARJETA (
	ID_tarjeta smallint identity(1,1),
	Fecha_Vencimiento datetime,
	Nombre_tutorial nvarchar(1255),
	Tipo_pago_desc char(2) check (Tipo_pago_desc IN ('Crédito','Débito')),
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
	ID_usuario int Identity(1,1) Primary Key,
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
	ID_rol smallint Primary Key,
	Nombre varchar(20)
);
CREATE TABLE USUARIO_ROL(
	ID_usuario int,
	ID_rol smallint,
	PRIMARY KEY (ID_usuario,ID_rol),
	FOREIGN KEY (ID_usuario) REFERENCES usuario,
	FOREIGN KEY (ID_rol) REFERENCES rol
);
CREATE TABLE FUNCIONALIDAD(
	ID_funcionalidad int PRIMARY KEY,
	Descripcion varchar(100)
);
CREATE TABLE ROL_FUNCIONALIDAD(
	ID_funcionalidad int,
	ID_rol smallint,
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
CREATE TABLE COMPRA(
	Codigo_oferta nvarchar(50),
	DNI_cliente numeric(18,0),
	Cantidad_compra numeric(18,0),
	Fecha_compra datetime,
	PRIMARY KEY (Codigo_oferta,DNI_cliente),
	FOREIGN KEY (DNI_cliente) REFERENCES clientes(DNI_cliente)
);
CREATE TABLE FACTURA(
	Num_factura numeric(18,0) Primary Key,
	Fecha_factura datetime,
	Importe numeric (18,2),
	DNI_cliente numeric(18,0),
	Codigo_oferta nvarchar(50),
	FOREIGN KEY (DNI_cliente) REFERENCES clientes (DNI_cliente),
	FOREIGN KEY (Codigo_oferta) REFERENCES ofertas(Codigo_oferta)
);
CREATE TABLE CUPON(
	Codigo_cupon int identity(1,1) PRIMARY KEY,
	Entregado_fecha datetime,
	DNI_cliente_origen numeric(18,0),
	DNI_cliente_destino numeric(18,0), 
	Codigo_oferta nvarchar(50),
	FOREIGN KEY (DNI_cliente_origen) REFERENCES clientes (DNI_cliente),
	FOREIGN KEY (DNI_cliente_destino) REFERENCES clientes (DNI_cliente),
	FOREIGN KEY (Codigo_oferta) REFERENCES ofertas(Codigo_oferta)
);