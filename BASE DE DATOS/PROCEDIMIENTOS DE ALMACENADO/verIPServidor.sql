CREATE DEFINER=`root`@`localhost` PROCEDURE `verIPServidor`(
)
BEGIN
	SELECT
		*
	FROM
		Servidor;
END