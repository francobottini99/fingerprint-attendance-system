CREATE DEFINER=`root`@`localhost` PROCEDURE `consHorarios_Grupo_Curso`(
)
BEGIN
	SELECT
		Curso.Año Año,
        Curso.Division Divs,
        Grupo.Grupo Grp,
        Horarios.Dia Día,
        Horarios.Turno Trn,
        Horarios.Entrada Hr_Ing,
        Horarios.Tipo Tipo,
        Curso.idCurso,
        Horarios.idHorarios,
        Grupo.idGrupo
	FROM
		Horarios JOIN Grupo ON Horarios.Grupo_idGrupo = Grupo.idGrupo
		JOIN Curso ON Curso.idCurso = Grupo.Curso_idCurso
	WHERE
		Tipo != "-";
END