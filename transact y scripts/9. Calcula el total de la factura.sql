CREATE PROCEDURE CALCULAR_TOTAL_FACTURA (@FACTURA_ID INT)
AS
BEGIN
	DECLARE @VALOR_REPUESTOS MONEY;
	DECLARE @VALOR_SERVICIOS MONEY;
	DECLARE @VALOR_TOTAL MONEY;

	SELECT @VALOR_REPUESTOS =  SUM(R.PRECIO_UNIDAD * FR.CANTIDAD)  FROM FACTURA_REPUESTOS FR
		INNER JOIN REPUESTO R ON FR.REPUESTO_ID = R.ID WHERE FR.FACTURA_ID = @FACTURA_ID

	SELECT @VALOR_SERVICIOS = SUM(FS.PRECIO) FROM FACTURA_SERVICIO FS
		INNER JOIN SERVICIO S ON FS.SERVICIO_ID = S.ID WHERE FS.FACTURA_ID = @FACTURA_ID

	SELECT @VALOR_SERVICIOS = IIF(@VALOR_SERVICIOS IS NULL, 0, @VALOR_SERVICIOS)
	SELECT @VALOR_REPUESTOS = IIF(@VALOR_REPUESTOS IS NULL, 0, @VALOR_REPUESTOS)

	SELECT @VALOR_REPUESTOS, @VALOR_SERVICIOS

	IF @VALOR_REPUESTOS > 3000000
		SELECT @VALOR_SERVICIOS = @VALOR_SERVICIOS * 0.5

	SELECT @VALOR_TOTAL = @VALOR_REPUESTOS + @VALOR_SERVICIOS + ((@VALOR_REPUESTOS + @VALOR_SERVICIOS) * 0.19)

	SELECT @VALOR_REPUESTOS V_REPUESTOS, @VALOR_SERVICIOS V_SERVICIOS, @VALOR_TOTAL V_TOTAL
	UPDATE FACTURA SET TOTAL = @VALOR_TOTAL WHERE ID = @FACTURA_ID
END
EXEC CALCULAR_TOTAL_FACTURA @FACTURA_ID = 3