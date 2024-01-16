CREATE DEFINER=`root`@`localhost` PROCEDURE `modGrupo`(
	in IdG int(11),
	in gGrupo varchar(100),
	in gIdCurso int(11),
    in gIciclo int(11),
    in gIus int(11)
)
BEGIN
	UPDATE Grupo
	SET 
		Grupo = gGrupo,
		Curso_idCurso = gIdCurso,
        CicloLectivo_idCiclo_Lectivo = gIciclo,
		Usuarios_idUsuarios = gIus
	WHERE 
		idGrupo = IdG;
END