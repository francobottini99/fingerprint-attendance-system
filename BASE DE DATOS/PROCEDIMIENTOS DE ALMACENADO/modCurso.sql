CREATE DEFINER=`root`@`localhost` PROCEDURE `modCurso`(
	in IdC int(11),
    in cAño int(11),
    in cDivision varchar(255),
    in cIdUs int(11)
)
BEGIN
	UPDATE Curso
	SET 
		Año= cAño,
		Division = cDivision,
        Usuarios_idUsuarios = cIdUs
	WHERE 
		idCurso = IdC;
END