CREATE DEFINER=`root`@`localhost` PROCEDURE `verFeriado_Paro`(
)
BEGIN
	SELECT
		*
	FROM
		Feriados_Paros;
END