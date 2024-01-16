CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlumno_Grupo`(
	in aIdGrupo int(11)
)
BEGIN
	SELECT
		Alumnos.idAlumnos,
        Alumnos.Nombre,
        Alumnos.Sexo,
        Alumnos.idHuella_Digital,
        Alumnos.Estado,
        Grupo.idGrupo,
        Grupo.Grupo,
        Curso.idCurso,
        Curso.Año,
        Curso.Division
	FROM
		Alumnos JOIN Curso ON Grupo.Curso_idCurso = Curso.idCurso
        JOIN Grupo ON Alumnos.Grupo_idGrupo = Grupo.idGrupo
	WHERE
		Alumnos.Grupo_idGrupo = aIdGrupo;
END