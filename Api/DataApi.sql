create database ApiProductos;
use  ApiProductos;
create table productos(
rowid int primary key,
nombre varchar(500),
descripcion varchar(900),
precio int
);

INSERT INTO `apiproductos`.`productos` (`rowid`, `nombre`, `descripcion`, `precio`) VALUES ('1', 'sopa', 'sopa descripcion', '12000');
