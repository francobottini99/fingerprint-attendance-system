CREATE DEFINER=`root`@`localhost` PROCEDURE `consCursosPorCiclo`(
	in idCiclo int(11)
)
BEGIN
	SELECT
        Curso.Año,
        Curso.Division,
        Curso.CicloLectivo_idCiclo_Lectivo,
        CicloLectivo.Año Ciclo
	FROM
		Curso JOIN CicloLectivo ON Curso.CicloLectivo_idCiclo_Lectivo = CicloLectivo.idCiclo_Lectivo
	WHERE
		CicloLectivo.idCiclo_Lectivo = idCiclo;
END