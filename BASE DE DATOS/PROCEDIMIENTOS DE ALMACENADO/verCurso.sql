CREATE DEFINER=`root`@`localhost` PROCEDURE `verCurso`(
)
BEGIN
	SELECT
		*
	FROM
		Curso
	ORDER BY 
		Año ASC;
END