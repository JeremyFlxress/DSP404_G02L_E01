Create Database TheTemperTrap

use TheTemperTrap

-- Tabla Cliente
CREATE TABLE Cliente (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Telefono NVARCHAR(20),
    Contraseña NVARCHAR(100) NOT NULL,
    Municipio NVARCHAR(50),
    Departamento NVARCHAR(50),
    Colonia NVARCHAR(100),
    NumeroCalle NVARCHAR(50)
);

-- Tabla Empleado
CREATE TABLE Empleado (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Celular NVARCHAR(20),
    FechaNacimiento DATE,
    FechaContratacion DATE NOT NULL,
    ContraseñaEmpleado NVARCHAR(100) NOT NULL,
    Municipio NVARCHAR(50),
    Departamento NVARCHAR(50),
    Colonia NVARCHAR(100),
    NumeroCalle NVARCHAR(50)
);

-- Tabla Producto
CREATE TABLE Producto (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Producto NVARCHAR(100) NOT NULL,
    Descripcion_del_Producto NVARCHAR(255),
    Precio_Unitario DECIMAL(10,2) NOT NULL
);

-- Tabla Pedido
CREATE TABLE Pedido (
    IDPedido INT PRIMARY KEY IDENTITY(1,1),
    ClienteID INT NOT NULL,
    EmpleadoID INT,
    FechaPedido DATE NOT NULL,
    EstadoPedido NVARCHAR(50),
    TotalPagar DECIMAL(10,2) NOT NULL,
    Comentario NVARCHAR(255),

    FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    FOREIGN KEY (EmpleadoID) REFERENCES Empleado(EmpleadoID)
);

-- Tabla DetallePedido
CREATE TABLE DetallePedido (
    DetallePedidoID INT PRIMARY KEY IDENTITY(1,1),
    IDPedido INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    FOREIGN KEY (IDPedido) REFERENCES Pedido(IDPedido),
    FOREIGN KEY (ProductoID) REFERENCES Producto(ProductoID)
);

-- Tabla Factura
CREATE TABLE Factura (
    FacturaID INT PRIMARY KEY IDENTITY(1,1),
    IDPedido INT NOT NULL,
    FechaTransaccion DATE NOT NULL,
    MontoTotal DECIMAL(10,2) NOT NULL,
    TipoPago NVARCHAR(50) NOT NULL,

    FOREIGN KEY (IDPedido) REFERENCES Pedido(IDPedido)
);

-- Índices
CREATE INDEX idx_Cliente_Correo ON Cliente(Correo);
CREATE INDEX idx_Empleado_Correo ON Empleado(Correo);
CREATE INDEX idx_Pedido_FechaPedido ON Pedido(FechaPedido);
CREATE INDEX idx_Factura_FechaTransaccion ON Factura(FechaTransaccion);
CREATE INDEX idx_DetallePedido_IDPedido ON DetallePedido(IDPedido);



-- Agregar ON DELETE CASCADE a las relaciones,  esto nos ayuda en caso de que si se elimina un cliente o empleado, los pedidos y otros datos relacionados quedarán "huérfanos",
--por eso, agregamos un ON DELETE CASCADE.
ALTER TABLE Pedido
ADD CONSTRAINT FK_Pedido_Cliente
FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID) 
ON DELETE CASCADE;

ALTER TABLE Pedido
ADD CONSTRAINT FK_Pedido_Empleado
FOREIGN KEY (EmpleadoID) REFERENCES Empleado(EmpleadoID) 
ON DELETE SET NULL;

ALTER TABLE DetallePedido
ADD CONSTRAINT FK_DetallePedido_Pedido
FOREIGN KEY (IDPedido) REFERENCES Pedido(IDPedido) 
ON DELETE CASCADE;

ALTER TABLE DetallePedido
ADD CONSTRAINT FK_DetallePedido_Producto
FOREIGN KEY (ProductoID) REFERENCES Producto(ProductoID) 
ON DELETE NO ACTION;

ALTER TABLE Factura
ADD CONSTRAINT FK_Factura_Pedido
FOREIGN KEY (IDPedido) REFERENCES Pedido(IDPedido) 
ON DELETE CASCADE;


--esto es para el apartado de estado del pedido, solo en caso de que el usuario no pueda agregar valores que no vayan acorde a nuestra base de datos
ALTER TABLE Pedido
ADD CONSTRAINT CHK_EstadoPedido CHECK (EstadoPedido IN ('Aceptado', 'En proceso de elaborar', 'Entregado al repartidor', 'Entregado al cliente'));


--manejo de algunas excepciones lógicas
-- Evitar precios o totales negativos
ALTER TABLE Producto
ADD CONSTRAINT CH_Precio_Unitario_Positive 
CHECK (Precio_Unitario >= 0);

ALTER TABLE Pedido
ADD CONSTRAINT CH_TotalPagar_Positive 
CHECK (TotalPagar >= 0);

ALTER TABLE Factura
ADD CONSTRAINT CH_MontoTotal_Positive 
CHECK (MontoTotal >= 0);


-- Insertar empleados predeterminados con sus credenciales
INSERT INTO Empleado (Nombre, Apellido, Correo, Celular, FechaNacimiento, FechaContratacion, ContraseñaEmpleado, Municipio, Departamento, Colonia, NumeroCalle)
VALUES 
('Josué', 'Pérez', 'josue.perez@thetempertrap.com', '12345678', '2006-07-30', '2023-08-31', 'Josue2302.', 'San Salvador', 'San Salvador', 'Colonia Centro', '123'),
('William', 'Figueroa', 'william.figueroa@thetempertrap.com', '87654321', '2005-07-09', '2023-07-23', 'William2332', 'Santa Ana', 'Santa Ana', 'Colonia Norte', '456'),
('Darwin', 'Rodriguez', 'darwin.rodriguez@thetempertrap.com', '11223344', '1982-03-12', '2022-09-30', 'Darwin2003.', 'Soyapango', 'San Salvador', 'Colonia Este', '789');



