USE SQLFinal;

-------------------------TABLA MECANICO
CREATE TABLE tb_mecanico(
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(300) NOT NULL,
    cedula VARCHAR(10) NOT NULL,
    celular VARCHAR(10) NOT NULL,
    correo VARCHAR(100) NOT NULL
);
select * from tb_mecanico;

insert into tb_mecanico(nombre, cedula, celular, correo)
values('Juan Andres Mendoza Acosta', '0902658950', '0987654321','juan@gmail.com');
insert into tb_mecanico(nombre, cedula, celular, correo)
values('Luis Mateo Parrales Anchundia', '0945968522', '0563226698','luis2mateo@hotmail.com');

--PROCEDIMIENTO ALMACENADO
GO
CREATE PROCEDURE SP_GET_MECANICO AS
  SELECT * FROM tb_mecanico
GO
EXEC SP_GET_MECANICO;


GO
CREATE PROCEDURE SP_CREA_MECANICO
  @nombre varchar(300),
  @cedula varchar(10),
  @celular varchar(10),
  @correo varchar(100)
AS
  INSERT INTO tb_mecanico(nombre, cedula, celular, correo)
  VALUES(@nombre, @cedula, @celular, @correo);
GO
EXEC SP_CREA_MECANICO 'Monica Lucia Torres Zambrano', '0945369855', '0963586692','mon.lucia@hotmail.com';
SELECT * FROM tb_mecanico


GO
CREATE PROCEDURE SP_ACTUALIZA_MECANICO
  @id int,
  @nombre varchar(300),
  @cedula varchar(10),
  @celular varchar(10),
  @correo varchar(100)
AS
  UPDATE tb_mecanico
  SET nombre = @nombre,
  cedula = @cedula,
  celular = @celular,
  correo = @correo
  WHERE id = @id;
GO
SELECT * FROM tb_mecanico

GO
CREATE PROCEDURE SP_ELIMINA_MECANICO
  @IdMecanico int
AS
  DELETE FROM tb_mecanico WHERE id = @IdMecanico;
GO
EXEC SP_ELIMINA_MECANICO 5;




-------------------------TABLA CLIENTE
CREATE TABLE tb_cliente(
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(300) NOT NULL,
    edad numeric(2) NOT NULL,    
    cedula VARCHAR(10) NOT NULL,
    celular VARCHAR(10) NOT NULL,
    correo VARCHAR(100) NOT NULL,
	contacto_emergencia VARCHAR(10) NOT NULL
);
select * from tb_cliente

insert into tb_cliente(nombre, edad, cedula, celular, correo, contacto_emergencia)
values('Michael Andres Mora Acosta','25', '0902658950', '0987654321', 'michael@gmail.com', '0935684950');
insert into tb_cliente(nombre, edad, cedula, celular, correo, contacto_emergencia)
values('Luis Miguel Parras Acosta', '36', '0945968522', '0563226698', 'luismi@hotmail.com', '0954678891');

--PROCEDIMIENTO ALMACENADO
GO
CREATE PROCEDURE SP_GET_CLIENTE AS
  SELECT * FROM tb_cliente
GO
EXEC SP_GET_CLIENTE;


GO
CREATE PROCEDURE SP_CREA_CLIENTE
  @nombre varchar(300),
  @edad numeric(2),
  @cedula varchar(10),
  @celular varchar(10),
  @correo varchar(100),
  @contacto_emergencia varchar(10)
AS
  INSERT INTO tb_cliente(nombre, edad, cedula, celular, correo, contacto_emergencia)
  VALUES(@nombre, @edad, @cedula, @celular, @correo, @contacto_emergencia);
GO
EXEC SP_CREA_CLIENTE 'Maria Lucia Toala Zambrano', '42', '0945369855', '0963586692', 'mon.lucia@hotmail.com', '0999890263' ;
SELECT * FROM tb_cliente


GO
CREATE PROCEDURE SP_ACTUALIZA_CLIENTE
  @id int,
  @nombre varchar(300),
  @edad varchar(100),
  @cedula varchar(10),
  @celular varchar(10),
  @correo varchar(100),
  @contacto_emergencia varchar(10)
AS
  UPDATE tb_cliente
  SET nombre = @nombre,
  edad = @edad,
  cedula = @cedula,
  celular = @celular,
  correo = @correo,
  contacto_emergencia = @contacto_emergencia
  WHERE id = @id;
GO
SELECT * FROM tb_cliente


GO
CREATE PROCEDURE SP_ELIMINA_CLIENTE
  @IdCliente int
AS
  DELETE FROM tb_cliente WHERE id = @IdCliente;
GO




-------------------------TABLA VEHICULO
CREATE TABLE tb_vehiculo(
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    vehiculo VARCHAR(300) NOT NULL,
    kilometraje VARCHAR(10) NOT NULL,
    placa VARCHAR(10) NOT NULL,
    cliente VARCHAR(100) NOT NULL
);
select * from tb_vehiculo;


insert into tb_vehiculo(vehiculo, kilometraje, placa, cliente)
values('Mercedes-Benz', '12,000KM', 'S.EQ29613E','Maria Lucia Toala Zambrano');

--PROCEDIMIENTO ALMACENADO
GO
CREATE PROCEDURE SP_GET_VEHICULO AS
  SELECT * FROM tb_vehiculo
GO
EXEC SP_GET_VEHICULO;


GO
CREATE PROCEDURE SP_CREA_VEHICULO
  @vehiculo varchar(300),
  @kilometraje varchar(10),
  @placa VARCHAR(10),
  @cliente VARCHAR(100)
AS
  INSERT INTO tb_vehiculo(vehiculo, kilometraje, placa, cliente)
  VALUES(@vehiculo, @kilometraje, @placa, @cliente);
GO


GO
CREATE PROCEDURE SP_ACTUALIZA_VEHICULO
  @id int,
  @vehiculo varchar(300),
  @kilometraje varchar(10),
  @placa VARCHAR(10),
  @cliente VARCHAR(100)
AS
  UPDATE tb_vehiculo
  SET vehiculo = @vehiculo,
  kilometraje = @kilometraje,
  placa = @placa,
  cliente = @cliente
  WHERE id = @id;
GO
SELECT * FROM tb_vehiculo

GO
CREATE PROCEDURE SP_ELIMINA_VEHICULO
  @IdVehiculo int
AS
  DELETE FROM tb_vehiculo WHERE id = @IdVehiculo;
GO





-------------------------TABLA INVENTARIO REPUESTOS
CREATE TABLE tb_inventario_repuestos (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre_repuesto VARCHAR(100),
    precio FLOAT(2) NOT NULL
);
select * from tb_inventario_repuestos;

insert into tb_inventario_repuestos (nombre_repuesto, precio)
values('Discos de Frenos', 45.99);
insert into tb_inventario_repuestos (nombre_repuesto, precio)
values('Batería', 89.99);

---PROCEDIMIENTO ALMACENADO
GO
CREATE PROCEDURE SP_GET_INVENTARIO_REPUESTO AS
  SELECT * FROM tb_inventario_repuestos
GO
EXEC SP_GET_INVENTARIO_REPUESTO;


GO
CREATE PROCEDURE SP_CREA_INVENTARIO_REPUESTO
  @nombre_repuesto varchar(100),
  @precio FLOAT
AS
  INSERT INTO tb_inventario_repuestos(nombre_repuesto, precio)
  VALUES(@nombre_repuesto, @precio);
GO
SELECT * FROM tb_inventario_repuestos;


GO
CREATE PROCEDURE SP_ACTUALIZA_INVENTARIO_REPUESTO
	@id int,
	@nombre_repuesto varchar(100),
	@precio FLOAT
AS
	UPDATE tb_inventario_repuestos
	SET nombre_repuesto = @nombre_repuesto,
	precio = @precio
	WHERE id = @id;
GO
SELECT * FROM tb_inventario_repuestos


GO
CREATE PROCEDURE SP_ELIMINA_INVENTARIO_REPUESTO
	@IdInventarioRepuesto int
AS
	DELETE FROM tb_inventario_repuestos WHERE id = @IdInventarioRepuesto;
GO




-------------------------TABLA SERVICIOS ADICIONALES
CREATE TABLE tb_servicios (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(1000) NOT NULL,
    precio FLOAT(2) NOT NULL
);
select * from tb_servicios;

insert into tb_servicios (nombre, precio)
values('Alineacion', 400);
insert into tb_servicios (nombre, precio)
values('Cambio de aceite', 45);
insert into tb_servicios (nombre, precio)
values('Cambio de bateria', 350);
insert into tb_servicios (nombre, precio)
values('Lavado', 30);
insert into tb_servicios (nombre, precio)
values('Reemplazo de luces', 100);

---PROCEDIMIENTO ALMACENADO
GO
CREATE PROCEDURE SP_GET_SERVICIOS AS
  SELECT * FROM tb_servicios
GO
EXEC SP_GET_SERVICIOS;


GO
CREATE PROCEDURE SP_CREA_SERVICIOS
  @nombre varchar(1000),
  @precio float(2)
AS
  INSERT INTO tb_servicios(nombre, precio)
  VALUES(@nombre, @precio);
GO
SELECT * FROM tb_servicios


GO
CREATE PROCEDURE SP_ACTUALIZA_SERVICIOS
	@id int,
	@nombre varchar(1000),
	@precio float(2)
AS
	UPDATE tb_servicios
	SET nombre = @nombre,
	precio = @precio
	WHERE id = @id;
GO
SELECT * FROM tb_servicios


GO
CREATE PROCEDURE SP_ELIMINA_SERVICIOS
	@IdServicio int
AS
	DELETE FROM tb_servicios WHERE id = @IdServicio;
GO




-------------------------TABLA FACTURA MANTENIMIENTO
CREATE TABLE tb_factura_mantenimiento(
    id INT IDENTITY(1,1) PRIMARY KEY,
    fecha Date NOT NULL,
    nombre_cliente VARCHAR(100) NOT NULL,
    nombre_vehiculo VARCHAR(100) NOT NULL,
	kilometraje_vehiculo VARCHAR(100) NOT NULL,
	placa_vehiculo VARCHAR(100) NOT NULL,
    nombre_mecanico VARCHAR(100) NOT NULL,
    trabajos VARCHAR(1000) NOT NULL,
    tipo_mantenimiento VARCHAR(100) NOT NULL,
    repuesto VARCHAR(1000),
    total_mantenimiento FLOAT(2) NOT NULL,
    nombre_servicios VARCHAR(100),
    total_servicios FLOAT(2), 
    subtotal_factura FLOAT(2) NOT NULL,
    total_factura FLOAT(2) NOT NULL
);






--PROCEDIMIENTO ALMACENADO
GO
CREATE PROCEDURE SP_GET_MANTENIMIENTO AS
	SELECT * FROM tb_factura_mantenimiento
GO
EXEC SP_GET_MANTENIMIENTO;

GO
CREATE PROCEDURE SP_CREA_MANTENIMIENTO
    @fecha DATE,
    @nombre_cliente VARCHAR(100),
    @nombre_vehiculo VARCHAR(100),
	@kilometraje_vehiculo VARCHAR(100),
	@placa_vehiculo VARCHAR(100),
    @nombre_mecanico VARCHAR(100),
    @trabajos VARCHAR(150),
    @tipo_mantenimiento VARCHAR(100),
    @repuesto VARCHAR(1000),
    @total_mantenimiento FLOAT(2),
    @nombre_servicios VARCHAR(100),
    @total_servicios FLOAT(2),
    @subtotal_factura FLOAT(2),
    @total_factura FLOAT(2)
AS
BEGIN
    INSERT INTO tb_factura_mantenimiento (
        fecha,
        nombre_cliente,
        nombre_vehiculo,
		kilometraje_vehiculo,
		placa_vehiculo,
        nombre_mecanico,
        trabajos,
        tipo_mantenimiento,
        repuesto,
        total_mantenimiento,
	nombre_servicios,
        total_servicios,
        subtotal_factura,
        total_factura
    )
    VALUES (
        @fecha,
        @nombre_cliente,
        @nombre_vehiculo,
		@kilometraje_vehiculo,
		@placa_vehiculo,
        @nombre_mecanico,
        @trabajos,
	    @tipo_mantenimiento,
        @repuesto,
        @total_mantenimiento,
        @nombre_servicios,
        @total_servicios,      
        @subtotal_factura,
        @total_factura
    );
END;

GO
CREATE PROCEDURE SP_ACTUALIZA_MANTENIMIENTO
    @id INT,
    @fecha DATE,
    @nombre_cliente VARCHAR(100),
    @nombre_vehiculo VARCHAR(100),
	@kilometraje_vehiculo VARCHAR(100),
	@placa_vehiculo VARCHAR(100),
    @nombre_mecanico VARCHAR(100),
    @trabajos VARCHAR(150),
    @tipo_mantenimiento VARCHAR(100),
    @repuesto VARCHAR(1000),
    @total_mantenimiento FLOAT(2),
    @nombre_servicios VARCHAR(100),
    @total_servicios FLOAT(2),
    @subtotal_factura FLOAT(2),
    @total_factura FLOAT(2)
AS
BEGIN
    UPDATE tb_factura_mantenimiento
    SET
        fecha = @fecha,
        nombre_cliente = @nombre_cliente,
        nombre_vehiculo = @nombre_vehiculo,
		kilometraje_vehiculo = @kilometraje_vehiculo,
		placa_vehiculo = @placa_vehiculo,    
        nombre_mecanico = @nombre_mecanico,
        trabajos = @trabajos,
		tipo_mantenimiento = @tipo_mantenimiento,
        repuesto = @repuesto,
        total_mantenimiento = @total_mantenimiento,
        nombre_servicios = @nombre_servicios,
        total_servicios = @total_servicios, 
        subtotal_factura = @subtotal_factura,
        total_factura = @total_factura
    WHERE id = @id;
END;

GO
CREATE PROCEDURE SP_ELIMINA_MANTENIMIENTO
	@IdMantenimiento int
AS
	DELETE FROM tb_factura_mantenimiento WHERE id = @IdMantenimiento;
GO