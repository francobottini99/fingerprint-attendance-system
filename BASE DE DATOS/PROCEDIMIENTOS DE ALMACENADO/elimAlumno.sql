CREATE DEFINER=`root`@`localhost` PROCEDURE `elimAlumno`(
	in aID int(11)
)
BEGIN
	DELETE FROM Alumnos WHERE idAlumnos = aID;
END