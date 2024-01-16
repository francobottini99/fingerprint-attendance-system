CREATE DEFINER=`root`@`localhost` PROCEDURE `verHorario_Dia_Turno_Tipo_Curso_Grupo`(
	in hDia varchar(10),
    in hTurno Varchar(10),
    in hTipo varchar(45),
    in hCurso int(11),
    in hGrupo int(11)
)
BEGIN
	SELECT
		*
	FROM
		Horarios
	WHERE
		Dia = hDia AND Turno = hTurno AND Tipo = hTipo AND Curso_idCurso = hCurso AND Grupo_idGrupo = hGrupo;
END