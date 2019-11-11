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