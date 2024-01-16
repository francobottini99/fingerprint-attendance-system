CREATE DEFINER=`root`@`localhost` PROCEDURE `verUsuarios`(
)
BEGIN
	SELECT
		*
	FROM
		Usuarios
	WHERE
		Nombre != 'SIA'
    ORDER BY
		Nombre ASC;
END