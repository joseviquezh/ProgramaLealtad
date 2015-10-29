Use "ProgramaDeLealtad";


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
ClientesQueVuelven int,
PorcentajeNuevosClientes int,
NuveosClientes int,
ClientesQueVuelvenDespuesDeLaPrimeraCompra int,
NombreF		varchar(30),
NombreSF	varchar(30),

primary key (Nombre),
foreign key (NombreF) references Franquicia(NombreF),
foreign key (NombreSF) references SubFranquicia(NombreSF)

)

create table Transacciones (

Ano int,
Mes int,
Cantidad int,
Monto int,
Nombre varchar(30),

primary key (Ano, Mes),
foreign key (Nombre) references Restaurante(Nombre),

)

create table TransaccionesDeClientesNormales (

Ano int,
Mes int, 

primary key (Ano, Mes),
foreign key (Ano, Mes) references Transacciones (Ano, Mes)
)

create table TransaccionesDeClientesDeLealtad (

Ano int,
Mes int, 
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