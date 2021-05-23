
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

CREATE TABLE Programare (
 Id int identity(1,1) primary key not null,
 NumePacient varchar(255) ,
 PrenumePacient varchar(255),
 CNP_Pacient int not null foreign key references Pacienti(CNP),
 Varsta int ,
 NrTelefon int ,
 Email varchar(255) ,
 CNP_Doctor int not null foreign key references Doctori(CNP),
 CNP_Asistent int not null foreign key references Asistenti(CNP),
 Ziua date,
 Ora time
);

CREATE TABLE Vizita (
	Id int identity(1,1) primary key not null,
	CNP_Doctor int not null foreign key references Doctori(CNP),
	CNP_Asistent int not null foreign key references Asistenti(CNP),
	CNP_Pacient int not null foreign key references Pacienti(CNP),
	Ora time ,
	Ziua date ,
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

INSERT INTO Programare
VALUES('Georgescu','Andrei',123456787,35,789523547,'andrei.georgescu@gmail.com',123456789,123456788,'2021-05-21','10:40:00');

INSERT INTO Vizita
VALUES(123456789,123456788,123456787,'10:40:00','2021-05-21',1,1,1);
 
 INSERT INTO Pacienti
VALUES (123456777,123456789,123456788,'Timar','Adelin',21,789523546,'adelin.timar@gmail.com');

INSERT INTO Programare
VALUES('Timar','Adelin',123456777,21,789523546,'adelin.timar@gmail.com',123456789,123456788,'2019-01-21','10:50:00');


INSERT INTO Vizita
VALUES(123456789,123456788,123456777,'10:50:00','2019-01-21',1,1,1);


INSERT INTO Pacienti
VALUES (111111111,123456789,123456788,'Lupastean','Iulian',21,754959944,'ilupastean@yahoo.com');

INSERT INTO Programare
VALUES('Lupastean','Iulian',111111111,21,754959944,'ilupastean@yahoo.com',123456789,123456788,'2021-04-21','10:50:00');


INSERT INTO Vizita
VALUES(123456789,123456788,111111111,'10:50:00','2021-03-21',1,1,1);
 


