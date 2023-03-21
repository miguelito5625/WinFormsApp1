


TRUNCATE TABLE alumnos;
TRUNCATE TABLE grados;
TRUNCATE TABLE alumnos_grados;


CREATE TABLE alumnos (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombres VARCHAR(50) NOT NULL,
  apellidos VARCHAR(50) NOT NULL,
  edad INT
);

INSERT INTO alumnos (nombres, apellidos, edad) VALUES 
('Juan', 'Pérez', 18),
('María', 'García', 19),
('Luis', 'Martínez', 20),
('Ana', 'González', 19),
('Pedro', 'Hernández', 18),
('Lucía', 'Díaz', 19),
('Jorge', 'Sánchez', 20),
('Carla', 'Torres', 18),
('Diego', 'Flores', 19),
('Sofía', 'Ramírez', 20),
('David', 'López', 19),
('Paula', 'Vázquez', 18),
('Fernando', 'Castillo', 20),
('Luciana', 'Rojas', 19),
('Gustavo', 'Herrera', 18),
('Valentina', 'Alonso', 20),
('Carlos', 'Romero', 19),
('Laura', 'Fernández', 18),
('Andrés', 'Navarro', 20),
('Carmen', 'Ortiz', 19),
('Pablo', 'Ruíz', 18),
('Isabela', 'Molina', 20),
('Alejandro', 'Gómez', 19),
('Mónica', 'Sosa', 18),
('Gabriel', 'Jiménez', 20),
('Renata', 'Paz', 19),
('Arturo', 'Castañeda', 18),
('Marisol', 'Silva', 20),
('Felipe', 'Chávez', 19);


CREATE TABLE grados (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);

INSERT INTO grados (nombre) VALUES ('Primero');
INSERT INTO grados (nombre) VALUES ('Segundo');
INSERT INTO grados (nombre) VALUES ('Tercero');
INSERT INTO grados (nombre) VALUES ('Cuarto');
INSERT INTO grados (nombre) VALUES ('Quinto');
INSERT INTO grados (nombre) VALUES ('Sexto');



CREATE TABLE alumnos_grados (
  id INT IDENTITY(1,1) PRIMARY KEY,
  id_alumno INT NOT NULL,
  id_grado INT NOT NULL,
  FOREIGN KEY (id_alumno) REFERENCES alumnos(id),
  FOREIGN KEY (id_grado) REFERENCES grados(id)
);


-- Insertar alumnos en primer grado
INSERT INTO alumnos_grados (id_alumno, id_grado) VALUES
(1, 1), (2, 1), (3, 1), (4, 1), (5, 1);

-- Insertar alumnos en segundo grado
INSERT INTO alumnos_grados (id_alumno, id_grado) VALUES
(6, 2), (7, 2), (8, 2), (9, 2), (10, 2);

-- Insertar alumnos en tercer grado
INSERT INTO alumnos_grados (id_alumno, id_grado) VALUES
(11, 3), (12, 3), (13, 3), (14, 3), (15, 3);

-- Insertar alumnos en cuarto grado
INSERT INTO alumnos_grados (id_alumno, id_grado) VALUES
(16, 4), (17, 4), (18, 4), (19, 4), (20, 4);

-- Insertar alumnos en quinto grado
INSERT INTO alumnos_grados (id_alumno, id_grado) VALUES
(21, 5), (22, 5), (23, 5), (24, 5), (25, 5);

-- Insertar alumnos en sexto grado
INSERT INTO alumnos_grados (id_alumno, id_grado) VALUES
(26, 6), (27, 6), (28, 6), (29, 6), (30, 6);



SELECT alumnos.nombres, alumnos.apellidos, grados.nombre as grado
FROM alumnos
INNER JOIN alumnos_grados ON alumnos.id = alumnos_grados.id_alumno
INNER JOIN grados ON alumnos_grados.id_grado = grados.id;


CREATE VIEW vista_alumnos_grados AS
SELECT alumnos.nombres, alumnos.apellidos, grados.nombre as grado
FROM alumnos
INNER JOIN alumnos_grados ON alumnos.id = alumnos_grados.id_alumno
INNER JOIN grados ON alumnos_grados.id_grado = grados.id;



--DECLARE @names TABLE (name varchar(50))
--INSERT INTO @names (name) VALUES ('mike'), ('María'), ('Pedro');

--SELECT *
--FROM Alumnos
--WHERE Nombres IN (SELECT name FROM @names);
