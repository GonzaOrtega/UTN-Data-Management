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