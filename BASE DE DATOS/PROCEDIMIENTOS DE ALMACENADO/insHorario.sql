CREATE DEFINER=`root`@`localhost` PROCEDURE `insHorario`(
	in hDia varchar(10),
    in hTurno Varchar(10),
    in hEntrada Varchar(15),
    in hTipo varchar(45),
	in hGrupo int(11),
    in hCurso int(11)
)
BEGIN
	INSERT INTO Horarios (
		Dia,
		Turno,
        Entrada,
        Tipo,
        Grupo_idGrupo,
        Curso_idCurso
)
	VALUES (hDia, hTurno, hEntrada, hTipo, hGrupo, hCurso);
END