CREATE DEFINER=`root`@`localhost` PROCEDURE `elimCurso`(
	in cID int(11)
)
BEGIN
	DELETE FROM Curso WHERE idCurso = cID;
END