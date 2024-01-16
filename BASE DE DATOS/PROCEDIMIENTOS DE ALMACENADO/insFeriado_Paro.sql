CREATE DEFINER=`root`@`localhost` PROCEDURE `insFeriado_Paro`(
	in fpFecha date,
    in fpMot varchar(255),
    in fpIdCL int(11),
    in fUsid int(11)
)
BEGIN
	INSERT INTO Feriados_Paros (
		Fecha,
        Motivo,
        CicloLectivo_idCiclo_Lectivo,
        Usuarios_idUsuarios
)
	VALUES (fpFecha, fpMot, fpIdCL, fUsid);
END