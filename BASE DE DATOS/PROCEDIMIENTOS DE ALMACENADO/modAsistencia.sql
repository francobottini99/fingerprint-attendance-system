CREATE DEFINER=`root`@`localhost` PROCEDURE `modAsistencia`(
	in IdAsis int(11),
	in asFec date,
	in asAsis varchar(45),
    in asHora varchar(45),
    in asRetAnt varchar(45),
    in asJust varchar(45),
    in asIdAlum int(11),
    in asIdHor int(11),
    in asIdCilco int(11),
    in asIdUs int(11)
)
BEGIN
	UPDATE Asistencia
	SET 
		Fecha = asFec,
		Asistencia = asAsis,
        HoraIngreso = asHora,
        RetiroAnticipado = asRetAnt,
        Justificada = asJust,
		Alumnos_idAlumnos = asIdAlum,
        Horarios_idHorarios = asIdHor,
        CicloLectivo_idCiclo_Lectivo = asIdCilco,
        Usuarios_idUsuarios = asIdUs
	WHERE 
		idAsistencia = IdAsis;
END