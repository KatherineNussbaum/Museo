
CREATE TABLE Tipo(
	Id int Primary Key NOT NULL IDENTITY(1,1),
	TipoPersona nvarchar(50) NOT NULL UNIQUE
);

CREATE TABLE Persona (
	Rut nvarchar(8) Primary Key NOT NULL,
	Div char(1) NOT NULL,
	Nombres nvarchar(250) NOT NULL,
	ApPaterno nvarchar(250) Not Null,
	ApMaterno nvarchar(250),
	Sexo char(1),
	FechaNacimiento smalldatetime,
	Domicilio nvarchar(250),
	Fono nvarchar(11),
	Email nvarchar(250),
	Tipo int
	FOREIGN KEY (Tipo) References Tipo(Id)
);


CREATE TABLE Ubicacion (
	Id int Primary Key NOT NULL IDENTITY(1,1),
	Salon nvarchar(250) UNIQUE,
	Iluminacion int,
	MaxObras int,
	MetrosCuadrados int
);

CREATE TABLE Obra (
	Codigo nvarchar(20) Primary Key NOT NULL,
	ArtistaRut nvarchar(8) NOT NULL,
	Estilo nvarchar(250),
	Valor BigInt,
	Dimensiones nvarchar(250),
	Procedencia nvarchar(250),
	CuidadosEspeciales nvarchar(250),
	UbicacionId int NOT NULL,
	FechaIngreso smalldatetime NOT NULL,
	Foreign Key (ArtistaRut) References Persona(Rut),
	Foreign Key (UbicacionId) References Ubicacion(Id)
);
CREATE TABLE Usuarios (
	Usuario nvarchar(100) Primary Key NOT NULL,
	Pass nvarchar(250)
);


INSERT INTO dbo.Tipo (TipoPersona) VALUES ('Artista');
INSERT INTO dbo.Tipo (TipoPersona) VALUES ('Funcionario');
INSERT INTO dbo.Tipo (TipoPersona) VALUES ('Ambos');

INSERT INTO dbo.Usuarios (Usuario, Pass) VALUES ('admin', 'admin');

INSERT INTO dbo.Ubicacion (Salon, Iluminacion, MaxObras, MetrosCuadrados) VALUES ('Espiritu Libre', 200, 5, 20);
INSERT INTO dbo.Ubicacion (Salon, Iluminacion, MaxObras, MetrosCuadrados) VALUES ('Mar Brillante', 800, 10, 50);
INSERT INTO dbo.Ubicacion (Salon, Iluminacion, MaxObras, MetrosCuadrados) VALUES ('Niebla', 40, 8, 30);

INSERT INTO dbo.Persona (Rut, Div, Nombres, ApPaterno, ApMaterno, Sexo, FechaNacimiento, Domicilio, Fono, Email, Tipo) VALUES ('10403861','1','Katherine', 'Nussbaum', 'Niccoli', 'F', '1979-03-04', 'La Concepción 121, Depto 35 B', '971359903', 2);
INSERT INTO dbo.Persona (Rut, Div, Nombres, ApPaterno, ApMaterno, Sexo, FechaNacimiento, Domicilio, Fono, Email, Tipo) VALUES ('7777777','7','Fernanda', 'Fernández', 'Fernández', 'F', '1970-08-08', null, null, 1);
INSERT INTO dbo.Persona (Rut, Div, Nombres, ApPaterno, ApMaterno, Sexo, FechaNacimiento, Domicilio, Fono, Email, Tipo) VALUES ('8585858','5','Juan', 'Pérez', 'González', 'M', '1968-05-05', null, null, 1);
