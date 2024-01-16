CREATE DEFINER=`root`@`localhost` PROCEDURE `modEstadoLector`(
	in idL int(11),
    in Est varchar(45)
)
BEGIN
	UPDATE Lectores
	SET 
		Estado = Est
	WHERE 
		idLector = idL;
END