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