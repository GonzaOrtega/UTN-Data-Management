use GD2C2019;
CREATE TABLE RUBRO(
	ID_Rubro smallint IDENTITY(1,1) PRIMARY KEY,
	Descripcion varchar(100)
);
CREATE TABLE PROVEEDOR(
	CUIT_proveedor bigint,
	Razon_social varchar(50),
	Domicilio varchar(100),
	Ciudad varchar(50),
	Telefono int,
	ID_rubro smallint,
	Mail varchar(10),
	Codigo_postal int,
	Nombre_contacto varchar(50)
	PRIMARY KEY(CUIT_proveedor,Razon_Social),
	FOREIGN KEY (ID_Rubro) REFERENCES rubro
);
CREATE TABLE CLIENTES(
	DNI_cliente int,
	Codigo_postal int,
	Nombre varchar(50),
	Apellido varchar(50),
	Direccion varchar (100),
	Telefono int,
	Mail varchar(100),
	Fecha_nacimiento int,
	Ciudad varchar (50),
	Credito dec(100000,2),
	Primary Key (DNI_Cliente,Codigo_postal)
);
CREATE TABLE TARJETA (
	ID_tarjeta smallint identity(1,1),
	Fecha_Vencimiento datetime,
	Nombre_tutorial varchar(100),
	Tipo_pago_desc char(2) check (Tipo_pago_desc IN ('TC','TD')),
	Primary Key (ID_tarjeta,Tipo_pago_desc)
);
CREATE TABLE CARGA(
	ID_carga smallint identity(1,1) Primary Key,
	Credito dec(100000,2),
	Fecha_carga datetime,
	Tipo_pago_desc char(2) check (Tipo_pago_desc IN ('TC','TD')),
	ID_tarjeta smallint,
	DNI_Cliente int,
	Codigo_postal int,
	Foreign Key (DNI_Cliente,Codigo_postal) references clientes(DNI_Cliente,Codigo_postal),
	Foreign Key (ID_tarjeta,Tipo_pago_desc) references tarjeta (ID_tarjeta,Tipo_pago_desc)
);
CREATE TABLE TIPO_USUARIO(
	ID_usuario int Identity(1,1) Primary Key,
	CUIT_proveedor bigint,
	Razon_social varchar(50),
	DNI_cliente int,
	Codigo_postal int,
	FOREIGN KEY (DNI_cliente,Codigo_postal) REFERENCES clientes(DNI_cliente,Codigo_postal),
	FOREIGN KEY (CUIT_proveedor,Razon_social) REFERENCES proveedor(CUIT_proveedor,Razon_social)
);
