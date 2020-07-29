drop database terminalAutobuses;
GO

create database terminalAutobuses;
GO

USE terminalAutobuses;
GO


create table clientes(
	id int identity,
	identidadCliente varchar(13) primary key not null,
	primerNombre varchar(25) not null,
	segundoNombre varchar(25) not null,
	primerApellido varchar(25) not null,
	segundoApellido varchar(25) not null,
	edadCliente int not null,
	departamento varchar(25) not null,
	estado char(10) not null,
);


create table empleados(
	id int identity,
	codigo varchar(3) primary key not null,
	identidadEmpleado varchar(13) not null,
	primerNombre varchar(25) not null,
	segundoNombre varchar(25) not null,
	primerApellido varchar(25) not null,
	segundoApellido varchar(25) not null,
	edad int not null,
	añosDeServicio int not null,
	estado char(10) not null,
	cargo char(10) not null,

);


create table autobuses(
	id int identity,
	matricula varchar(25) primary key not null,
	marca varchar(25) not null,
	modelo varchar(25) not null,
	NoAsientos int not null,
	añosServicio int not null,
	añoFabricacion int not null,
	kilometraje int not null,
	color varchar(25) not null,
	estado char(10) not null,
	conductorAsignado varchar(3) not null,
	ayudanteAsignado varchar(3) not null,
	ubicacionActual varchar(25) not null,	

	FOREIGN KEY(conductorAsignado) references empleados(codigo),
	FOREIGN KEY(ayudanteAsignado) references empleados(codigo),

);

SELECT primerNombre FROM autobuses INNER JOIN empleados ON autobuses.matricula = '001' and autobuses.conductorAsignado = empleados.codigo

create table tarifas(
	id int identity primary key,
	costo int not null,
	estado varchar(25) not null,
)

create table destinos(
	id int identity primary key,
	codigoDestino varchar(10) not null,
	nombreDestino varchar(25) not null,
	precioViaje int not null,
	estado varchar(25) not null,

	FOREIGN KEY(precioViaje) references tarifas(id),
);

create table salidaDiaria(
	id int primary key identity,
	primeraHora time(7) not  null,
	primeraSalida int not null,

	segundoHora time(7) not  null,
	segundaSalida int not null,

	terceraHora time(7) not null,
	terceraSalida int not null,

	cuartaHora time(7) not null,
	cuartaSalida int not null,

	quintaHora time(7) not null,
	quintaSalida int not null,

	sextaHora time(7) not null,
	sextaSalida int not null,

	septimaHora time(7) not null,
	septimaSalida int not null,

	octavaHora time(7) not null,
	octavaSalida int not null,

	novenaHora time(7) not null,
	novenaSalida int not null,

	decimaHora time(7) not null,
	decimaSalida int not null,

	onceHora time(7) not null,
	onceSalida int not null,

	doceHora time(7) not null,
	doceSalida int not null,

	treceHora time(7) not null,
	treceSalida int not null,

	catorceHora time(7) not null,
	catorceSalida int not null,
);

create table boleteria(
	id int identity,
	fecha date not null,
	codigoBoleto varchar(25) primary key not null,
	identidadCliente varchar(13) null,
	matriculaAutobus varchar(25) not null,
	numeroAsiento int not null,
	terminalSalida varchar(25) not null,
	destino int not null,
	precio int null /**/
	
	FOREIGN KEY(identidadCliente) references clientes(identidadCliente),
	FOREIGN KEY(matriculaAutobus) references  autobuses(matricula),
	FOREIGN KEY(destino) references destinos(id)

	ON DELETE CASCADE
	ON UPDATE CASCADE
);
 
-- Agregar Cliente
CREATE PROCEDURE agregarCliente (@identidadCliente varchar(25), @primerNombre varchar(25), @segundoNombre varchar(25), @primerApellido varchar(25), @segundoApellido varchar(25), @edadCliente int, @departamento varchar(25), @estado char(10))
AS BEGIN
	
	IF exists(select identidadCliente from clientes WHERE
		(identidadCliente = @identidadCliente))
		raiserror('USUARIO EN USO!', 16,1)
	else

	insert into clientes values(@identidadCliente, @primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @edadCliente, @departamento, @estado)

	
END


execute agregarCliente  '1608200200031', 'David', 'Edgardo', 'Mejia', 'Urbina', 19, 'Santa Barbara', 'Activo'
execute agregarCliente '1001200200094', 'OSCAR', 'JOSUE', 'MEJIA', 'SEREN', 19, 'INTIBUCA', 'ACTIVO'
execute agregarCliente '0000000000000', 'GENERICO', 'GENERICO', 'GENERICO', 'GENERICO', 00, 'NULL', 'NULL'

--SELECT MAX(id) FROM boleteria
SELECT * FROM CLIENTES

-- Actualizar Cliente
CREATE PROCEDURE actualizarCliente (@identidadCliente varchar(25), @primerNombre varchar(25), @segundoNombre varchar(25), @primerApellido varchar(25), @segundoApellido varchar(25), @edadCliente int, @departamento varchar(25), @estado char(10))
AS BEGIN
	
	IF exists(select identidadCliente from clientes WHERE
		(identidadCliente = @identidadCliente))
			update clientes set identidadCliente = @identidadCliente, primerNombre = @primerNombre, segundoNombre = @segundoNombre, primerApellido = @primerApellido, segundoApellido = @segundoApellido, edadCliente = @edadCliente, departamento = @departamento, estado = @estado WHERE identidadCliente = @identidadCliente

	else
			raiserror('NO EXISTE NINGUN USUARIO CON ESTA IDENTIDAD!', 16,1)

END

Execute actualizarCliente '1001200200094', 'OSCAR', 'JOSUE', 'MEJIA', 'SEREN', 20, 'INTIBUCA', 'ACTIVO'

-- Eliminar Cliente
CREATE PROCEDURE eliminarCliente(@identidadCliente varchar(13))
AS BEGIN
	
	IF exists(select identidadCliente from clientes WHERE
		(identidadCliente = @identidadCliente))
		update clientes set estado = 'UNNABLED' where identidadCliente = @identidadCliente

	else
		raiserror('NO EXISTE NINGUN USUARIO CON ESTA IDENTIDAD!', 16,1)
	
END

execute eliminarCliente '0000000000000'

-- Buscar Un cliente
CREATE PROCEDURE buscarCliente(@identidadCliente varchar(13))
AS BEGIN
	
	IF exists(select identidadCliente from clientes WHERE
		(identidadCliente LIKE @identidadCliente))
		SELECT * FROM clientes where clientes.identidadCliente LIKE @identidadCliente
	else
		raiserror('NO EXISTE NINGUN USUARIO CON ESTA IDENTIDAD!', 16,1)
	
	
END

execute buscarCliente '1%'

/* PARA EMPLEADOS */

-- Insertar un empleado
CREATE PROCEDURE agregarEmpleados(@codigo varchar(3), @identidadEmpleado varchar(13), @primerNombre varchar(25), @segundoNombre varchar(25), @primerApellido varchar(25), @segundoApellido varchar(25), @edad int, @añosDeServicio int, @estado char(10), @cargo char(10))
AS BEGIN
	
	IF exists(select codigo from empleados WHERE
		(codigo = @codigo))
		raiserror('USUARIO EN USO!', 16,1)
	else

	insert into empleados values(@codigo, @identidadEmpleado, @primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @edad, @añosDeServicio, @estado, @cargo)
	
END

execute agregarEmpleados '001', '1608200200031', 'David', 'Edgardo', 'Mejia', 'Urbina', 20, 3, 'Activo', 'Conductor'
execute agregarEmpleados '002', '1608198100321', 'Jose', 'Luis', 'Mejia', 'Hernandez', 21, 2, 'Activo', 'Ayudante'
execute agregarEmpleados'100','1001200200094', 'OSCAR', 'JOSUE', 'MEJIA', 'SEREN', 19, 5, 'ACTIVO', 'CONDUCTOR'
execute agregarEmpleados'200','1001200200095', 'ANGEL', 'EMMANUEL', 'MEJIA', 'DELCID', 20, 3, 'ACTIVO', 'AYUDANTE'

Select * from empleados 

-- Actualizar un Empleado
CREATE PROCEDURE actualizarEmpleados(@codigo varchar(3), @identidadEmpleado varchar(13), @primerNombre varchar(25), @segundoNombre varchar(25), @primerApellido varchar(25), @segundoApellido varchar(25), @edad int, @añosDeServicio int, @estado char(10), @cargo char(10))
AS BEGIN
	
	IF exists(select codigo from empleados WHERE
		(codigo = @codigo))
		UPDATE empleados SET codigo = @codigo, identidadEmpleado = @identidadEmpleado, primerNombre = @primerNombre, segundoNombre = @segundoNombre, primerApellido = @primerApellido, segundoApellido = @segundoApellido, edad = @edad, añosDeServicio = @añosDeServicio, estado = @estado,  cargo = @cargo WHERE codigo = @codigo
	else
		raiserror('NO EXISTE NINGUN USUARIO CON ESTA IDENTIDAD!', 16,1)
END

execute actualizarEmpleados '001', '1608200200031', 'David', 'Edgardo', 'Mejia', 'Urbina', 25, 3, 'Activo', 'Conductor'
Select * from empleados 

-- Eliminar un empleado

CREATE PROCEDURE eliminarEmpleado(@codigo varchar(3))
AS BEGIN

	IF exists(select codigo from empleados WHERE
		(codigo = @codigo))
		update empleados set estado = 'INACTIVO' WHERE empleados.codigo = @codigo

	else
		raiserror('NO EXISTE NINGUN USUARIO CON ESTE CODIGO', 16,1)
	
END

execute eliminarEmpleado '100'


/* PARA AUTOBUSES */


-- Añadir un Autobus
CREATE PROCEDURE agregarAutobus(@matricula varchar(25), @marca varchar(25), @modelo varchar(25) ,@NoAsientos int, @añosServicio int, @añoFabricacion int, @kilometraje int, @color varchar(25), @estado char(10), @conductorAsignado int, @ayudanteAsignado int, @ubicacionActual varchar(25))
AS BEGIN
	
	IF exists(select matricula from autobuses WHERE
		((matricula = @matricula)))
		raiserror('ESTA MATRICULA YA ESTA REGISTRADA!', 16,1)
	else

	insert into autobuses values(@matricula, @marca, @modelo, @NoAsientos, @añosServicio, @añoFabricacion, @kilometraje, @color, @estado, @conductorAsignado, @ayudanteAsignado, @ubicacionActual)
	
END

execute agregarAutobus '001', 'IRIZAR', 'I6', 43, 3, 2015, 14000, 'BEIGE', 'SERVICIO', '100', '200', 'LA ESPERANZA'
execute agregarAutobus '002', 'TOYOTA', 'COASTER', 43, 3, 2013, 12000, 'BLANCO', 'SERVICIO', '200', '100', 'LA ESPERANZA'

-- Modificar un autobus
CREATE PROCEDURE actualizarAutobus(@matricula varchar(25), @marca varchar(25), @modelo varchar(25) ,@NoAsientos int, @añosServicio int, @añoFabricacion int, @kilometraje int, @color varchar(25), @estado char(10), @conductorAsignado int, @ayudanteAsignado int, @ubicacionActual varchar(25))
AS BEGIN
	
	IF exists(select matricula from autobuses WHERE
		(matricula = @matricula))
		UPDATE autobuses set matricula = @matricula, marca = @marca, modelo =@modelo , NoAsientos = @NoAsientos, añosServicio =@añosServicio, añoFabricacion = @añoFabricacion, kilometraje= @kilometraje, color = @color, estado = @estado, conductorAsignado = @conductorAsignado, ayudanteAsignado = @ayudanteAsignado, ubicacionActual = @ubicacionActual
	else

		raiserror('NO EXISTE NINGUN AUTOBUS CON ESTA MATRICULA!', 16,1)

END


-- Eliminar un autobus
CREATE PROCEDURE eliminarAutobus(@matricula varchar(25))
AS BEGIN
	
	IF exists(select matricula from autobuses WHERE
		(matricula = @matricula))
		UPDATE autobuses set estado = 'UNNABLED', ubicacionActual = 'NO APLICA'
		else

		raiserror('NO EXISTE NINGUN AUTOBUS CON ESTA MATRICULA!', 16,1)

END

/* CREAR UN NUEVO ORDEN DE BUSES PARA EL DIA*/
CREATE PROCEDURE insertarOrdenSalida(@primeraHora time, @primeraSalida int, @segundaHora time, @segundaSalida int, @terceraHora time, @terceraSalida int, @cuartaHora time,
	@cuartaSalida int, @quintaHora time, @quintaSalida int, @sextaHora time, @sextaSalida int, @septimaHora time, @septimaSalida int, @octavaHora time, @octavaSalida int, @novenaHora time, @novenaSalida int, @decimaHora time, @decimaSalida int, @onceHora time, @onceSalida int, @doceHora time, @doceSalida int, @treceHora time,
	@treceSalida int, @catorceHora time, @catorceSalida int)

AS BEGIN
		
		INSERT INTO salidaDiaria VALUES(@primeraHora, @primeraSalida, @segundaHora, @segundaSalida, @terceraHora, @terceraSalida, @cuartaHora, @cuartaSalida, @quintaHora, @quintaSalida, @sextaHora, @sextaSalida, @septimaHora, @septimaSalida, @octavaHora, @octavaSalida, @novenaHora , @novenaSalida, @decimaHora, @decimaSalida, @onceHora, @onceSalida, @doceHora, @doceSalida, @treceHora, @treceSalida, @catorceHora, @catorceSalida)
END

execute insertarOrdenSalida '04:15',1, '04:45',2,'05:50',1,'07:00',2,'07:45',1,'08:30',2,'09:30',1,'10:30',1,'11:30',1,'12:30',1,'01:30',1,'02:20',1,'03:30',1,'04:30',1



/* CREAR UN NUEVO ORDEN DE BUSES PARA EL DIA*/
CREATE PROCEDURE insertarOrdenSalida(@primeraSalida int, @segundaSalida int, @terceraSalida int,
	@cuartaSalida int, @quintaSalida int, @sextaSalida int, @septimaSalida int, @octavaSalida int, @novenaSalida int, @decimaSalida int, @onceSalida int, @doceSalida int,
	@treceSalida int, @catorceSalida int)

AS BEGIN
		
		INSERT INTO salidaDiaria VALUES(@primeraSalida, @segundaSalida, @terceraSalida, @cuartaSalida, @quintaSalida, @sextaSalida, @septimaSalida, @octavaSalida, @novenaSalida, @decimaSalida, @onceSalida, @doceSalida, @treceSalida, @catorceSalida)
END

/*MODIFICAR EL ORDEN DE SALIDAS DE UN DIA*/
CREATE PROCEDURE modificarOrdenSalida(@id int, @primeraSalida int, @segundaSalida int, @terceraSalida int,
	@cuartaSalida int, @quintaSalida int, @sextaSalida int, @septimaSalida int, @octavaSalida int, @novenaSalida int, @decimaSalida int, @onceSalida int, @doceSalida int,
	@treceSalida int, @catorceSalida int)

AS BEGIN
		
		UPDATE salidaDiaria SET primeraSalida  = @primeraSalida, segundaSalida = @segundaSalida, terceraSalida = @terceraSalida, cuartaSalida = @cuartaSalida, quintaSalida = @quintaSalida, sextaSalida = @sextaSalida, septimaSalida = @septimaSalida, octavaSalida = @octavaSalida, novenaSalida = @novenaSalida, decimaSalida = @decimaSalida, onceSalida= @onceSalida, doceSalida = @doceSalida, treceSalida = @treceSalida, catorceSalida = @catorceSalida WHERE salidaDiaria.id = @id
END

/*ELIMINAR UNA ORDEN DE SALIDAS DE UN DIA*/
CREATE PROCEDURE eliminarOrdenSalida(@id int)

AS BEGIN
		
		DELETE FROM salidaDiaria WHERE salidaDiaria.id = @id
END


SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.primeraSalida = autobuses.id




-- Para TARIFAS

-- Insertar Una tarifa Nueva
CREATE PROCEDURE insertarTarifa(@costo int ,@estado varchar(25))
AS BEGIN
		IF exists(select costo from tarifas WHERE
		(costo = @costo))
		raiserror('ESTA TARIFA YA ESTA REGISTRADA', 16,1)

		else

		insert into tarifas VALUES(@costo, @estado)

END

execute insertarTarifa 70, 'ACTIVA'
execute insertarTarifa 35, 'ACTIVA'

-- Modificar una tarifa existente
CREATE PROCEDURE modificarTarifa(@costo int, @estado varchar(25))
AS BEGIN

		IF exists(select costo from tarifas WHERE
		(costo = @costo))
			UPDATE tarifas SET costo = @costo
		else
			raiserror('ESTA TARIFA NO EXISTE!', 16,1)

END

-- Eliminar una tarifa existente
CREATE PROCEDURE eliminarTarifa(@costo int)
AS BEGIN

		IF exists(select costo from tarifas WHERE
		(costo = @costo))
			UPDATE tarifas SET estado = 'UNNABLED'
		else
			raiserror('ESTA TARIFA NO EXISTE!', 16,1)

END

-- Para DESTINOS
-- Insertar un Destino
CREATE PROCEDURE agregarDestino(@codigoDestino varchar(10), @nombreDestino varchar(25), @precioViaje int , @estado varchar(25))
AS BEGIN
	
		IF exists(select codigoDestino from destinos WHERE
		(codigoDestino = @codigoDestino))
		raiserror('YA EXISTE UN CODIGO CON EL MISMO DESTINO!', 16,1)
		
		else
		insert into destinos VALUES(@codigoDestino, @nombreDestino, @precioViaje, @estado)

END

execute agregarDestino '111', 'SIGUATEPEQUE', 1, 'ACTIVO'
execute agregarDestino '222', 'JESUS DE OTORO', 2, 'ACTIVO'

-- Modificar un destino
CREATE PROCEDURE modificarDestino(@codigoDestino varchar(10), @nombreDestino varchar(25), @precioViaje int , @estado varchar(25))
AS BEGIN
	
		IF exists(select codigoDestino from destinos WHERE
		(codigoDestino = @codigoDestino))
			UPDATE destinos SET codigoDestino = @codigoDestino, nombreDestino = @nombreDestino, precioViaje = @precioViaje, estado = @estado)
		else
			raiserror('NO EXISTE NINGUN DESTINO CON EL CODIGO PROPORCIONADO!', 16,1)
END


-- Eliminar un Destino
CREATE PROCEDURE borrarDestino(@codigoDestino varchar(10))
AS BEGIN
	
		IF exists(select codigoDestino from destinos WHERE
		(codigoDestino = @codigoDestino))
			UPDATE destinos SET  estado = 'UNNABLED'
		else
			raiserror('NO EXISTE NINGUN DESTINO CON EL CODIGO PROPORCIONADO!', 16,1)
END

-- PARA LA BOLETERIA
CREATE PROCEDURE agregarBoleto(@fecha date, @codigoBoleto varchar(25), @identidadCliente varchar(13), @matriculaAutobus varchar(25), @numeroAsiento int, @terminalSalida varchar(25), @destino int)
AS BEGIN
	
		IF exists(select codigoBoleto from boleteria WHERE
		(codigoBoleto = @codigoBoleto)) 

		raiserror('YA EXISTE UN BOLETO CON EL MISMO CODIGO ó EL ASIENTO YA ESTA OCUPADO!', 16,1)
		
		else
		insert into boleteria VALUES(@fecha, @codigoBoleto, @identidadCliente, @matriculaAutobus, @numeroAsiento, @terminalSalida, @destino)

END

execute agregarBoleto 'N100', '1001200200094', '00001', 1, 'LA ESPERANZA', 1


CREATE PROCEDURE modificarBoleto(@fecha date, @codigoBoleto varchar(25), @identidadCliente varchar(13), @matriculaAutobus varchar(25), @numeroAsiento int, @terminalSalida varchar(25), @destino int)
AS BEGIN
	
		IF exists(select codigoBoleto from boleteria WHERE
		(codigoBoleto = @codigoBoleto)) 

				UPDATE boleteria SET fecha = @fecha, codigoBoleto = @codigoBoleto, identidadCliente = @identidadCliente, matriculaAutobus = @matriculaAutobus, numeroAsiento = @numeroAsiento, terminalSalida = @terminalSalida, destino = @destino

		else
		
		raiserror('NO HAY NINGUN BOLETO REGISTRADO CON ESTE CODIGO', 16,1)
END

CREATE PROCEDURE eliminarBoleto(@codigoBoleto varchar(25))
AS BEGIN
	
		IF exists(select codigoBoleto from boleteria WHERE
		(codigoBoleto = @codigoBoleto)) 

				DELETE FROM boleteria WHERE codigoBoleto = @codigoBoleto
		else
		
		raiserror('NO HAY NINGUN BOLETO REGISTRADO CON ESTE CODIGO', 16,1)
END



SELECT boleteria.codigoBoleto as 'Codigo Boleto', boleteria.identidadCliente as 'Identidad Cliente', concat(clientes.primerNombre,' ', clientes.segundoNombre) as 'Cliente', autobuses.marca as 'Marca Autobus', autobuses.modelo as 'Modelo Autobus', concat(EMP1.primerNombre,' ',EMP1.segundoApellido) as 'Conductor', concat(EMP2.primerNombre,' ', EMP2.segundoApellido) as 'AYUDANTE', destinos.nombreDestino as 'Destino', tarifas.costo as 'Precio'
FROM boleteria 
INNER JOIN clientes ON boleteria.identidadCliente = clientes.identidadCliente
INNER JOIN autobuses ON boleteria.matriculaAutobus = autobuses.matricula
INNER JOIN empleados as EMP1 ON autobuses.conductorAsignado = EMP1.codigo
INNER JOIN empleados as EMP2 ON autobuses.ayudanteAsignado = EMP2.codigo
INNER JOIN destinos ON boleteria.destino = destinos.id
INNER JOIN tarifas ON destinos.precioViaje = tarifas.id


SELECT matricula FROM salidaDiaria INNER JOIN autobuses WHERE autobuses.id = salidaDiaria.primeraSalida

SELECT nombreDestino FROM destinos WHERE destinos.id = 2
SELECT costo FROM destinos INNER JOIN tarifas ON destinos.id = 1 and destinos.precioViaje = tarifas.id

SELECT * FROM salidaDiaria

SELECT doceSalida  FROM salidaDiaria WHERE id = 1

SELECT primeraHora  FROM salidaDiaria WHERE id = 1

SELECT segundoHora  FROM salidaDiaria WHERE id = 1

select * from boleteria