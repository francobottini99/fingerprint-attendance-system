CREATE DEFINER=`root`@`localhost` PROCEDURE `verUsuario_Nombre`(
	in uNombre varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Usuarios
	WHERE
		Nombre = uNombre;
END