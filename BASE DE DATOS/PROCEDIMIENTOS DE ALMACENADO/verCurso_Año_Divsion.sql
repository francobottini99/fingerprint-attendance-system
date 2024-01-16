CREATE DEFINER=`root`@`localhost` PROCEDURE `verCurso_Año_Divsion`(
	in cAño int(11),
    in cDivision varchar(10),
	in cIdCiclo int(11)
)
BEGIN
	SELECT
		*
	FROM
		Curso
	WHERE
		Año = cAño AND Division = cDivision AND CicloLectivo_idCiclo_Lectivo = cIdCiclo;
END