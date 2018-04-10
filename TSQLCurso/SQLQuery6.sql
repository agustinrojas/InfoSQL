USE TutorialDB
CREATE TABLE Tabla04B
 (empno INT CONSTRAINT Itabla04B PRIMARY KEY,
  nombre NVARCHAR(15),
  profesion NVARCHAR(19),
  fechaalta DATE,
  salario DECIMAL(10,2),
  num_segsocial INT CONSTRAINT Itabla041B UNIQUE CLUSTERED
  );
