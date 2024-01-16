CREATE DEFINER=`root`@`localhost` PROCEDURE `modHorario`(
	in IdH int(11),
	in hDia varchar(10),
    in hTurno Varchar(10),
    in hEntrada Varchar(15),
    in hTipo varchar(45),
	in hGrupo int(11),
    in hCiclo int(11),
    in hUs int(11)
)
BEGIN
	UPDATE Horarios
	SET 
		Dia = hDia,
		Turno = hTurno,
        Entrada = hEntrada,
        Tipo = hTipo,
        Grupo_idGrupo = hGrupo,
        CicloLectivo_idCiclo_Lectivo = hCiclo,
        Usuarios_idUsuarios = hUs
	WHERE 
		idHorarios = IdH;
END