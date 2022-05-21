use master
go

create database [TrainingDB]
COLLATE Cyrillic_General_CI_AI
go

use[TrainingDB]
go 

create table FuelTypes
(
[FuelTypeID] varchar(255) not null primary key
)
go

create table [Stations]
(
[Station_ID] int not null primary key
constraint [CheckID] check (Station_ID > 0 and Station_ID < 100),
[Address] varchar(max) not null
)
go

create table [data]
(
[ID] int not null primary key identity(1,1),
[Name] varchar(255) not null
constraint [FK_data_FuelType] foreign key ([Name]) references FuelTypes (FuelTypeID),
[Price] decimal (38,2) not null,
[AmountOfFuel] int not null,
[Station_ID] int not null 
constraint [FK_data_Stations] foreign key (Station_ID) references Stations(Station_ID) 
)
go

