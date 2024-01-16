CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlumnos`(
)
BEGIN
	SELECT
		*
	FROM
		Alumnos
	ORDER BY 
		Nombre ASC;
END