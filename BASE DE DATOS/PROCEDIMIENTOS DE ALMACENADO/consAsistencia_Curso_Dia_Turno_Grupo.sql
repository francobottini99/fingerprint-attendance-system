CREATE DEFINER=`root`@`localhost` PROCEDURE `consAsistencia_Curso_Dia_Turno_Grupo`(
	in asFecha date,
    in asCurso int(11),
    in asTurno varchar(50),
    in asGrupo int(11)
)
BEGIN
	SELECT
		Asistencia.idAsistencia,
        Asistencia.Fecha,
        Alumnos.idAlumnos,
        Alumnos.Nombre,
        Asistencia.Asistencia Asis,
        Asistencia.RetiroAnticipado Retiro,
        Asistencia.Justificada Just,
        Asistencia.HoraIngreso,
        Horarios.idHorarios,
        Horarios.Dia,
        Horarios.Turno,
        Horarios.Entrada,
        Horarios.Tipo,
        Asistencia.CicloLectivo_idCiclo_Lectivo,
        Asistencia.Usuarios_idUsuarios
	FROM
		Asistencia JOIN Horarios ON Asistencia.Horarios_idHorarios = Horarios.idHorarios
		JOIN Alumnos ON Alumnos.idAlumnos = Asistencia.Alumnos_idAlumnos
        JOIN Grupo ON Grupo.idGrupo = Alumnos.Grupo_idGrupo
        JOIN Curso ON Curso.idCurso = Grupo.Curso_idCurso
	WHERE
		Asistencia.Fecha = asFecha AND Curso.idCurso = asCurso AND Horarios.Turno = asTurno AND Grupo.idGrupo = idGrupo;
END