use GD2C2019
GO
create procedure GEDEDE.reiniciarTablas
AS
Begin
	drop trigger GEDEDE.borrarProveedor;
	drop table GEDEDE.cupon;
	drop table GEDEDE.COMPRA;
	drop table GEDEDE.OFERTAS;
	drop table GEDEDE.ROL_FUNCIONALIDAD;
	drop table GEDEDE.FUNCIONALIDAD;
	drop table GEDEDE.USUARIO_ROL;
	drop table GEDEDE.rol;
	drop table GEDEDE.USUARIO;
	drop table GEDEDE.TIPO_USUARIO;
	drop table GEDEDE.carga;
	drop table GEDEDE.TARJETA;
	drop table GEDEDE.clientes;
	drop table GEDEDE.ITEM_FACTURA;
	drop table GEDEDE.FACTURA;
	drop table GEDEDE.PROVEEDOR;
	drop table GEDEDE.Rubro;
	drop procedure GEDEDE.insertarCliente;
	drop procedure GEDEDE.insertarCarga;
	drop procedure GEDEDE.insertarTarjeta;
	drop procedure GEDEDE.insertarCompra;
	drop procedure GEDEDE.insertarCupon;
	drop procedure GEDEDE.canjearCupon;
	drop procedure GEDEDE.cobrarCompra;
	drop procedure GEDEDE.aumentarCredito;
	drop procedure GEDEDE.eliminarCliente;
	drop procedure GEDEDE.actualizarCliente;
	drop procedure GEDEDE.migrarClientes;
	drop procedure GEDEDE.migrarProveedor;
	drop procedure GEDEDE.migrarCupon;
	drop procedure GEDEDE.migrarFacturas;
	drop procedure GEDEDE.migrarRubro;
	drop procedure GEDEDE.migrarCompras;
	drop procedure GEDEDE.migrarOfertas;
	drop procedure GEDEDE.iniciarMigracionTablaMaestra;
	drop procedure GEDEDE.crearUsuario;
	drop procedure GEDEDE.migrarCarga;
	
End
GO
exec GEDEDE.reiniciarTablas
drop procedure GEDEDE.reiniciarTablas;
drop schema GEDEDE;
select * from sys.procedures
select * from sys.tables
select * from sys.triggers
select * from sys.schemas