CREATE DEFINER=`root`@`localhost` PROCEDURE `insCurso`(
	in cAño int(11),
	in cDivsion varchar(10),
    in cDcic int (11),
    in cIdUs int(11)
)
BEGIN
	INSERT INTO Curso (
		Año,
		Division,
        CicloLectivo_idCiclo_Lectivo,
        Usuarios_idUsuarios
)
	VALUES (cAño, cDivsion, cDcic, cIdUs);
END