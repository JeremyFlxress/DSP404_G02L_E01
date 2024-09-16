use master
go
create database registro_de_notas;
go
use registro_de_notas
go
create table Alumno(
Codigo_alumno varchar(8),
nombre_alumno varchar(50),
PRIMARY KEY (Codigo_alumno) 
);
go
create table Cursos(
Codigo_curso varchar(8),
nombre_curso varchar(50),
PRIMARY KEY (Codigo_curso) 
);
go
create table notas(
Codigo_alumno varchar(8),
Codigo_curso varchar(8),
nota40T float,
nota60L float,
notaFinal float
);
go
ALTER TABLE notas ADD FOREIGN KEY(Codigo_alumno) REFERENCES Alumno(Codigo_alumno);
ALTER TABLE notas ADD FOREIGN KEY(Codigo_curso) REFERENCES Cursos(Codigo_curso);
