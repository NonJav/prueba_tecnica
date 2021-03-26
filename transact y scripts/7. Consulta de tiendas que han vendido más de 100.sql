-- Consulta de las tiendas que han vendido m�s de 100 UND del producto 100 en los �ltimos 60 d�as.
SELECT
	T.DIRECCION AS TIENDA, R.NOMBRE, SUM(FR.CANTIDAD) AS CANTIDAD
FROM TALLER T
	INNER JOIN FACTURA F ON T.ID = F.TALLER_ID
	INNER JOIN FACTURA_REPUESTOS FR ON F.ID = FR.FACTURA_ID
	INNER JOIN REPUESTO R ON FR.REPUESTO_ID = R.ID
WHERE R.ID = 3 AND F.ESTADO = 'terminado' AND F.FECHA_CREACION >= DATEADD(DAY, -60, GETDATE())
GROUP BY R.NOMBRE, T.DIRECCION
HAVING SUM(FR.CANTIDAD) > 100