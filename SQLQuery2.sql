create database Contador;

use Contador

create table EstadoResultado(
IngresosActividades varchar (7) not null,
DescuentosBonificaciones varchar (7) not null,
IngresosOperativosNetos varchar (7) not null,
CostoBienesVendidos varchar (7) not null,
ResultadoBruto varchar (7) not null,
GastosVentas varchar (7) not null,
GastosAdministración varchar (7) not null,
ResultadoOperacionesOrdinarias varchar (7) not null,
IngresosFinancieros varchar (7) not null,
GastosFinancieros varchar (7) not null,
IngresosExtraordinarios varchar (7) not null,
GastosExtraordinarios varchar (7) not null,
IngresosEjerciciosAnteriores varchar (7) not null,
GastosIngresosAnteriores varchar (7) not null,
ResultadoANTESImpuesto varchar (7) not null,
ImpuestoGanancias varchar (7) not null,
ResultadoNeto varchar (7) not null
)




select * from EstadoResultado


go
create proc InsertarEstadoResultado
@IngA varchar(7),@DB varchar(7),@ION varchar(7),
@CBV varchar(7),@RB varchar(7),@GV varchar(7),
@GA varchar(7),@ROO varchar(7),@IngF varchar(7),
@GF varchar(7),@IngE varchar(7),@GasE varchar(7),@IEA varchar(7),
@GIA varchar(7),@RAI varchar(7),@IG varchar(7),@RN varchar(7)
as
   insert into BalanceGeneral (IngresosActividades,DescuentosBonificaciones,
IngresosOperativosNetos,CostoBienesVendidos,ResultadoBruto,
GastosVentas,GastosAdministración,ResultadoOperacionesOrdinarias,
IngresosFinancieros,IngresosExtraordinarios,GastosExtraordinarios
,IngresosEjerciciosAnteriores,GastosIngresosAnteriores,
ResultadoANTESImpuesto,ImpuestoGanancias,ResultadoNeto) values (@IngA,@DB,
@ION,@CBV,@RB,@GV,@GA,@ROO,@IngF,@GF,@IngE,@GasE,@IEA,
@GIA,@RAI,@IG,@RN
) 
go
select * from EstadoResultado