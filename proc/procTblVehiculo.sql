

--Procedimiento para retornar valores de cotizacion 


CREATE PROCEDURE [dbo].[SpSVehiculo]
	@Pcriterio varchar(50)
As
BEGIN
	SELECT 
	vlo.idVehiculo as idVehiculo, tvlo.nombre AS TipoVehiculo,
	mca.nombre As marca, lna.nombre AS linea, vlo.modelo AS modelo,
	vlo.placa AS placa, vlo.color AS color, vlo.estado AS estado,
	vlo.fechaIngreso AS fechaIngreso
	FROM TblVehiculo AS vlo
	LEFT outer JOIN dbo.TblLinea AS lna
	ON lna.idLinea = vlo.idLinea
	left outer JOIN dbo.TblMarca as mca
	ON mca.idMarca = lna.idMarca
	left JOIN dbo.TblTipoVehiculo as tvlo
	ON tvlo.idTipoVehiculo = vlo.idTipoVehiculo
	WHERE 
	vlo.placa LIKE '%'+ISNULL(@Pcriterio,vlo.placa)+'%' OR
	vlo.color LIKE '%'+ISNULL(@Pcriterio,vlo.color)+'%' OR
	vlo.modelo LIKE '%'+ISNULL(@Pcriterio,vlo.modelo)+'%' OR
	lna.nombre LIKE '%'+ISNULL(@Pcriterio,lna.nombre)+'%' OR
	mca.nombre LIKE '%'+ISNULL(@Pcriterio,mca.nombre)+'%'	
END;
	
	exec SpSVehiculo @Pcriterio = ''









--Procedimiento para retornar valores de cotizacion 

CREATE PROCEDURE [dbo].[SpCotizacion]
	@Pcriterio varchar(50)
As
BEGIN
	SELECT 
	vlo.idVehiculo as idVehiculo, tvlo.nombre AS TipoVehiculo,
	mca.nombre As marca, lna.nombre AS linea, vlo.modelo AS modelo,
	vlo.placa AS placa, vlo.color AS color, vlo.estado AS estado,
	vlo.fechaIngreso AS fechaIngreso
	FROM TblVehiculo AS vlo
	LEFT outer JOIN dbo.TblLinea AS lna
	ON lna.idLinea = vlo.idLinea
	left outer JOIN dbo.TblMarca as mca
	ON mca.idMarca = lna.idMarca
	left JOIN dbo.TblTipoVehiculo as tvlo
	ON tvlo.idTipoVehiculo = vlo.idTipoVehiculo
	WHERE 
	vlo.placa LIKE '%'+ISNULL(@Pcriterio,vlo.placa)+'%' OR
	vlo.color LIKE '%'+ISNULL(@Pcriterio,vlo.color)+'%' OR
	vlo.modelo LIKE '%'+ISNULL(@Pcriterio,vlo.modelo)+'%' OR
	lna.nombre LIKE '%'+ISNULL(@Pcriterio,lna.nombre)+'%' OR
	mca.nombre LIKE '%'+ISNULL(@Pcriterio,mca.nombre)+'%'	
END;	


