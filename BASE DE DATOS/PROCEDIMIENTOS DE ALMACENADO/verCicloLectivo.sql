CREATE DEFINER=`root`@`localhost` PROCEDURE `verCicloLectivo`(
)
BEGIN
	SELECT
		*
	FROM
		CicloLectivo
	ORDER BY 
		Año ASC;
END