CREATE DEFINER=`root`@`localhost` PROCEDURE `insAsistencia`(
	in aFecha date,
    in aAsis varchar(45),
	in aHoraIngreso varchar(45),
    in aRetAnt varchar(45),
    in aJust varchar(45),
    in aidAlum int(11),
    in aidHor int(11),
    in aidCiclo int(11),
    in aidUs int(11)
)
BEGIN
	INSERT INTO Asistencia (
		Fecha,
		Asistencia,
        HoraIngreso,
        RetiroAnticipado,
        Justificada,
        Alumnos_idAlumnos,
        Horarios_idHorarios,
        CicloLectivo_idCiclo_Lectivo,
        Usuarios_idUsuarios)
	VALUES (aFecha, aAsis, aHoraIngreso, aRetAnt, aJust, aidAlum, aidHor, aidCiclo, aidUs);
END