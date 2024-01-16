CREATE DEFINER=`root`@`localhost` PROCEDURE `consUsuarioContraseña`(
	in ingN varchar(255),
    in ingC varchar(255)
)
BEGIN
	SELECT
		*
	FROM
		Usuarios
	WHERE
		Nombre = ingN AND Clave = ingC;
END