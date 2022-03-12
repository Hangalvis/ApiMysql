create database ApiProductos;
use  ApiProductos;
create table productos(
rowid int primary key,
nombre varchar(500),
descripcion varchar(900),
precio int
);

INSERT INTO `apiproductos`.`productos` (`rowid`, `nombre`, `descripcion`, `precio`) VALUES ('1', 'sopa', 'sopa descripcion', '12000');

alter table productos add img varchar(500);

UPDATE `apiproductos`.`productos` SET `img` = 'https://www.hola.com/imagenes/cocina/recetas/20171013100547/receta-sopa-pollo/0-741-140/sopa-pollo-m.jpg' WHERE (`rowid` = '1');

