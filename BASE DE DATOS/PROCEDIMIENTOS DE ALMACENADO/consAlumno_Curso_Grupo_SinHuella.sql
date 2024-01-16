CREATE DEFINER=`root`@`localhost` PROCEDURE `consAlumno_Curso_Grupo_SinHuella`(
	in aIdCurso int(11),
    in aIdGrupo int(11),
	in aIdCl int(11)
)
BEGIN
	SELECT
		Alumnos.idAlumnos,
        Alumnos.Nombre,
        Alumnos.Sexo,
        Alumnos.idHuella_Digital,
        Alumnos.Modelo_Huella,
        Alumnos.Estado,
        Grupo.idGrupo,
        Grupo.Grupo,
        Curso.idCurso,
        Curso.Año,
        Curso.Division,
        Alumnos.CicloLectivo_idCiclo_Lectivo,
        Alumnos.Usuarios_idUsuarios
	FROM
		Alumnos JOIN Grupo ON Alumnos.Grupo_idGrupo = Grupo.idGrupo
        JOIN Curso ON Grupo.Curso_idCurso = Curso.idCurso
	WHERE
		Grupo.Curso_idCurso = aIdCurso AND Alumnos.Grupo_idGrupo = aIdGrupo AND Alumnos.idHuella_Digital = 0 AND Alumnos.CicloLectivo_idCiclo_Lectivo = aIdCl;
END