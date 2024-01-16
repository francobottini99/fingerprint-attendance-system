CREATE DEFINER=`root`@`localhost` PROCEDURE `consGrupo_Curso`(
)
BEGIN
	SELECT
        Grupo.idGrupo,
        Grupo.Grupo,
        Curso.idCurso,
        Curso.Año,
        Curso.Division,
        CicloLectivo.Año Ciclo
	FROM
		Grupo JOIN Curso ON Grupo.Curso_idCurso = Curso.idCurso
        JOIN CicloLectivo ON CicloLectivo.idCiclo_Lectivo = Curso.CicloLectivo_idCiclo_Lectivo
	WHERE
		Grupo.Grupo != "Ninguno" AND Grupo.Grupo != "Todos";
END