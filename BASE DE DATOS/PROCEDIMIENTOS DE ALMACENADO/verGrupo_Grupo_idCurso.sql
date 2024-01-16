CREATE DEFINER=`root`@`localhost` PROCEDURE `verGrupo_Grupo_idCurso`(
	in gGrupo varchar(100),
	in gIdCurso int(11),
    in gIdCiclo int(11)
)
BEGIN
	SELECT
		*
	FROM
		Grupo
	WHERE
		Grupo = gGrupo AND Curso_idCurso = gIdCurso AND CicloLectivo_idCiclo_Lectivo = gIdCiclo;
END