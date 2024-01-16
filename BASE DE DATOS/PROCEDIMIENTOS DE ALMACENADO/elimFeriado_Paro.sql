CREATE DEFINER=`root`@`localhost` PROCEDURE `elimFeriado_Paro`(
	in fpID int(11)
)
BEGIN
	DELETE FROM Feriados_Paros WHERE idFeriados_Paros = fpID;
END