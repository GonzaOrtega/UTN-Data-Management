use GD2C2019
GO
create procedure reiniciarTablas
AS
Begin
	drop table cupon;
	
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
	drop table FACTURA;
	drop table PROVEEDOR;
	drop table Rubro;

	drop procedure migrarClientes;
	drop procedure migrarProveedor;
	drop procedure migrarCupon;
	drop procedure migrarFacturas;
	drop procedure migrarRubro;
	drop procedure migrarCompras;
	drop procedure migrarOfertas;
	drop procedure iniciarMigracionTablaMaestra;
	drop procedure crearUsuario;
	drop procedure migrarCarga;
End
GO
exec reiniciarTablas
drop procedure reiniciarTablas;
select * from sys.procedures
select * from sys.tables
select * from sys.triggers