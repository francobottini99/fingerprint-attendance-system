CREATE DEFINER=`root`@`localhost` PROCEDURE `insAlumno`(
	in aNombre varchar(255),
    in aSexo varchar(45),
	in aiDHuella int(11),
    in aModHuella longtext,
    in aEstado varchar(45),
    in aObs varchar(255),
    in aIdGrupo int(11),
    in aIdCic int(11),
    in aIdus int(11),
    in aIdCurso int(11)
)
BEGIN
	INSERT INTO Alumnos (
		Nombre,
		Sexo,
        idHuella_Digital,
        Modelo_Huella,
        Estado,
        Observaciones,
        Grupo_idGrupo,
        CicloLectivo_idCiclo_Lectivo,
        Usuarios_idUsuarios,
        Curso_idCurso
)
	VALUES (aNombre, aSexo, aiDHuella, aModHuella, aEstado, aObs, aIdGrupo, aIdCic, aIdus, aIdCurso);
END