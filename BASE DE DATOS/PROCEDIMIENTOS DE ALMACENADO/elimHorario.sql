CREATE DEFINER=`root`@`localhost` PROCEDURE `elimHorario`(
	in hID int(11)
)
BEGIN
	DELETE FROM Horarios WHERE idHorarios = hID;
END