CREATE DATABASE Turnover_SA_CV; 
GO
USE Turnover_SA_CV;
GO


CREATE TABLE Usuarios (
    IDUsuario INT PRIMARY KEY IDENTITY,
    Nombres NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) UNIQUE NOT NULL,
    Contraseña NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(15)
);

CREATE TABLE Empleado (
    IDEmpleado INT PRIMARY KEY IDENTITY,
    Nombres NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(15),
    Correo NVARCHAR(100) UNIQUE NOT NULL,
    Contraseña NVARCHAR(100) NOT NULL
);

CREATE TABLE Conciertos (
    IDConcierto INT PRIMARY KEY IDENTITY,
    Localizacion NVARCHAR(100) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,	
	Artista NVARCHAR(100) NOT NULL,
    Fecha DATE NOT NULL
);

CREATE TABLE Entradas (
    IDEntrada INT PRIMARY KEY IDENTITY,
    IDConcierto INT FOREIGN KEY REFERENCES Conciertos(IDConcierto) ON DELETE CASCADE,
    Localidad NVARCHAR(50) NOT NULL,
    CantidadDisponible INT NOT NULL CHECK (CantidadDisponible >= 0),
    Precio DECIMAL(10, 2) NOT NULL CHECK (Precio >= 0)
);

CREATE TABLE VentaEntradas (
    IDVenta INT PRIMARY KEY IDENTITY,
    IDEmpleado INT FOREIGN KEY REFERENCES Empleado(IDEmpleado) ON DELETE SET NULL
);

CREATE TABLE DetallesEntradas (
    IDVenta INT NOT NULL,
    IDEntrada INT NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad >= 0),
    CONSTRAINT PK_DetallesEntradas PRIMARY KEY (IDVenta, IDEntrada),
    CONSTRAINT FK_DetallesEntradas_VentaEntradas FOREIGN KEY (IDVenta) 
        REFERENCES VentaEntradas(IDVenta) ON DELETE CASCADE,
    CONSTRAINT FK_DetallesEntradas_Entradas FOREIGN KEY (IDEntrada) 
        REFERENCES Entradas(IDEntrada) ON DELETE CASCADE
);

CREATE TABLE Factura (
    IDFactura INT PRIMARY KEY IDENTITY,
    IDEmpleado INT FOREIGN KEY REFERENCES Empleado(IDEmpleado),
    IDUsuario INT FOREIGN KEY REFERENCES Usuarios(IDUsuario),
    IDVenta INT FOREIGN KEY REFERENCES VentaEntradas(IDVenta),
    FechaVenta DATE DEFAULT GETDATE(),
    Subtotal DECIMAL(10, 2) DEFAULT 0.0
);

CREATE TABLE HistorialCompra (
    IDHistorial INT PRIMARY KEY IDENTITY,
    IDFactura INT FOREIGN KEY REFERENCES Factura(IDFactura) ON DELETE CASCADE,
    FechaCompra DATE DEFAULT GETDATE(),
    CantidadEntradas INT NOT NULL CHECK (CantidadEntradas > 0)
);

-- Triggers
GO
-- Trigger para actualizar el subtotal de la factura cuando se agregan o modifican detalles de la venta
CREATE TRIGGER trgActualizarSubtotal
ON DetallesEntradas
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @IDVenta INT;
    SET @IDVenta = (SELECT DISTINCT IDVenta FROM inserted);
    
    DECLARE @total DECIMAL(10, 2);
    SELECT @total = SUM(d.Cantidad * e.Precio)
    FROM DetallesEntradas d
    JOIN Entradas e ON d.IDEntrada = e.IDEntrada
    WHERE d.IDVenta = @IDVenta;

    UPDATE Factura
    SET Subtotal = @total
    WHERE IDVenta = @IDVenta;
END
GO

-- Trigger para registrar la compra en el historial de compra después de insertar una factura
CREATE TRIGGER trgRegistrarCompraEnHistorial
ON Factura
AFTER INSERT
AS
BEGIN
    DECLARE @IDFactura INT = (SELECT IDFactura FROM inserted);
    DECLARE @IDVenta INT = (SELECT IDVenta FROM inserted);
    DECLARE @cantidadEntradas INT;
    
    SELECT @cantidadEntradas = SUM(Cantidad)
    FROM DetallesEntradas
    WHERE IDVenta = @IDVenta;

    INSERT INTO HistorialCompra (IDFactura, FechaCompra, CantidadEntradas)
    VALUES (@IDFactura, GETDATE(), @cantidadEntradas);
END
GO

-- Procedimientos almacenados CRUD para Conciertos

-- Crear Concierto
CREATE PROCEDURE ST_CrearConcierto
    @Localizacion NVARCHAR(100),
    @Nombre NVARCHAR(100),
    @Fecha DATE
AS
BEGIN
    IF @Nombre IS NULL OR @Fecha IS NULL
    BEGIN
        THROW 50001, 'Nombre y Fecha son campos obligatorios', 1;
    END
    ELSE
    BEGIN
        INSERT INTO Conciertos (Localizacion, Nombre, Fecha)
        VALUES (@Localizacion, @Nombre, @Fecha);
    END
END
GO

-- Actualizar Concierto
CREATE PROCEDURE ST_ActualizarConcierto
    @IDConcierto INT,
    @Localizacion NVARCHAR(100),
    @Nombre NVARCHAR(100),
    @Fecha DATE
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Conciertos WHERE IDConcierto = @IDConcierto)
    BEGIN
        THROW 50002, 'El concierto no existe', 1;
    END
    ELSE
    BEGIN
        UPDATE Conciertos
        SET Localizacion = @Localizacion, Nombre = @Nombre, Fecha = @Fecha
        WHERE IDConcierto = @IDConcierto;
    END
END
GO

-- Eliminar Concierto
CREATE PROCEDURE ST_EliminarConcierto
    @IDConcierto INT
AS
BEGIN
    DELETE FROM Conciertos WHERE IDConcierto = @IDConcierto;
END;
GO

-- Leer Conciertos
CREATE PROCEDURE ST_LeerConciertos
AS
BEGIN
    SELECT * FROM Conciertos;
END;
GO

-- Procedimientos almacenados CRUD para Entradas

-- Crear Entrada
CREATE PROCEDURE ST_CrearEntrada
    @IDConcierto INT,
    @Localidad NVARCHAR(50),
    @CantidadDisponible INT,
    @Precio DECIMAL(10,2)
AS
BEGIN
    IF @IDConcierto IS NULL OR @CantidadDisponible < 1 OR @Precio < 0
    BEGIN
        THROW 50003, 'Datos inválidos para la entrada', 1;
    END
    ELSE
    BEGIN
        INSERT INTO Entradas (IDConcierto, Localidad, CantidadDisponible, Precio)
        VALUES (@IDConcierto, @Localidad, @CantidadDisponible, @Precio);
    END
END
GO

-- Actualizar Entrada
CREATE PROCEDURE ST_ActualizarEntrada
    @IDEntrada INT,
    @CantidadDisponible INT,
    @Precio DECIMAL(10,2)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Entradas WHERE IDEntrada = @IDEntrada)
    BEGIN
        THROW 50004, 'La entrada no existe', 1;
    END
    ELSE
    BEGIN
        UPDATE Entradas
        SET CantidadDisponible = @CantidadDisponible, Precio = @Precio
        WHERE IDEntrada = @IDEntrada;
    END
END
GO

-- Eliminar Entrada
CREATE PROCEDURE ST_EliminarEntrada
    @IDEntrada INT
AS
BEGIN
    DELETE FROM Entradas WHERE IDEntrada = @IDEntrada;
END
GO

-- Leer Entradas
CREATE PROCEDURE ST_LeerEntradas
AS
BEGIN
    SELECT * FROM Entradas;
END
GO

-- Procedimientos almacenados CRUD para Usuarios

-- Crear Usuario
CREATE PROCEDURE ST_CrearUsuario
    @Nombres NVARCHAR(100),
    @Apellidos NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contraseña NVARCHAR(100),
    @Telefono NVARCHAR(15)
AS
BEGIN
    IF @Nombres IS NULL OR @Apellidos IS NULL OR @Correo IS NULL OR @Contraseña IS NULL
    BEGIN
        THROW 50005, 'Faltan datos obligatorios para el usuario', 1;
    END
    ELSE
    BEGIN
        INSERT INTO Usuarios (Nombres, Apellidos, Correo, Contraseña, Telefono)
        VALUES (@Nombres, @Apellidos, @Correo, @Contraseña, @Telefono);
    END
END
GO

-- Actualizar Usuario
CREATE PROCEDURE ST_ActualizarUsuario
    @IDUsuario INT,
    @Telefono NVARCHAR(15)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE IDUsuario = @IDUsuario)
    BEGIN
        THROW 50006, 'El usuario no existe', 1;
    END
    ELSE
    BEGIN
        UPDATE Usuarios
        SET Telefono = @Telefono
        WHERE IDUsuario = @IDUsuario;
    END
END
GO

-- Eliminar Usuario
CREATE PROCEDURE ST_EliminarUsuario
    @IDUsuario INT
AS
BEGIN
    DELETE FROM Usuarios WHERE IDUsuario = @IDUsuario;
END
GO

-- Leer Usuarios
CREATE PROCEDURE ST_LeerUsuarios
AS
BEGIN
    SELECT * FROM Usuarios;
END
GO

IF EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_DetallesEntradas_VentaEntradas')
    ALTER TABLE DetallesEntradas DROP CONSTRAINT FK_DetallesEntradas_VentaEntradas;
IF EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_DetallesEntradas_Entradas')
    ALTER TABLE DetallesEntradas DROP CONSTRAINT FK_DetallesEntradas_Entradas;

GO

INSERT INTO Empleado VALUES('Josue', 'Garcia', '7675-3999', 'josue@gmail.com', '12345');