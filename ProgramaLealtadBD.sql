Use DB_Grupo5;
--Use ProgramaDeLealtad;

/*
Drop table Dueno
drop table Franquicia
drop table SubFranquicia
drop table Restaurante
drop table Transacciones
drop table TransaccionesDeClientesDeLealtad
drop table TransaccionesDeClientesNormales
drop table PerteneceF
drop table PerteneceSF
drop table datosDeRestaurante
drop procedure CalculaDerivados
drop trigger Recalcula1
drop trigger Recalcula2
drop trigger Recalcula3
drop trigger Recalcula4
*/


create table Dueno (

Cedula varchar(20),
Nombre varchar(30),
Telefono varchar(20),

primary key (Cedula)
)

create table Franquicia (

NombreF varchar(30),
NumeroF varchar(30)

primary key (NombreF)

)

create table SubFranquicia (

NombreSF varchar(30),
NombreF	varchar(30),
NumeroSF varchar(30)

primary key (NombreSF),
foreign key (NombreF) references Franquicia(NombreF)


)

create table Restaurante (

Nombre varchar(30),
Telefono varchar(20),
NombreF		varchar(30),
NombreSF	varchar(30) null,

primary key (Nombre),
foreign key (NombreF) references Franquicia(NombreF),
foreign key (NombreSF) references SubFranquicia(NombreSF) on delete set default

)

create table datosDeRestaurante (

Mes varchar(3),
Anno int,
ClientesQueVuelven float,
PorcentajeNuevosClientes float,
NuveosClientes float,
ClientesQueVuelvenDespuesDeLaPrimeraCompra float,
NombreRestaurante varchar(30),

Primary key(NombreRestaurante,Mes, Anno),
Foreign Key (NombreRestaurante) references Restaurante(Nombre)

)

create table Transacciones (

Ano int,
Mes varchar(3),
Cantidad float,
Monto float,
Nombre varchar(30),

primary key (Ano, Mes,Nombre),
foreign key (Nombre) references Restaurante(Nombre),

)

create table TransaccionesDeClientesNormales (

Ano int,
Mes varchar(3), 
Nombre varchar(30),

primary key (Ano, Mes,Nombre),
foreign key (Ano, Mes,Nombre) references Transacciones (Ano, Mes,Nombre),
)

create table TransaccionesDeClientesDeLealtad (

Ano int,
Mes varchar(3), 
CantidadDeTransaccionesClientesDeLealtad float,
MontoDeClientesDeLealtad float,
Nombre varchar(30),

primary key (Ano, Mes,Nombre),
foreign key (Ano, Mes,Nombre) references Transacciones (Ano, Mes,Nombre),
)

create table PerteneceF (

NombreF varchar(30),
Cedula varchar (20),

primary key (NombreF, Cedula),
foreign key (NombreF) references Franquicia(NombreF),
foreign key (Cedula) references Dueno (Cedula)
)

create table PerteneceSF (

NombreSF varchar(30),
Cedula varchar (20),

primary key (NombreSF, Cedula),
foreign key (NombreSF) references SubFranquicia(NombreSF),
foreign key (Cedula) references Dueno (Cedula)

)

go
Create Procedure CalculaDerivados
	@Mes varchar(3), @Ano int, @Restaruante varchar(30)
as

	select cast( T.Cantidad as decimal) as 'Cantidad de Transacciones Totales',
		   cast( T.Monto as decimal) as 'Monto Total de Transacciones',
		   cast( TL.CantidadDeTransaccionesClientesDeLealtad as decimal) as 'Cantidad Transacciones Lealtad',
		   cast( TL.MontoDeClientesDeLealtad as decimal) as 'Monto Transacciones Lealtad',
		   TL.MontoDeClientesDeLealtad / TL.CantidadDeTransaccionesClientesDeLealtad as 'Chequeo Lealtad',
		   cast( T.Cantidad - TL.CantidadDeTransaccionesClientesDeLealtad as decimal) as 'Cantidad Transacciones Normales',
		   cast( T.Monto - TL.MontoDeClientesDeLealtad as decimal) as 'Monto Transacciones Normales',
		   ((T.Monto - TL.MontoDeClientesDeLealtad)/ (T.Cantidad - TL.CantidadDeTransaccionesClientesDeLealtad)) as 'Chequeo Normal',		   
		   ((TL.MontoDeClientesDeLealtad / TL.CantidadDeTransaccionesClientesDeLealtad)-((T.Monto - TL.MontoDeClientesDeLealtad)/ (T.Cantidad - TL.CantidadDeTransaccionesClientesDeLealtad))) / (((T.Monto - TL.MontoDeClientesDeLealtad)/ (T.Cantidad - TL.CantidadDeTransaccionesClientesDeLealtad)))*100 as '%Lift'
	from Transacciones T, TransaccionesDeClientesDeLealtad TL
	where T.Mes = @Mes and T.Ano = @Ano and TL.Mes = @Mes and TL.Ano = @Ano  and T.Nombre = @Restaruante and TL.Nombre = @Restaruante

go
create trigger Recalcula1
on TransaccionesDeClientesDeLealtad after update
as
declare @Mes int, @Año int, @Nombre varchar(30)
declare cursor1 cursor for
	select Mes, Ano, Nombre
	from inserted
	where Ano > 0 and Mes > 0
open cursor1
fetch next from cursor1 into @Mes, @Año, @Nombre
while @@FETCH_STATUS = 0 begin
	Exec CalculaDerivados @Mes,@Año,@Nombre --Ejecuta la consulta que calcula los derivados
	fetch next from cursor1 into @Mes, @Año, @Nombre
end
close cursor1
deallocate cursor1

go
create trigger Recalcula2
on Transacciones after update
as
declare @Mes int, @Año int, @Nombre varchar(30)
declare cursor1 cursor for
	select Mes, Ano, Nombre
	from inserted
	where Ano > 0 and Mes > 0 and Nombre != null
open cursor1
fetch next from cursor1 into @Mes, @Año, @Nombre
while @@FETCH_STATUS = 0 begin
	Exec CalculaDerivados @Mes,@Año,@Nombre --Ejecuta la consulta que calcula los derivados
	fetch next from cursor1 into @Mes, @Año, @Nombre
end
close cursor1
deallocate cursor1

go
create trigger Recalcula3
on datosDeRestaurante after update
as
declare @Mes int, @Año int, @Nombre varchar(30)
declare cursor1 cursor for
	select Mes, Anno, NombreRestaurante
	from inserted
	where Anno > 0 and Mes > 0 and NombreRestaurante != null
open cursor1
fetch next from cursor1 into @Mes, @Año, @Nombre
while @@FETCH_STATUS = 0 begin
	Exec CalculaDerivados @Mes,@Año,@Nombre --Ejecuta la consulta que calcula los derivados
	fetch next from cursor1 into @Mes, @Año, @Nombre
end
close cursor1
deallocate cursor1

delete from datosDeRestaurante
delete from TransaccionesDeClientesDeLealtad
delete from Transacciones
