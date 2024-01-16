CREATE DEFINER=`root`@`localhost` PROCEDURE `verGrupo_Curso`(
	in gIdCurso int(11)
)
BEGIN
	SELECT
		*
	FROM
		Grupo
	WHERE
		Curso_idCurso = gIdCurso;
END