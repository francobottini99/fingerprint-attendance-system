CREATE DEFINER=`root`@`localhost` PROCEDURE `verHuella_idAlumno`(
	in aIdAlumno int(11)
)
BEGIN
	SELECT
		*
	FROM
		Alumnos
	WHERE
		idAlumnos = aIdAlumno;
END