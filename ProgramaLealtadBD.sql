Use DB_Grupo5;

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
ClientesQueVuelven int,
PorcentajeNuevosClientes int,
NuveosClientes int,
ClientesQueVuelvenDespuesDeLaPrimeraCompra int,
NombreRestaurante varchar(30),

Primary key(NombreRestaurante,Mes, Anno),
Foreign Key (NombreRestaurante) references Restaurante(Nombre)

)

create table Transacciones (

Ano int,
Mes varchar(3),
Cantidad int,
Monto int,
Nombre varchar(30),

primary key (Ano, Mes),
foreign key (Nombre) references Restaurante(Nombre),

)

create table TransaccionesDeClientesNormales (

Ano int,
Mes varchar(3), 

primary key (Ano, Mes),
foreign key (Ano, Mes) references Transacciones (Ano, Mes)
)

create table TransaccionesDeClientesDeLealtad (

Ano int,
Mes varchar(3), 
CantidadDeTransaccionesClientesDeLealtad int,
MontoDeClientesDeLealtad int,


primary key (Ano, Mes),
foreign key (Ano, Mes) references Transacciones (Ano, Mes)

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
	@Mes int, @Ano int, @Restaruante varchar(30)
as
	declare @chequeoLealtad float,
	@cantidadTN float,
	@montoTN float

	select @cantidadTN = T.Cantidad - TL.CantidadDeTransaccionesClientesDeLealtad,
		   @montoTN = T.Monto - TL.MontoDeClientesDeLealtad,
		   @chequeoLealtad = cast(TL.MontoDeClientesDeLealtad as decimal) / TL.CantidadDeTransaccionesClientesDeLealtad
	from Transacciones T, TransaccionesDeClientesDeLealtad TL
	where T.Mes = @Mes and T.Ano = @Ano and TL.Mes = @Mes and TL.Ano = @Ano and Nombre = @Restaruante

	select T.Cantidad - TL.CantidadDeTransaccionesClientesDeLealtad as 'Cantidad Transacciones Normales',
		   T.Monto - TL.MontoDeClientesDeLealtad as 'Monto Transacciones Normales',
		   cast(TL.MontoDeClientesDeLealtad as decimal) / TL.CantidadDeTransaccionesClientesDeLealtad as 'Chequeo Lealtad',
		   @montoTN / @cantidadTN  as 'Chequeo Normal',
		   (@chequeoLealtad - (@montoTN / @cantidadTN))/(@montoTN / @cantidadTN) as '%Lift'
	from Transacciones T, TransaccionesDeClientesDeLealtad TL
	where T.Mes = @Mes and T.Ano = @Ano and TL.Mes = @Mes and TL.Ano = @Ano  and Nombre = @Restaruante