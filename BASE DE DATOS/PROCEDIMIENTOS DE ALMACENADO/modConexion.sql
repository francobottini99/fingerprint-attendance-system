CREATE DEFINER=`root`@`localhost` PROCEDURE `modConexion`(
	in cVb varchar(45)
)
BEGIN
	UPDATE Conexion
	SET 
		Programa = cVb
	WHERE 
		idConexion = 1;
END