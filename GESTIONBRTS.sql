IF DB_ID('SistemaUsuario') IS NOT NULL
    DROP DATABASE SistemaUsuario;
GO

CREATE DATABASE SistemaUsuario;
GO



CREATE TABLE Provincia
(
    Id_Provincia INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_prov VARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Partido
(
    Id_Partido INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_partido VARCHAR(100) NOT NULL,
    Id_Provincia INT NOT NULL,

    CONSTRAINT FK_Partido_Provincia
    FOREIGN KEY (Id_Provincia)
    REFERENCES Provincia(Id_Provincia)
);
GO

CREATE TABLE Localidad
(
    Id_Localidad INT IDENTITY(1,1) PRIMARY KEY,
    Nombre_Local VARCHAR(100) NOT NULL,
    Codigo_Postal INT NOT NULL,
    Id_Partido INT NOT NULL,

    CONSTRAINT FK_Localidad_Partido
    FOREIGN KEY (Id_Partido)
    REFERENCES Partido(Id_Partido)
);
GO

CREATE TABLE Persona
(
    Id_Persona INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(30) NOT NULL,
    Apellido VARCHAR(30) NOT NULL,
    DNI INT NOT NULL UNIQUE,
    Imagen_URL NVARCHAR(200) NULL,
    Fecha_nac DATE NOT NULL,
    Fecha_Alta DATE NOT NULL DEFAULT GETDATE(),
    Fecha_baja DATE NULL,
    Activa BIT NOT NULL DEFAULT 1,
    Legajo AS ('LEG' + RIGHT('000' + CAST(Id_Persona AS VARCHAR(3)),3))
);
GO

CREATE TABLE Domicilio
(
    Id_Domicilio INT IDENTITY(1,1) PRIMARY KEY,
    Calle VARCHAR(40) NOT NULL,
    Altura INT NOT NULL,
    Piso VARCHAR(5) NULL,
    Depa VARCHAR(5) NULL,
    Id_Localidad INT NOT NULL,
    Principal BIT NOT NULL DEFAULT 1,

    CONSTRAINT FK_Domicilio_Localidad
    FOREIGN KEY (Id_Localidad)
    REFERENCES Localidad(Id_Localidad)
);
GO

CREATE TABLE Per_Dom
(
    Id_Persona INT NOT NULL,
    Id_Domicilio INT NOT NULL,

    PRIMARY KEY (Id_Persona, Id_Domicilio),

    FOREIGN KEY (Id_Persona)
    REFERENCES Persona(Id_Persona),

    FOREIGN KEY (Id_Domicilio)
    REFERENCES Domicilio(Id_Domicilio)
);
GO

CREATE TABLE Roles
(
    Id_Rol INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(40) NOT NULL UNIQUE
);
GO

CREATE TABLE Permisos
(
    Id_Permisos INT IDENTITY(1,1) PRIMARY KEY,
    Codigo INT NOT NULL UNIQUE,
    Descripcion VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Usuario
(
    Id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    user_name VARCHAR(30) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
    DiasValidezPass INT DEFAULT 30,
    DebeCambiarPass BIT NOT NULL DEFAULT 0,
    Activo BIT NOT NULL DEFAULT 1,
    Intentos_Fallidos INT NOT NULL DEFAULT 0,
    Hora_ult_Intento DATETIME NULL,
    Id_Rol INT NULL,
    Id_Persona INT NOT NULL,

    FOREIGN KEY (Id_Rol) REFERENCES Roles(Id_Rol),
    FOREIGN KEY (Id_Persona) REFERENCES Persona(Id_Persona)
);
GO

CREATE TABLE USER_B_A
(
    Id_Log INT IDENTITY(1,1) PRIMARY KEY,
    Id_usuario INT NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Tipo VARCHAR(100) NOT NULL,

    FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario)
);
GO

CREATE TABLE Roles_Perm
(
    Id_Rol INT NOT NULL,
    Id_Permisos INT NOT NULL,

    PRIMARY KEY (Id_Rol, Id_Permisos),
    FOREIGN KEY (Id_Rol) REFERENCES Roles(Id_Rol),
    FOREIGN KEY (Id_Permisos) REFERENCES Permisos(Id_Permisos)
);
GO

CREATE TABLE Us_Per
(
    Id_usuario INT NOT NULL,
    Id_Permisos INT NOT NULL,
    FechaI DATE NOT NULL DEFAULT GETDATE(),
    FechaC DATE NULL,

    PRIMARY KEY (Id_usuario, Id_Permisos),
    FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario),
    FOREIGN KEY (Id_Permisos) REFERENCES Permisos(Id_Permisos)
);
GO

CREATE TABLE Historial_Contrasenas
(
    Id_historial INT IDENTITY(1,1) PRIMARY KEY,
    Id_usuario INT NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Fecha_Cambio DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario)
);
GO

CREATE TABLE Preguntas
(
    PreguntaID INT IDENTITY(1,1) PRIMARY KEY,
    Preguntas VARCHAR(2000) NOT NULL
);
GO

CREATE TABLE Respuestas
(
    RespuestaID INT IDENTITY(1,1) PRIMARY KEY,
    Id_usuario INT NOT NULL,
    PreguntaID INT NOT NULL,
    Respuesta VARCHAR(1000) NOT NULL,

    FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario),
    FOREIGN KEY (PreguntaID) REFERENCES Preguntas(PreguntaID)
);
GO



CREATE PROC Registrar
(
    @Nombre VARCHAR(30),
    @Apellido VARCHAR(30),
    @DNI INT, -- Corregido a INT para machear con la tabla Persona
    @Imagen_URL VARCHAR(200),
    @Fecha_nac DATE,

    @Calle VARCHAR(40),
    @Altura INT,
    @Piso VARCHAR(5),
    @Depa VARCHAR(5),
    @Principal BIT,

    @Id_Provincia INT,
    @Id_Partido INT,
    @Id_Localidad INT,

    @Nombre_prov VARCHAR(100),
    @Nombre_partido VARCHAR(100),
    @Nombre_Local VARCHAR(100),
    @Codigo_Postal INT 
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NuevaPersona INT;
    DECLARE @NuevoDomicilio INT;

   
    IF NOT EXISTS (SELECT 1 FROM Provincia WHERE Id_Provincia = @Id_Provincia)
    BEGIN
        INSERT INTO Provincia (Nombre_prov) VALUES (@Nombre_prov);
        SET @Id_Provincia = SCOPE_IDENTITY();
    END

    
    IF NOT EXISTS (SELECT 1 FROM Partido WHERE Id_Partido = @Id_Partido)
    BEGIN
        INSERT INTO Partido (Nombre_partido, Id_Provincia) VALUES (@Nombre_partido, @Id_Provincia);
        SET @Id_Partido = SCOPE_IDENTITY();
    END

   
    IF NOT EXISTS (SELECT 1 FROM Localidad WHERE Id_Localidad = @Id_Localidad)
    BEGIN
        INSERT INTO Localidad (Nombre_Local, Codigo_Postal, Id_Partido) VALUES (@Nombre_Local, @Codigo_Postal, @Id_Partido);
        SET @Id_Localidad = SCOPE_IDENTITY();
    END

   
    INSERT INTO Persona (Nombre, Apellido, DNI, Imagen_URL, Fecha_nac) 
    VALUES (@Nombre, @Apellido, @DNI, @Imagen_URL, @Fecha_nac);

    SET @NuevaPersona = SCOPE_IDENTITY();

   
    INSERT INTO Domicilio (Calle, Altura, Piso, Depa, Id_Localidad, Principal) 
    VALUES (@Calle, @Altura, @Piso, @Depa, @Id_Localidad, @Principal);

    SET @NuevoDomicilio = SCOPE_IDENTITY();

    
    INSERT INTO Per_Dom (Id_Persona, Id_Domicilio) 
    VALUES (@NuevaPersona, @NuevoDomicilio);
END
GO

CREATE PROC ver_user_cont 
( 
    @user_name VARCHAR(50),
    @Password VARCHAR(50) 
)
AS 
BEGIN
    SELECT * FROM Usuario WHERE user_name = @user_name AND Password = @Password AND Activo = 1;
END 
GO

CREATE PROC sp_insert_rol 
(
    @Id_usuario INT, 
    @Id_Rol INT, 
    @Id_Permisos INT 
)
AS 
BEGIN 
    UPDATE Usuario SET Id_Rol = @Id_Rol WHERE Id_usuario = @Id_usuario;
    
    IF NOT EXISTS (SELECT 1 FROM Us_Per WHERE Id_usuario = @Id_usuario AND Id_Permisos = @Id_Permisos) 
    BEGIN 
        INSERT INTO Us_Per (Id_usuario, Id_Permisos, FechaI) 
        VALUES (@Id_usuario, @Id_Permisos, GETDATE()); 
    END
END
GO 


CREATE PROC sp_delete_permiso 
( 
    @Id_Permisos INT, 
    @Id_usuario INT, 
    @Id_Rol INT 
) 
AS 
BEGIN 
    DELETE FROM Us_Per WHERE Id_Permisos = @Id_Permisos AND Id_usuario = @Id_usuario;
   
    UPDATE Usuario SET Id_Rol = @Id_Rol WHERE Id_usuario = @Id_usuario; 
END
GO

CREATE PROC revocar_rol 
( 
    @Id_usuario INT,
    @Id_Rol INT 
) 
AS 
BEGIN 
    UPDATE Usuario SET Id_Rol = @Id_Rol WHERE Id_usuario = @Id_usuario; 
END
GO 


CREATE PROC Guardar_Historial 
( 
    @Id_usuario INT, 
    @Password VARCHAR(50) 
)
AS 
BEGIN 
    IF NOT EXISTS (SELECT 1 FROM Historial_Contrasenas WHERE Id_usuario = @Id_usuario AND Password = @Password) 
    BEGIN 
        INSERT INTO Historial_Contrasenas (Id_usuario, Password) 
        VALUES (@Id_usuario, @Password);
    END 
END
GO 

USE SistemaUsuario;
GO
Select * from Usuario;
go

CREATE PROC Usu_alta 
( 
    @user_name VARCHAR(30),
    @Password VARCHAR(30),
    @DiasValidezPass INT,
    @DebeCambiarPass BIT, 
    @Intentos_Fallidos INT,
    @Hora_ult_Intento DATETIME, 
    @Id_Rol INT, 
    @Id_Persona INT 
) 
AS 
BEGIN
    INSERT INTO Usuario (user_name, Password, DiasValidezPass, DebeCambiarPass, Activo, Intentos_Fallidos, Hora_ult_Intento, Id_Rol, Id_Persona)
    VALUES ( @user_name,
        @Password,
        @DiasValidezPass,
        @DebeCambiarPass,
        1,
        0,
        GETDATE(),
        @Id_Rol,
        @Id_Persona);
END
GO

 USE SistemaUsuario;
GO

CREATE PROC Usu_Baja 
( 
    @user_name VARCHAR(30) 
   
)
AS 
BEGIN
     UPDATE Usuario SET Activo = 0 WHERE user_name = @user_name;
END
GO 


USE SistemaUsuario;
GO
 
CREATE PROC Usu_Modif 
( 
    @user_name VARCHAR(30), 
    @Id_Rol INT 
)
AS 
BEGIN 
    UPDATE Usuario SET  Id_Rol = @Id_Rol WHERE user_name = @user_name;
END 
GO



INSERT INTO Persona (Nombre, Apellido, DNI, Imagen_URL, Fecha_nac) VALUES
('Iris','Tonjbo',45123456,NULL,'2007-03-15'), 
('Juan','Perez',40111222,NULL,'1999-05-10'), 
('Maria','Lopez',38999888,NULL,'2001-09-22'), 
('Carlos','Gomez',42123456,NULL,'1998-11-30'), 
('Lucia','Fernandez',43765432,NULL,'2003-07-18'), 
('Sofia','Ramirez',42999887,NULL,'2002-06-12'); 
GO 


INSERT INTO Provincia (Nombre_prov) VALUES 
('Buenos Aires'), ('Cordoba'), ('Santa Fe'), ('Mendoza'), ('Neuquen'), ('Salta'); 
GO 


INSERT INTO Partido (Nombre_partido, Id_Provincia) VALUES 
('La Plata',1), ('Moron',1), ('Capital',2), ('Rosario',3), ('Godoy Cruz',4), ('Neuquen Capital',5); 
GO 

 
INSERT INTO Localidad (Nombre_Local, Codigo_Postal, Id_Partido) VALUES 
('Tolosa',1900,1), ('Castelar',1712,2), ('Cordoba Centro',5000,3), ('Rosario Centro',2000,4), ('Godoy Cruz Centro',5501,5), ('Neuquen Centro',8300,6); 
GO 


INSERT INTO Domicilio (Calle, Altura, Piso, Depa, Id_Localidad, Principal) VALUES 
('San Martin',123,NULL,NULL,1,1), 
('Belgrano',456,'2','A',2,1), 
('Rivadavia',789,NULL,NULL,3,1), 
('Mitre',321,'1','B',4,1), 
('Sarmiento',654,NULL,NULL,5,1), 
('Alberdi',987,'3','C',6,1); 
GO 


INSERT INTO Roles (Nombre) VALUES 
('Administrador'), ('Supervisor'), ('Empleado'), ('Auditor'), ('Invitado'), ('Tecnico'); 
GO 


INSERT INTO Permisos (Codigo, Descripcion) VALUES 
(100,'Alta de usuarios'), (101,'Baja de usuarios'), (102,'Modificar usuarios'), (103,'Ver reportes'), (104,'Gestionar permisos'), (105,'Auditoria del sistema'); 
GO 


INSERT INTO Usuario (user_name, Password, DiasValidezPass, DebeCambiarPass, Activo, Intentos_Fallidos, Hora_ult_Intento, Id_Rol, Id_Persona) VALUES 
('juanp','1234',30,0,1,0,NULL,1,1), 
('mariag','1234',30,0,1,0,NULL,2,2), 
('carlosl','1234',30,0,1,0,NULL,3,3), 
('anam','1234',30,0,1,0,NULL,4,4), 
('luisf','1234',30,0,1,0,NULL,5,5), 
('sofiar','1234',30,0,1,0,NULL,6,6); 
GO

INSERT INTO Per_Dom (Id_Persona, Id_Domicilio) VALUES
(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6);
GO


INSERT INTO Roles_Perm (Id_Rol, Id_Permisos) VALUES
(1, 1), (1, 2), (1, 3), (1, 4), (1, 5), (1, 6),
(2, 1), (2, 3), (2, 4),
(3, 4),
(4, 4), (4, 6),
(6, 3), (6, 5);
GO


INSERT INTO Us_Per (Id_usuario, Id_Permisos, FechaI, FechaC) VALUES
(1, 1, '2026-01-10', NULL), 
(2, 4, '2026-02-15', NULL), 
(3, 3, '2026-03-20', NULL); 
GO


INSERT INTO USER_B_A (Id_usuario, Fecha, Tipo) VALUES
(1, GETDATE(), 'Inicio de sesión exitoso - Administrador'),
(2, GETDATE(), 'Modificación de registro de terceros'),
(3, GETDATE(), 'Intento de acceso a zona restringida bloqueado');
GO


INSERT INTO Historial_Contrasenas (Id_usuario, Password, Fecha_Cambio) VALUES
(1, 'admin123', '2026-01-01 08:00:00'),
(1, 'juanp2026', '2026-03-15 10:30:00'),
(2, 'maria.pass', '2026-02-10 14:22:00'),
(3, 'carlos998', '2026-04-01 09:15:00');
GO


INSERT INTO Preguntas (Preguntas) VALUES
('¿Cuál fue el nombre de tu primera mascota?'),
('¿En qué ciudad nació tu madre?'),
('¿Cuál es tu color favorito de la infancia?'),
('¿Cómo se llamaba tu primera escuela?');
GO


INSERT INTO Respuestas (Id_usuario, PreguntaID, Respuesta) VALUES
(1, 1, 'Firulais'),  
(2, 2, 'Córdoba'),   
(3, 3, 'Azul'),      
(4, 4, 'Dardo Rocha'); 
GO


