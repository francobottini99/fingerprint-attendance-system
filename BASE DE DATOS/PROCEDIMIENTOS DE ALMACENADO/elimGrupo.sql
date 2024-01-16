CREATE DEFINER=`root`@`localhost` PROCEDURE `elimGrupo`(
	in gID int(11)
)
BEGIN
	DELETE FROM Grupo WHERE idGrupo = gID;
END