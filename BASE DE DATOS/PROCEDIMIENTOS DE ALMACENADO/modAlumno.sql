CREATE DEFINER=`root`@`localhost` PROCEDURE `modAlumno`(
	in IdA int(11),
	in aNombre varchar(255),
    in aSexo varchar(45),
    in aIdCurso int(11)
)
BEGIN
	UPDATE Alumnos
	SET 
		Nombre = aNombre,
		Sexo = aSexo,
        Curso_idCurso = aIdCurso
	WHERE 
		idAlumnos = IdA;
END