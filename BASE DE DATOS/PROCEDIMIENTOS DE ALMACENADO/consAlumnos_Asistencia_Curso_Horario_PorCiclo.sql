CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlumnos_Asistencia_Curso_Horario_PorCiclo`(
    in idCiclo int(11)
)
BEGIN
	SELECT
		Alumnos.idAlumnos,
        Alumnos.Nombre,
        Alumnos.Sexo,
        Alumnos.idHuella_Digital,
        Alumnos.Modelo_Huella,
        Alumnos.Estado,
        Alumnos.Observaciones AlumObserv,
        Alumnos.CicloLectivo_idCiclo_Lectivo,
		Asistencia.idAsistencia,
        Asistencia.Fecha,
        Asistencia.Asistencia,
        Asistencia.HoraIngreso,
        Asistencia.RetiroAnticipado,
        Asistencia.Justificada,
        Asistencia.Observaciones AsisObserv,
        Curso.idCurso,
        Curso.Año,
        Curso.Division,
        Horarios.idHorarios,
        Horarios.Dia,
        Horarios.Turno,
        Horarios.Entrada,
        Horarios.Tipo
	FROM
		Alumnos JOIN Asistencia ON Alumnos.idAlumnos = Asistencia.Alumnos_idAlumnos
		JOIN Grupo ON Grupo.idGrupo = Alumnos.Grupo_idGrupo
        JOIN Curso ON Curso.idCurso = Grupo.Curso_idCurso
        JOIN Horarios ON Horarios.idHorarios = Asistencia.Horarios_idHorarios
	WHERE
		Alumnos.CicloLectivo_idCiclo_Lectivo = idCiclo;
END