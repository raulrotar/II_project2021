
USE DentalApp1

CREATE TABLE Doctori (
	CNP int not null primary key,
	Nume varchar(255),
	Prenume varchar(255),
	Username varchar(255),
	Email varchar(255),
	Parola varchar(255),
	Nr_Telefon int,
	Security_Code varchar(255)
);

CREATE TABLE Asistenti (
	CNP int not null primary key,
	CNP_Doctor int not null foreign key references Doctori(CNP),
	Nume varchar(255),
	Prenume varchar(255),
	Username varchar(255),
	Email varchar(255),
	Parola varchar(255),
	Nr_Telefon int,
	Security_Code varchar(255)
);

CREATE TABLE Pacienti (
	CNP int not null primary key,
	CNP_Doctor int not null foreign key references Doctori(CNP),
	CNP_Asistent int not null foreign key references Asistenti(CNP),
	Nume varchar(255),
	Prenume varchar(255),
	Varsta int,
	Nr_Telefon int,
	Email varchar(255)
);

CREATE TABLE Lucrari (
	Id int identity(1,1) primary key not null,
	Nume varchar(255),
	Pret int
);

CREATE TABLE Diagnostic (
	Id int identity(1,1) primary key not null,
	Nume varchar(255)
);

CREATE TABLE Tratament (
	Id int identity(1,1) primary key not null,
	Nume varchar(255)
);

CREATE TABLE Vizita (
	Id int identity(1,1) primary key not null,
	CNP_Doctor int not null foreign key references Doctori(CNP),
	CNP_Asistent int not null foreign key references Asistenti(CNP),
	CNP_Pacient int not null foreign key references Pacienti(CNP),
	Ora time,
	Ziua date,
	Id_Lucrare int not null foreign key references Lucrari(Id),
	Id_Diagnostic int not null foreign key references Diagnostic(Id),
	Id_Tratament int not null foreign key references Tratament(Id)
);

SELECT * FROM Doctori
SELECT * FROM Asistenti
SELECT * FROM Pacienti
SELECT * FROM Lucrari
SELECT * FROM Tratament
SELECT * FROM Diagnostic
SELECT * FROM Vizita

INSERT INTO Doctori 
VALUES (123456789,'Popescu','Ion','ion.popescu','ion.popescu@gmail.com','1234',789523545,'Titi');

INSERT INTO Asistenti 
VALUES (123456788,123456789,'Ionescu','Andreea','andreea.ionescu','andreea.ionescu@gmail.com','1234',789523546,'Paul');

INSERT INTO Pacienti
VALUES (123456787,123456789,123456788,'Georgescu','Andrei',35,789523547,'andrei.georgescu@gmail.com');

INSERT INTO Lucrari
VALUES('Extragere dinte',100);

INSERT INTO Tratament 
VALUES('Compresa')

INSERT INTO Diagnostic
VALUES('Infectie')

INSERT INTO Vizita
VALUES(123456789,123456788,123456787,CONVERT(time, SYSDATETIME()),CONVERT(date, SYSDATETIME()),1,1,1);

