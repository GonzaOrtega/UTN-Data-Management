--use GD2C2019;
--select * from gd_esquema.Maestra
--Drop procedure iniciarMigracionTablaMaestra
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
	(SELECT Oferta_Codigo, Oferta_Precio_Ficticio,Oferta_Fecha,Oferta_Fecha_Venc,sum(Oferta_Cantidad),Oferta_Descripcion,Oferta_Precio,max(Oferta_Cantidad),Provee_CUIT,Provee_RS
		FROM gd_esquema.Maestra
		where Oferta_Codigo IS NOT NULL
		GROUP BY Oferta_Codigo,Oferta_Precio_Ficticio,Oferta_Fecha,Oferta_Fecha_Venc, Oferta_Descripcion,Oferta_Precio,Provee_CUIT,Provee_RS)
END
GO
/*
CREATE PROCEDURE migrarFacturas
AS
BEGIN
END
GO*/

CREATE PROCEDURE iniciarMigracionTablaMaestra
AS
BEGIN
	exec migrarRubro
	exec migrarClientes
	exec migrarCarga
	exec migrarProveedor
	exec migrarOfertas
	--exec migrarFacturas
END
exec iniciarMigracionTablaMaestra
delete RUBRO
select * from rubro
select * from CLIENTES
select * from gd_esquema.Maestra;
delete CLIENTES
select * from CARGA
select * from PROVEEDOR
select * from OFERTAS