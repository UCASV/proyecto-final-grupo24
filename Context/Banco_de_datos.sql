CREATE DATABASE PROYECTO_BD_POO
USE PROYECTO_BD_POO; 
SET LANGUAGE 'us_english';

--tablas en base a diagrama normalizado

CREATE TABLE APPOINTMENT (  --cita
 Id INT PRIMARY KEY IDENTITY, 
 Date_hour DATETIME, 
 Cabin_number INT,
 Id_employee INT,
 Dui_citizen INT,
);

CREATE TABLE EMPLOYEE ( --Empleado
  Id INT PRIMARY KEY,
  Username VARCHAR(50), 
  Password_user VARCHAR(50),
  institutional_mail VARCHAR(50),
  Addres_user VARCHAR(50), 
  Name_user VARCHAR(50), 
  Lastname_user VARCHAR(50),
  id_type_employee INT
);

CREATE TABLE TYPE_EMPLOYEE( --Tipo de empleado
 Id INT PRIMARY KEY IDENTITY, 
 Type_employee VARCHAR(50)
);

CREATE TABLE REGISTRY( --registro/ tabla cruz 
Cabin_number INT NOT NULL,
Id_employee INT NOT NULL,
CONSTRAINT PK_registry PRIMARY KEY (Cabin_number, Id_employee),
Date_hour DATETIME
); 

CREATE TABLE CABIN( --Cabina
 Cabin_number INT PRIMARY KEY IDENTITY,
 Email_cabin VARCHAR (50), 
 Phone INT,
 Adress_cabin VARCHAR (50)
);

CREATE TABLE CITIZEN ( --ciudadano 
 Dui INT PRIMARY KEY, 
 Age INT,
 Name_citizen VARCHAR(50),
 lastname_citizen VARCHAR (50),
 Address_citizen VARCHAR (50),
 Phone INT,
 Email_citizen VARCHAR(50),
 Institutional_identifier VARCHAR(50), 
 Id_position INT,
 Id_employee INT
);

CREATE TABLE DISEASE( --ENEFERMEDAD
Id INT PRIMARY KEY IDENTITY, 
Dui_citizen INT,
Disease VARCHAR(50)
);

CREATE TABLE POSITION ( --CARGO 
 Id INT PRIMARY KEY IDENTITY,
 Position VARCHAR(50) 
);

CREATE TABLE VACCINATION_PROCESS( --proceso de vacunación 
 Id INT PRIMARY KEY IDENTITY, 
 Row_date_time DATETIME, 
 Vaccination_date_time DATETIME,
 Seconddose_date_time DATETIME,
 Seconddose_cabin INT,
 id_employee INT,
 Dui_citizen INT,
 Cabin_number INT

);

CREATE TABLE SECONDARY_EFFECT (
 Id INT PRIMARY KEY IDENTITY,
 Id_process INT,
 Secondary_effect VARCHAR(50),
 Effect_minutes INT
);

ALTER TABLE APPOINTMENT ADD CONSTRAINT FK_Cabin_number FOREIGN KEY (Cabin_number) REFERENCES CABIN(Cabin_number);
ALTER TABLE APPOINTMENT ADD CONSTRAINT FK_Id_employee FOREIGN KEY (Id_employee) REFERENCES EMPLOYEE(Id);
ALTER TABLE APPOINTMENT ADD CONSTRAINT FK_Dui_citizen FOREIGN KEY (Dui_citizen) REFERENCES CITIZEN(Dui);

ALTER TABLE EMPLOYEE ADD CONSTRAINT FK_Id_type_employee FOREIGN KEY (id_type_employee) REFERENCES TYPE_EMPLOYEE(Id);

ALTER TABLE CITIZEN ADD CONSTRAINT FK_Id_position FOREIGN KEY (Id_position) REFERENCES POSITION(Id);
ALTER TABLE CITIZEN ADD CONSTRAINT FK_Id_employee_citizen FOREIGN KEY (Id_employee) REFERENCES EMPLOYEE(Id);

ALTER TABLE DISEASE ADD CONSTRAINT FK_Dui_citizen_disease FOREIGN KEY (Dui_citizen) REFERENCES CITIZEN(DUI);

ALTER TABLE VACCINATION_PROCESS ADD CONSTRAINT FK_Id_employee_process FOREIGN KEY (Id_employee) REFERENCES EMPLOYEE(Id);
ALTER TABLE VACCINATION_PROCESS ADD CONSTRAINT FK_Dui_citizen_process FOREIGN KEY (Dui_citizen) REFERENCES CITIZEN(Dui);
ALTER TABLE VACCINATION_PROCESS ADD CONSTRAINT FK_Cabin_number_process FOREIGN KEY (Cabin_number) REFERENCES CABIN(Cabin_number);

ALTER TABLE SECONDARY_EFFECT ADD CONSTRAINT FK_Id_process FOREIGN KEY (Id_process) REFERENCES VACCINATION_PROCESS(Id);

ALTER TABLE REGISTRY ADD CONSTRAINT FK_Cabin_number_registry FOREIGN KEY (Cabin_number) REFERENCES CABIN(Cabin_number);
ALTER TABLE REGISTRY ADD CONSTRAINT FK_Id_employee_registry FOREIGN KEY (Id_employee) REFERENCES EMPLOYEE(Id);


INSERT INTO TYPE_EMPLOYEE VALUES ('Medico');
INSERT INTO TYPE_EMPLOYEE VALUES ('Enfermero/a');
INSERT INTO TYPE_EMPLOYEE VALUES ('Voluntario/a');

INSERT INTO POSITION VALUES ('Personal del sistema de salud');
INSERT INTO POSITION VALUES ('Encargado/a de seguridad nacional');
INSERT INTO POSITION VALUES ('Personal del gobierno central');
INSERT INTO POSITION VALUES ('Otro');

INSERT INTO CABIN VALUES ('cabina1@gmail.com', 22778866, 'Avenida Las Margaritas #15, San Salvador');
INSERT INTO CABIN VALUES ('cabina2@gmail.com', 22445511, 'Avenida San Juan #8, La Libertad');
INSERT INTO CABIN VALUES ('cabina3@gmail.com', 77556632, 'Calle Las Rosas #333, San Miguel');
INSERT INTO CABIN VALUES ('cabina4@gmail.com', 25987431, 'Calle San Jose #25, Santa Ana');
INSERT INTO CABIN VALUES ('cabina5@gmail.com', 22278841, 'Barrio San Domingo #3456, San Vicente');

INSERT INTO EMPLOYEE VALUES (1, 'jperez', 'abcde', 'jperez@gov.sv', 'Los Cerezos #224, SS', 'Juan', 'Perez', 1);
INSERT INTO EMPLOYEE VALUES (2, 'mmartinez', '12345', 'mmartinez@gov.sv', 'San Marcos #345, LL', 'Marta', 'Martinez', 2);
INSERT INTO EMPLOYEE VALUES (3, 'nalas', '123abc', 'nalas@gov.sv', 'San Juan #15, SM', 'Nicolle', 'Alas', 1);
INSERT INTO EMPLOYEE VALUES (4, 'mfernandez', 'mf789', 'mfernandez@gov.sv', 'Los Rosales #88, SA', 'Martin', 'Fernandez', 3);
INSERT INTO EMPLOYEE VALUES (5, 'rlopez', 'rlo666', 'rlopez@gov.sv', 'San Francisco #220, SV', 'Roberto', 'Lopez', 3);


select * from EMPLOYEE
select * from CABIN
select * from REGISTRY
select * from CITIZEN
select * from DISEASE
select * from APPOINTMENT
select * from VACCINATION_PROCESS

delete from REGISTRY


delete from CITIZEN
delete from DISEASE
delete from APPOINTMENT