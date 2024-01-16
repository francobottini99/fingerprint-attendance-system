CREATE DEFINER=`root`@`localhost` PROCEDURE `insGrupo`(
	in gGrupo varchar(100),
	in gIdCurso int(11),
    in gIdcic int (11),
    in gIus int(11)
)
BEGIN
	INSERT INTO Grupo (
		Grupo,
		Curso_idCurso,
        CicloLectivo_idCiclo_Lectivo,
        Usuarios_idUsuarios
)
	VALUES (gGrupo, gIdCurso, gIdcic, gIus);
END