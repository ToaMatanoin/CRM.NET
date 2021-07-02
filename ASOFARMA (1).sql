--Creacion del script para ASOFARMA
--Fecha 6/5/2021

--Creacion de base de datos

use master
if exists (select * from sys.databases where name ='ASOFARMA') 
drop database ASOFARMA
create database ASOFARMA
go
use ASOFARMA
go

--exec InsertarEmpleado 'Prueba',22222222,'pruebasvarias72000@gmail.com','pv72000g','Su Casa','tester'
--exec InsertarUsuario 'tester','1234','Admin','1'


--Creacion de Tablas

create table Cliente
(
ID_Cliente int identity(1,1) not null,
Cli_Nombre varchar(45) not null,
Cli_Telefono int not null,
Cli_Email varchar(45) not null,
Cli_NombreEmpresa varchar(45) not null,
Cli_TelEmpresa int not null,
Cli_EmailEmpresa varchar(45) not null,
RTN varchar(20) not null
primary key(ID_Cliente)
)
go

create table Empleado
(
ID_Empleado int identity(1,1) not null,
Emp_Nombre varchar(45) not null,
Emp_Telefono int not null,
Emp_Email varchar(45) not null,
Emp_Email_Pass varchar(45) not null,
Emp_Direccion varchar(100) not null,
Emp_Cargo varchar(20) not null
primary key(ID_Empleado)
)
go

create table Inventario
(
ID_Producto int identity(1,1) not null,
Pro_Nombre varchar(45) not null,
Pro_Cantidad int not null,
Pro_PreVenta float not null,
Pro_PreFabricacion float not null,
Nombre_Compuesto varchar(20) not null,
Pro_Disponible int not null 
primary key(ID_Producto)
)
go

create table Usuarios(
ID_Usuario int identity (1,1) not null,
Usu_Nombre varchar(30) unique not null,
Usu_Contrasenha varchar(20) not null,
Usu_Cargo varchar(20) not null,
ID_Empleado int not null
primary key(ID_Usuario),
foreign key(ID_Empleado) references Empleado(ID_Empleado)
)
go


create table Ventas(
ID_Venta int identity (1,1) not null,
ID_Usuario int not null,
ID_Cliente int not null,
ID_Producto int not null,
Ven_Fecha varchar(15) not null,
Ven_CantVendida int not null,
Ven_Subtotal float not null,
Num_venta int 

primary key(ID_Venta)
foreign key(ID_Usuario) references Usuarios(ID_Usuario),
foreign key(ID_Cliente) references Cliente(ID_Cliente),
foreign key(ID_Producto) references Inventario(ID_Producto)
)
go

--create table Email(
--ID_Email int identity(1,1) not null,
--ID_Empleado int not null,
--ID_Cliente int not null,
--Email_Asunto varchar(40) not null,
--Email_Mensaje varchar(250) not null,
--Email_Fecha varchar(15) not null
--primary key(ID_Email)
--foreign key(ID_Empleado) references Empleado(ID_Empleado),
--foreign key(ID_Cliente) references Cliente(ID_Cliente)
--)
--go

create table Factura(
ID_Factura int identity (1,1) not null,
ID_Venta int not null,
Tp_Venta varchar(20) not null,
Fac_Descuento float not null,
Fac_Impuesto float not null,
Fac_RTN varchar(20) not null,
Fac_Total float not null,
Num_venta int 

primary key(ID_Factura),
foreign key(ID_Venta) references Ventas(ID_Venta)
)
go

--create table Devoluciones(
--ID_Devolu int identity(1,1) not null,
--ID_Factura int not null,
--Descripcion varchar(50) not null,
--Fecha_Devolu varchar(15) not null
--primary key(ID_Devolu)
--foreign key(ID_Factura) references Factura(ID_Factura)
--)
--go

create table Oportunidades(
ID_Oport int identity(1,1) not null,
ID_Usuario int not null,
Nombre_CliPoten varchar(40) not null,
Descripcion varchar(50) not null,
Posibi_Nego varchar(2) not null,
Tel_CliPoten varchar(10) not null,
Email_CliPoten varchar(30) not null
primary key(ID_Oport),
foreign key(ID_Usuario) references Usuarios(ID_Usuario)
)
go

create table Marketing(
ID_Marketing int identity(1,1) not null,
ID_Usuario int not null,
ID_Producto int not null,
ID_Cliente int not null,
Estrategia varchar(50) not null,
Descripcion varchar(100) not null
primary key(ID_Marketing),
foreign key(ID_Usuario) references Usuarios(ID_Usuario),
foreign key(ID_Producto) references Inventario(ID_Producto),
foreign key(ID_Cliente) references Cliente(ID_Cliente)
)
go

create table Proyectos_Marketing(
ID_Proyecto int identity(1,1) not null,
ID_Marketing int not null,
Nombre_Proyecto varchar(30) not null,
Descripcion varchar(100) not null,
Fecha_Inicial varchar(15) not null,
Fecha_Conclusion varchar(15) not null
primary key(ID_Proyecto),
foreign key(ID_Marketing) references Marketing(ID_Marketing)
)
go

create table Tareas_Marketing(
ID_Tarea int identity(1,1) not null,
ID_Marketing int not null,
Nombre_Tarea varchar(30) not null,
Descripcion varchar(100) not null,
Fecha_Inicial varchar(15) not null,
Fecha_Conclusion varchar(15) not null
primary key(ID_Tarea),
foreign key(ID_Marketing) references Marketing(ID_Marketing)
)
go

create procedure DashboardDatos
@totventas float out,
@nprod int out,
@nemp int out,
@ncli int out,
@nclipo int out
as
set @totventas = (select sum(Fac_Total) as totventas from Factura)
set @nprod = (select count(ID_Producto) as CantProductos from Inventario)
set @nemp = (select count(ID_Empleado) as CantEmpleados from Empleado)
set @ncli = (select count(ID_Cliente) as CantClientes from Cliente)
set @nclipo = (select count(ID_Oport) as CantClientesPotenciales from Oportunidades)
go

create proc prodpreferidos
as
select top 5 I.Pro_Nombre as Producto, COUNT(Ventas.ID_Producto) as NroVentas from Ventas
inner join Inventario as I on I.ID_Producto = Ventas.ID_Producto
group by Ventas.ID_Producto,I.Pro_Nombre
order by COUNT (5) desc
go

--Procedimientos Mostrar

create procedure MostrarCliente
as select dbo.Cliente.ID_Cliente,
dbo.Cliente.Cli_Nombre,
dbo.Cliente.Cli_Telefono,
dbo.Cliente.Cli_Email,
dbo.Cliente.Cli_NombreEmpresa,
dbo.Cliente.Cli_TelEmpresa,
dbo.Cliente.Cli_EmailEmpresa,
dbo.Cliente.RTN
from dbo.Cliente
order by dbo.Cliente.ID_Cliente desc
go

create procedure MostrarEmpleado
as
select * from dbo.Empleado
order by dbo.Empleado.ID_Empleado desc
go

create procedure MostrarInventario
as
select * from dbo.Inventario
order by dbo.Inventario.ID_Producto desc
go

create procedure MostrarUsuario
as select dbo.Usuarios.ID_Usuario,
dbo.Usuarios.Usu_Nombre,
dbo.Usuarios.Usu_Cargo,
dbo.Usuarios.Usu_Contrasenha,
dbo.Empleado.ID_Empleado,
dbo.Empleado.Emp_Nombre,
dbo.Empleado.Emp_Email

from dbo.Usuarios inner join dbo.Empleado on
dbo.Usuarios.ID_Empleado=dbo.Empleado.ID_Empleado 
order by dbo.Usuarios.ID_Usuario desc
go

create procedure MostrarVentas
as select dbo.Ventas.ID_Venta,
dbo.Usuarios.ID_Usuario,
dbo.Usuarios.Usu_Nombre,
dbo.Cliente.ID_Cliente,
dbo.Cliente.Cli_NombreEmpresa,
dbo.Inventario.ID_Producto,
dbo.Inventario.Pro_Nombre,
dbo.Ventas.Ven_Fecha,
dbo.Ventas.Ven_CantVendida,
dbo.Ventas.Ven_Subtotal,
dbo.Ventas.Num_venta

from dbo.Ventas inner join dbo.Usuarios on
dbo.Ventas.ID_Usuario=dbo.Usuarios.ID_Usuario
inner join dbo.Cliente on
dbo.Ventas.ID_Cliente=dbo.Cliente.ID_Cliente 
inner join dbo.Inventario on
dbo.Ventas.ID_Producto=dbo.Inventario.ID_Producto 
order by dbo.Ventas.ID_Venta desc
go



create procedure MostrarFactura
as select dbo.Factura.ID_Factura,
dbo.Ventas.ID_Venta,
dbo.Ventas.Ven_Subtotal,
dbo.Factura.Tp_Venta,
dbo.Factura.Fac_Descuento,
dbo.Factura.Fac_Impuesto,
dbo.Factura.Fac_RTN,
dbo.Factura.Fac_Total,
dbo.Ventas.Num_venta,
dbo.Ventas.Ven_Fecha

from dbo.Factura inner join dbo.Ventas on
dbo.Factura.ID_Venta=dbo.Ventas.ID_Venta
order by dbo.Factura.ID_Factura desc
go

create procedure MostrarDevoluciones
as select dbo.Devoluciones.ID_Devolu,
dbo.Factura.ID_Factura,
dbo.Devoluciones.Fecha_Devolu,
dbo.Devoluciones.Descripcion

from dbo.Devoluciones inner join dbo.Factura on
dbo.Devoluciones.ID_Factura=dbo.Factura.ID_Factura
order by dbo.Devoluciones.ID_Devolu desc
go


create procedure MostrarOportunidad
as select dbo.Oportunidades.ID_Oport,
dbo.Usuarios.ID_Usuario,
dbo.Usuarios.Usu_Nombre,
dbo.Oportunidades.Nombre_CliPoten,
dbo.Oportunidades.Descripcion,
dbo.Oportunidades.Posibi_Nego,
dbo.Oportunidades.Tel_CliPoten,
dbo.Oportunidades.Email_CliPoten
from dbo.Oportunidades inner join dbo.Usuarios on
dbo.Oportunidades.ID_Usuario=dbo.Usuarios.ID_Usuario

order by dbo.Oportunidades.ID_Oport desc
go

create procedure MostrarMarketing
as select dbo.Marketing.ID_Marketing,
dbo.Usuarios.ID_Usuario,
dbo.Usuarios.Usu_Nombre,
dbo.Cliente.ID_Cliente,
dbo.Cliente.Cli_Nombre,
dbo.Inventario.ID_Producto,
dbo.Inventario.Pro_Nombre,
dbo.Marketing.Estrategia,
dbo.Marketing.Descripcion

from dbo.Marketing inner join dbo.Usuarios on
dbo.Marketing.ID_Usuario=dbo.Usuarios.ID_Usuario
inner join dbo.Cliente on
dbo.Marketing.ID_Cliente=dbo.Cliente.ID_Cliente 
inner join dbo.Inventario on
dbo.Marketing.ID_Producto=dbo.Inventario.ID_Producto 
order by dbo.Marketing.ID_Marketing desc
go

create procedure MostrarProyectos
as select dbo.Proyectos_Marketing.ID_Proyecto,
dbo.Marketing.ID_Marketing,
dbo.Marketing.Estrategia,
dbo.Proyectos_Marketing.Nombre_Proyecto,
dbo.Proyectos_Marketing.Descripcion,
dbo.Proyectos_Marketing.Fecha_Inicial,
dbo.Proyectos_Marketing.Fecha_Conclusion

from dbo.Proyectos_Marketing inner join dbo.Marketing on
dbo.Proyectos_Marketing.ID_Marketing=dbo.Marketing.ID_Marketing

order by dbo.Proyectos_Marketing.ID_Proyecto desc
go

create procedure MostrarTareas
as select dbo.Tareas_Marketing.ID_Tarea,
dbo.Marketing.ID_Marketing,
dbo.Marketing.Estrategia,
dbo.Tareas_Marketing.Nombre_Tarea,
dbo.Tareas_Marketing.Descripcion,
dbo.Tareas_Marketing.Fecha_Inicial,
dbo.Tareas_Marketing.Fecha_Conclusion

from dbo.Tareas_Marketing inner join dbo.Marketing on
dbo.Tareas_Marketing.ID_Marketing=dbo.Marketing.ID_Marketing

order by dbo.Tareas_Marketing.ID_Tarea desc
go

--Procedimientos de Insercion

create procedure InsertarCliente
@Cli_Nombre varchar(45),
@Cli_Telefono int,
@Cli_Email varchar(45),
@Cli_NombreEmpresa varchar(45),
@Cli_TelEmpresa int,
@Cli_EmailEmpresa varchar(45),
@RTN varchar(20)

as insert into dbo.Cliente
(Cli_Nombre,Cli_Telefono,Cli_Email,Cli_NombreEmpresa,Cli_TelEmpresa,Cli_EmailEmpresa,RTN)
values
(@Cli_Nombre,@Cli_Telefono,@Cli_Email,@Cli_NombreEmpresa,@Cli_TelEmpresa,@Cli_EmailEmpresa,@RTN)
go

create procedure InsertarEmpleado
@Emp_Nombre varchar(45),
@Emp_Telefono int,
@Emp_Email varchar(45),
@Emp_Email_Pass varchar(45),
@Emp_Direccion varchar(100),
@Emp_Cargo varchar(20)

as insert into dbo.Empleado
(Emp_Nombre,Emp_Telefono,Emp_Email,Emp_Email_Pass,Emp_Direccion,Emp_Cargo)
values
(@Emp_Nombre,@Emp_Telefono,@Emp_Email,@Emp_Email_Pass,@Emp_Direccion,@Emp_Cargo)
go

create procedure InsertarProducto
@Pro_Nombre varchar(45),
@Pro_Cantidad int,
@Pro_PreVenta float,
@Pro_PreFabricacion float,
@Nombre_Compuesto varchar(20),
@Pro_Disponible int

as insert into dbo.Inventario
(Pro_Nombre,Pro_Cantidad,Pro_PreVenta,Pro_PreFabricacion,Nombre_Compuesto,Pro_Disponible)
values
(@Pro_Nombre,@Pro_Cantidad,@Pro_PreVenta,@Pro_PreFabricacion,@Nombre_Compuesto,@Pro_Disponible)
go

create procedure InsertarUsuario
@Usu_Nombre varchar(30),
@Usu_Contrasenha varchar(20),
@Usu_Cargo varchar(20),
@ID_Empleado int

as insert into dbo.Usuarios
(Usu_Nombre,Usu_Contrasenha,Usu_Cargo,ID_Empleado)
values
(@Usu_Nombre,@Usu_Contrasenha,@Usu_Cargo,@ID_Empleado)
go

create procedure InsertarVenta
@ID_Usuario int,
@ID_Cliente int,
@ID_Producto int,
@Ven_Fecha varchar(15),
@Ven_CantVendida int,
@Ven_Subtotal float,
@Num_venta int

as insert into dbo.Ventas
(ID_Usuario,ID_Cliente,ID_Producto,Ven_Fecha,Ven_CantVendida,Ven_Subtotal,Num_venta)
values
(@ID_Usuario,@ID_Cliente,@ID_Producto,@Ven_Fecha,@Ven_CantVendida,@Ven_Subtotal,@Num_venta)
go

create procedure InsertarEmail
@ID_Empleado int,
@ID_Cliente int,
@Email_Asunto varchar(40),
@Email_Mensaje varchar(250),
@Email_Fecha varchar(15)

as insert into dbo.Email
(ID_Empleado,ID_Cliente,Email_Asunto,Email_Mensaje,Email_Fecha)
values
(@ID_Empleado,@ID_Cliente,@Email_Asunto,@Email_Mensaje,@Email_Fecha)
go

create procedure InsertarFactura
@ID_Venta int,
@Tp_venta varchar(20),
@Fac_Descuento float,
@Fac_Impuesto float,
@Fac_RTN varchar(20),
@Fac_Total float,
@Num_venta int

as insert into dbo.Factura
(ID_Venta,Tp_Venta,Fac_Descuento,Fac_Impuesto,Fac_RTN,Fac_Total,Num_venta)
values
(@ID_Venta,@Tp_venta,@Fac_Descuento,@Fac_Impuesto,@Fac_RTN,@Fac_Total,@Num_venta)
go

create procedure InsertarDevolucion
@ID_Factura int,
@Descripcion varchar(50),
@Fecha_Devol varchar(15)

as insert into dbo.Devoluciones
(ID_Factura,Descripcion,Fecha_Devolu)
values
(@ID_Factura,@Descripcion,@Fecha_Devol)
go


create procedure InsertarOportunidad
@ID_Usuario int,
@Nombre_CliPoten varchar(40),
@Descripcion varchar(50),
@Posibi_Nego varchar(2),
@Tel_CliPoten varchar(10),
@Email_CliPoten varchar(30)

as insert into dbo.Oportunidades
(ID_Usuario,Nombre_CliPoten,Descripcion,Posibi_Nego,Tel_CliPoten,Email_CliPoten)
values
(@ID_Usuario,@Nombre_CliPoten,@Descripcion,@Posibi_Nego,@Tel_CliPoten,@Email_CliPoten)
go

create procedure InsertarMarketing
@ID_Usuario int,
@ID_Producto int,
@ID_Cliente int,
@Estrategia varchar(50),
@Descripcion varchar(100)

as insert into dbo.Marketing
(ID_Usuario,ID_Producto,ID_Cliente,Estrategia,Descripcion)
values
(@ID_Usuario,@ID_Producto,@ID_Cliente,@Estrategia,@Descripcion)
go

create procedure InsertarProyecto
@ID_Marketing int,
@Nombre_Proyecto varchar(30),
@Descripcion varchar(100),
@Fecha_Inicial varchar(15),
@Fecha_Conclusion varchar(15)

as insert into dbo.Proyectos_Marketing
(ID_Marketing,Nombre_Proyecto,Descripcion,Fecha_Inicial,Fecha_Conclusion)
values
(@ID_Marketing,@Nombre_Proyecto,@Descripcion,@Fecha_Inicial,@Fecha_Conclusion)
go

create procedure InsertarTarea
@ID_Marketing int,
@Nombre_Tarea varchar(30),
@Descripcion varchar(100),
@Fecha_Inicial varchar(15),
@Fecha_Conclusion varchar(15)

as insert into dbo.Tareas_Marketing
(ID_Marketing,Nombre_Tarea,Descripcion,Fecha_Inicial,Fecha_Conclusion)
values
(@ID_Marketing,@Nombre_Tarea,@Descripcion,@Fecha_Inicial,@Fecha_Conclusion)
go

--Procedimientos de Actualizacion

create procedure ActualizarCliente
@ID_Cliente int,
@Cli_Nombre varchar(45),
@Cli_Telefono int,
@Cli_Email varchar(45),
@Cli_NombreEmpresa varchar(45),
@Cli_TelEmpresa int,
@Cli_EmailEmpresa varchar(45),
@RTN varchar(20)
as
update dbo.Cliente set
 Cli_Nombre=@Cli_Nombre,
 Cli_Telefono=@Cli_Telefono,
 Cli_Email=@Cli_Email,
 Cli_NombreEmpresa=@Cli_NombreEmpresa,
 Cli_TelEmpresa=@Cli_TelEmpresa,
 Cli_EmailEmpresa=@Cli_EmailEmpresa,
 RTN=@RTN
 where 
 ID_Cliente=@ID_Cliente
go

create procedure ActualizarEmpleado
@ID_Empleado int,
@Emp_Nombre varchar(45),
@Emp_Telefono int,
@Emp_Email varchar(45),
@Emp_Email_Pass varchar(45),
@Emp_Direccion varchar(100),
@Emp_Cargo varchar(20)
as
update dbo.Empleado set	
 Emp_Nombre=@Emp_Nombre,
 Emp_Telefono=@Emp_Telefono,
 Emp_Email=@Emp_Email,
 Emp_Email_Pass=@Emp_Email_Pass,
 Emp_Direccion=@Emp_Direccion,
 Emp_Cargo=@Emp_Cargo
 where 
 ID_Empleado=@ID_Empleado
go

create procedure ActualizarInventario
@ID_Producto int,
@Pro_Nombre varchar(45),
@Pro_Cantidad int,
@Pro_PreVenta float,
@Pro_PreFabricacion float,
@Nombre_Compuesto varchar(20),
@Pro_Disponible int
as
update dbo.Inventario set	
 Pro_Nombre=@Pro_Nombre,
 Pro_Cantidad=@Pro_Cantidad,
 Pro_PreVenta=@Pro_PreVenta,
 Pro_PreFabricacion=@Pro_PreFabricacion,
 Nombre_Compuesto=@Nombre_Compuesto,
 Pro_Disponible = @Pro_Disponible
 where 
 ID_Producto=@ID_Producto
go

create procedure ActualizarUsuario
@ID_Usuario int,
@Usu_Nombre varchar(30),
@Usu_Contrasenha varchar(20),
@Usu_Cargo varchar(20),
@ID_Empleado int
as
update dbo.Usuarios set	
 Usu_Nombre=@Usu_Nombre,
 Usu_Contrasenha=@Usu_Contrasenha,
 Usu_Cargo=@Usu_Cargo,
 ID_Empleado=@ID_Empleado
 where 
 ID_Usuario=@ID_Usuario
go

--create procedure ActualizarVenta
--@ID_Usuario int,
--@ID_Cliente int,
--@ID_Producto int,
--@Ven_Fecha varchar(15),
--@Ven_CantVendida int,
--@Ven_Subtotal float
--as
--update dbo.Ventas set	
-- ID_Usuario=@ID_Usuario,
-- ID_Cliente=@ID_Cliente,
-- ID_Producto=@ID_Producto,
-- Ven_Fecha=@Ven_Fecha,
-- Ven_CantVendida = @Ven_CantVendida,
-- Ven_Subtotal = @Ven_Subtotal
-- where 
-- ID_Venta=@ID_Venta
--go

create procedure ActualizarEmail
@ID_Email int,
@ID_Empleado int,
@ID_Cliente int,
@Email_Asunto varchar(40),
@Email_Mensaje varchar(250),
@Email_Fecha varchar(15)
as
update dbo.Email set	
 ID_Empleado=@ID_Empleado,
 ID_Cliente=@ID_Cliente,
 Email_Asunto=@Email_Asunto,
 Email_Mensaje=@Email_Mensaje,
 Email_Fecha=@Email_Fecha
 where 
 ID_Email=@ID_Email
go

--create procedure ActualizarFactura
--@ID_Factura int,
--@ID_Venta int,
--@Fac_Descuento float,
--@Fac_Impuesto float,
--@Fac_RTN varchar(20),
--@Fac_Total float
--as
--update dbo.Factura set	
-- ID_Venta=@ID_Venta,
-- Fac_Descuento=@Fac_Descuento,
-- Fac_Impuesto=@Fac_Impuesto,
-- Fac_RTN=@Fac_RTN,
-- Fac_Total=@Fac_Total
-- where 
-- ID_Factura=@ID_Factura 
--go 

create procedure ActualizarDevolucion
@ID_Devolucion int,
@ID_Factura int,
@Descripcion varchar(50),
@Fecha_Devol varchar(15)
as
update dbo.Devoluciones set	
 ID_Factura=@ID_Factura,
 Descripcion=@Descripcion,
 Fecha_Devolu=@Fecha_Devol
 where 
 ID_Factura=@ID_Factura and ID_Devolu=@ID_Devolucion
go 

create procedure ActualizarOportunidad
@ID_Oport int,
@ID_Usuario int,
@Nombre_CliPoten varchar(40),
@Descripcion varchar(50),
@Posibi_Nego varchar(2),
@Tel_CliPoten varchar(10),
@Email_CliPoten varchar(30)
as
update dbo.Oportunidades set	
 ID_Usuario=@ID_Usuario,
 Nombre_CliPoten=@Nombre_CliPoten,
 Descripcion=@Descripcion,
 Posibi_Nego=@Posibi_Nego,
 Tel_CliPoten=@Tel_CliPoten,
 Email_CliPoten=@Email_CliPoten
 where 
 ID_Oport=@ID_Oport
go 

create procedure ActualizarMarketing
@ID_Marketing int,
@ID_Usuario int,
@ID_Producto int,
@ID_Cliente int,
@Estrategia varchar(50),
@Descripcion varchar(100)
as
update dbo.Marketing set	
 ID_Usuario=@ID_Usuario,
 ID_Producto=@ID_Producto,
 ID_Cliente=@ID_Cliente,
 Estrategia=@Estrategia,
 Descripcion=@Descripcion
 where 
 ID_Marketing=@ID_Marketing
go 

create procedure ActualizarProyecto
@ID_Proyecto int,
@ID_Marketing int,
@Nombre_Proyecto varchar(30),
@Descripcion varchar(100),
@Fecha_Inicial varchar(15),
@Fecha_Conclusion varchar(15)
as
update dbo.Proyectos_Marketing set	
 ID_Marketing=@ID_Marketing,
 Nombre_Proyecto=@Nombre_Proyecto,
 Descripcion=@Descripcion,
 Fecha_Inicial=@Fecha_Inicial,
 Fecha_Conclusion=@Fecha_Conclusion
 where 
 ID_Proyecto=@ID_Proyecto
go

create procedure ActualizarTarea
@ID_Tarea int,
@ID_Marketing int,
@Nombre_Tarea varchar(30),
@Descripcion varchar(100),
@Fecha_Inicial varchar(15),
@Fecha_Conclusion varchar(15)
as
update dbo.Tareas_Marketing set	
 ID_Marketing=@ID_Marketing,
 Nombre_Tarea=@Nombre_Tarea,
 Descripcion=@Descripcion,
 Fecha_Inicial=@Fecha_Inicial,
 Fecha_Conclusion=@Fecha_Conclusion
 where 
 ID_Marketing=@ID_Tarea
go  

--Procedimientos de Eliminacion

create procedure EliminarCliente
@ID_Cliente int
as
delete from dbo.Cliente
where ID_Cliente=@ID_Cliente
go

create procedure EliminarEmpleado
@ID_Empleado int
as
delete from dbo.Empleado
where ID_Empleado=@ID_Empleado
go

create procedure EliminarInventario
@ID_Producto int
as
delete from dbo.Inventario
where ID_Producto=@ID_Producto
go

create procedure EliminarUsuario
@ID_Usuario int
as
delete from dbo.Usuarios
where ID_Usuario=@ID_Usuario
go

create procedure EliminarVentas
@ID_Venta int
as
delete from dbo.Ventas
where ID_Venta=@ID_Venta
go

create procedure EliminarEmail
@ID_Email int
as
delete from dbo.Email
where ID_Email=@ID_Email
go

create procedure EliminarFactura
@ID_Factura int
as
delete from dbo.Factura
where ID_Factura=@ID_Factura
go

create procedure EliminarDevolucion
@ID_Devolu int
as
delete from dbo.Devoluciones
where ID_Devolu=@ID_Devolu
go

create procedure EliminarOportunidad
@ID_Oport int
as
delete from dbo.Oportunidades
where ID_Oport=@ID_Oport
go

create procedure EliminarMarketing
@ID_Marketing int
as
delete from dbo.Marketing
where ID_Marketing=@ID_Marketing
go

create procedure EliminarProyecto
@ID_Proyecto int
as
delete from dbo.Proyectos_Marketing
where ID_Proyecto=@ID_Proyecto
go

create procedure EliminarTarea
@ID_Tarea int
as
delete from dbo.Tareas_Marketing
where ID_Tarea=@ID_Tarea
go

delete from dbo.Tareas_Marketing
where ID_Tarea=1