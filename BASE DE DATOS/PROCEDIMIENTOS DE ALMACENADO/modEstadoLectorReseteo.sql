CREATE DEFINER=`root`@`localhost` PROCEDURE `modEstadoLectorReseteo`(
)
BEGIN
	UPDATE Lectores
	SET 
		Estado = "-";
END