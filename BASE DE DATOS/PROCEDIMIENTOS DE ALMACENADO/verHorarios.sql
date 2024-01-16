CREATE DEFINER=`root`@`localhost` PROCEDURE `verHorarios`(
)
BEGIN
	SELECT
		*
	FROM
		Horarios
	ORDER BY 
		Dia ASC;
END