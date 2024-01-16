CREATE DEFINER=`root`@`localhost` PROCEDURE `modTolerancia`(
	in IdT int(11),
	in tTarde varchar(45),
    in tAusente varchar(45),
    in tIdUs int(11)
)
BEGIN
	UPDATE Tolerancia
	SET 
		Llegada_Tarde = tTarde,
		Ausente = tAusente,
        Usuarios_idUsuarios = tIdUs
	WHERE 
		idTolerancia = IdT;
END