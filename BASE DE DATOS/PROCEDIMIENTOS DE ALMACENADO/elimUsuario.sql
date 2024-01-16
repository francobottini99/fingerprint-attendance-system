CREATE DEFINER=`root`@`localhost` PROCEDURE `elimUsuario`(
	in aID int(11)
)
BEGIN
	DELETE FROM Usuarios WHERE idUsuarios = aID;
END