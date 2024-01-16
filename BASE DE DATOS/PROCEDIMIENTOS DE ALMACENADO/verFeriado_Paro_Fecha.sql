CREATE DEFINER=`root`@`localhost` PROCEDURE `verFeriado_Paro_Fecha`(
	in fpFecha date
)
BEGIN
	SELECT
		*
	FROM
		Feriados_Paros
	WHERE
		Fecha = fpFecha;
END