CREATE DEFINER=`root`@`localhost` PROCEDURE `consHorarios_Curso_Tipo_Dia_Turno_Grupo`(
	in hIdCurso int(11),
    in hTipo varchar(45),
    in hDia varchar(10),
    in hTurno varchar(10),
    in hGrupo varchar (250)
)
BEGIN
	SELECT
        Horarios.idHorarios,
        Horarios.Dia,
        Horarios.Turno,
        Horarios.Entrada,
        Horarios.Tipo,
        Curso.idCurso,
        Curso.Año,
        Curso.Division,
        Grupo.idGrupo,
        Grupo.Grupo
	FROM
		Horarios JOIN Grupo ON Horarios.Grupo_idGrupo = Grupo.idGrupo
		JOIN Curso ON Curso.idCurso = Grupo.Curso_idCurso
	WHERE
		Curso.idCurso = hIdCurso AND Horarios.Tipo = hTipo AND Horarios.Dia = hDia AND Horarios.Turno = hTurno AND Horarios.Grupo_idGrupo = hGrupo;
END