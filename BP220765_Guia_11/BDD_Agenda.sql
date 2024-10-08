
Create Database Agenda;
Go
use Agenda;
Go
CREATE TABLE Login(
Usuario varchar(45) PRIMARY KEY,
contrasenia varchar(45)
);
Go
CREATE TABLE Contacto(
Id_Contacto int IDENTITY (1,1) PRIMARY KEY,
Nombre varchar(50) NOT NULL,
Apellido1 varchar(50)  NULL,
Correo varchar(50) NOT NULL,
Telefono varchar(8) NOT NULL,
Direcion varchar(150) NOT NULL,
Usuario varchar(45),
FOREIGN KEY(Usuario)REFERENCES Login(Usuario)
);
Go

insert into Login values ('mateo','123456');
insert into Login values ('pedro','123456');
insert into Login values ('juan','123456');
Go
insert into Contacto values('Karens','Medrano','karens.medrano@udb.edu.sv','22222222','UDB','pedro');
insert into Contacto values('Rene','Tejada','rene.tt@udb.edu.sv','55555555','UDB','pedro');
insert into Contacto values('Evelyn','Hernandez','evelynhernandez@udb.edu.sv','77777777','UDB','pedro');
insert into Contacto values('Marisol','Mejía','marisol.mejia@cdb.edu.sv','75817004','CDB','juan');
