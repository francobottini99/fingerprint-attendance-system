CREATE DEFINER=`root`@`localhost` PROCEDURE `verAlumno_Nombre_idCurso`(
	in aNombre varchar(100),
	in aIdCurso int(11)
)
BEGIN
	SELECT
		*
	FROM
		Alumnos
	WHERE
		Nombre = aNombre AND Curso_idCurso = aIdCurso;
END